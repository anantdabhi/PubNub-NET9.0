using NUnit.Framework;
using NUnit.Framework.Legacy;
using PubnubApi.EventEngine.Core;
using PubnubApi.EventEngine.Subscribe.Common;
using PubnubApi.EventEngine.Subscribe.Events;
using PubnubApi.EventEngine.Subscribe.Invocations;
using PubnubApi.EventEngine.Subscribe.States;
using System.Linq;

namespace PubnubApi.Tests.EventEngine
{
    internal class HandshakingStateTransition
    {
        private static object[] handshakingEventCases = {
            new object[] {
                new HandshakingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new SubscriptionChangedEvent()
                {
                    Channels = new string[] { "ch1", "ch2", "ch3" },
                    ChannelGroups = new string[] { "cg1", "cg2", "cg3" }
                },
                new HandshakingState(){ Channels = new string[] { "ch1", "ch2", "ch3" }, ChannelGroups = new string[] { "cg1", "cg2", "cg3" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } }
            },
            new object[]
            {
                new HandshakingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" }, },
                new SubscriptionRestoredEvent()
                {
                    Channels = new string[] { "ch1", "ch2" },
                    ChannelGroups = new string[] { "cg1", "cg2" },
                    Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 }
                },
                new HandshakingState(){ Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } }
            }
        };

        [TestCaseSource(nameof(handshakingEventCases))]
        public void HandshakingState_OnEvent_TransitionToHandshakingState(
            HandshakingState handshakingState, IEvent @event, HandshakingState expectedState) 
        {
            //Act
            var result = handshakingState.Transition(@event);

            //Assert
            ClassicAssert.IsInstanceOf<HandshakingState>(result.State);
            ClassicAssert.AreEqual(expectedState.Channels, ((HandshakingState)result.State).Channels);
            ClassicAssert.AreEqual(expectedState.ChannelGroups, ((HandshakingState)result.State).ChannelGroups);
            if (@event is SubscriptionRestoredEvent)
            {
            ClassicAssert.AreEqual(expectedState.Cursor.Region, ((HandshakingState)result.State).Cursor.Region);
            ClassicAssert.AreEqual(expectedState.Cursor.Timetoken, ((HandshakingState)result.State).Cursor.Timetoken);
            }
        }

        private HandshakingState CreateHandshakingState()
        {
            return new HandshakingState() 
            { 
                Channels = new string[] { "ch1", "ch2" }, 
                ChannelGroups = new string[] { "cg1", "cg2" }, 
            };
        }

        [NUnit.Framework.Test]
        public void HandshakingState_OnHandshakeFailureEvent_TransitionToHandshakeReconnectingState()
        {
            //Arrange
            var currentState = CreateHandshakingState();
            var eventToTriggerTransition = new HandshakeFailureEvent() { };
            var expectedState = new HandshakeReconnectingState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
            };
            
            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<HandshakeReconnectingState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((HandshakeReconnectingState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((HandshakeReconnectingState)result.State).ChannelGroups);
        }

        [NUnit.Framework.Test]
        public void HandshakingState_OnDisconnectEvent_TransitionToHandshakeStoppedState() 
        {
            //Arrange
            var handshakingState = CreateHandshakingState();
            var eventToTriggerTransition = new DisconnectEvent() 
            { 
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 }
            };
            var expectedState = new HandshakeStoppedState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
            };

            //Act
            var result = handshakingState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<HandshakeStoppedState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((HandshakeStoppedState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((HandshakeStoppedState)result.State).ChannelGroups);
            ClassicAssert.IsInstanceOf<EmitStatusInvocation>(result.Invocations.ElementAt(0));
            ClassicAssert.AreEqual(PNStatusCategory.PNDisconnectedCategory, ((EmitStatusInvocation)result.Invocations.ElementAt(0)).StatusCategory);
        }

        [NUnit.Framework.Test]
        public void HandshakingState_OnHandshakeSuccessEvent_TransitionToReceivingState()
        {
            //Arrange
            var handshakingState = CreateHandshakingState();
            var eventToTriggerTransition = new HandshakeSuccessEvent() 
            { 
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
                Status = new PNStatus(null,PNOperationType.PNSubscribeOperation, PNStatusCategory.PNConnectedCategory, handshakingState.Channels, handshakingState.ChannelGroups)
            };
            var expectedState = new ReceivingState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
            };

            //Act
            var result = handshakingState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<ReceivingState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((ReceivingState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((ReceivingState)result.State).ChannelGroups);
            ClassicAssert.IsInstanceOf<EmitStatusInvocation>(result.Invocations.ElementAt(0));
            ClassicAssert.AreEqual(PNStatusCategory.PNConnectedCategory, ((EmitStatusInvocation)result.Invocations.ElementAt(0)).StatusCategory);
        }

        [NUnit.Framework.Test]
        public void HandshakingState_OnUnsubscribeEvent_TransitionToUnsubscribedState()
        {
            //Arrange
            var currentState = CreateHandshakingState();
            var eventToTriggerTransition = new UnsubscribeAllEvent();

            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<UnsubscribedState>(result.State);
        }

    }
}
