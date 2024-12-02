using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnit.Framework.Legacy;
using PubnubApi.EventEngine.Core;
using PubnubApi.EventEngine.Subscribe.Common;
using PubnubApi.EventEngine.Subscribe.Events;
using PubnubApi.EventEngine.Subscribe.Invocations;
using PubnubApi.EventEngine.Subscribe.States;
using System.Linq;

namespace PubnubApi.Tests.EventEngine
{
    internal class ReceivingStateTransition
    {
        private static object[] receivingEventCases = {
            new object[] {
                new ReceivingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new SubscriptionChangedEvent()
                {
                    Channels = new string[] { "ch1", "ch2", "ch3" },
                    ChannelGroups = new string[] { "cg1", "cg2", "cg3" }
                },
                new ReceivingState(){ Channels = new string[] { "ch1", "ch2", "ch3" }, ChannelGroups = new string[] { "cg1", "cg2", "cg3" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } }
            },
            new object[]
            {
                new ReceivingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new SubscriptionRestoredEvent()
                {
                    Channels = new string[] { "ch1", "ch2" },
                    ChannelGroups = new string[] { "cg1", "cg2" },
                    Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 }
                },
                new ReceivingState(){ Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } }
            },
            new object[]
            {
                new ReceivingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new ReceiveSuccessEvent()
                {
                    Channels = new string[] { "ch1", "ch2" },
                    ChannelGroups = new string[] { "cg1", "cg2" },
                    Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
                    Status = new PNStatus(null, PNOperationType.PNSubscribeOperation, PNStatusCategory.PNConnectedCategory),
                    Messages = new ReceivingResponse<object>() {  Messages = new Message<object>[]{ }, Timetoken = new Timetoken(){ Region = 1, Timestamp = 1234567890 } }
                },
                new ReceivingState(){ Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } }
            }

        };

        [TestCaseSource(nameof(receivingEventCases))]
        public void ReceivingState_OnEvent_TransitionToReceivingState(
            ReceivingState receivingState, IEvent @event, ReceivingState expectedState) 
        {
            //Act
            var result = receivingState.Transition(@event);

            //Assert
            ClassicAssert.IsInstanceOf<ReceivingState>(result.State);
            ClassicAssert.AreEqual(expectedState.Channels, ((ReceivingState)result.State).Channels);
            ClassicAssert.AreEqual(expectedState.ChannelGroups, ((ReceivingState)result.State).ChannelGroups);
            if (@event is SubscriptionRestoredEvent || @event is ReceiveSuccessEvent)
            {
            ClassicAssert.AreEqual(expectedState.Cursor.Region, ((ReceivingState)result.State).Cursor.Region);
            ClassicAssert.AreEqual(expectedState.Cursor.Timetoken, ((ReceivingState)result.State).Cursor.Timetoken);
            }
            if (@event is ReceiveSuccessEvent)
            {
                ClassicAssert.IsInstanceOf<EmitMessagesInvocation>(result.Invocations.ElementAt(0));
            }
        }

        private ReceivingState CreateReceivingState()
        {
            return new ReceivingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" }, Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 } };
        }

        [NUnit.Framework.Test]
        public void ReceivingState_OnDisconnectEvent_TransitionToReceiveStoppedState()
        {
            //Arrange
            var currentState = CreateReceivingState();
            var eventToTriggerTransition = new DisconnectEvent()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" }
            };
            var expectedState = new ReceiveStoppedState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
            };

            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<ReceiveStoppedState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((ReceiveStoppedState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((ReceiveStoppedState)result.State).ChannelGroups);
            ClassicAssert.AreEqual(expectedState.Cursor.Region, ((ReceiveStoppedState)result.State).Cursor.Region);
            ClassicAssert.AreEqual(expectedState.Cursor.Timetoken, ((ReceiveStoppedState)result.State).Cursor.Timetoken);
            ClassicAssert.IsInstanceOf<EmitStatusInvocation>(result.Invocations.ElementAt(0));
            ClassicAssert.AreEqual(PNStatusCategory.PNDisconnectedCategory, ((EmitStatusInvocation)result.Invocations.ElementAt(0)).StatusCategory);
        }

        [NUnit.Framework.Test]
        public void ReceivingState_OnReceiveFailureEvent_TransitionToReceiveReconnectingState()
        {
            //Arrange
            var currentState = CreateReceivingState();
            var eventToTriggerTransition = new ReceiveFailureEvent() { };
            var expectedState = new ReceiveReconnectingState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
            };

            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<ReceiveReconnectingState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((ReceiveReconnectingState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((ReceiveReconnectingState)result.State).ChannelGroups);
            ClassicAssert.AreEqual(expectedState.Cursor.Region, ((ReceiveReconnectingState)result.State).Cursor.Region);
            ClassicAssert.AreEqual(expectedState.Cursor.Timetoken, ((ReceiveReconnectingState)result.State).Cursor.Timetoken);
        }

        [NUnit.Framework.Test]
        public void ReceivingState_OnUnsubscribeAllEvent_TransitionToUnsubscribedState()
        {
            //Arrange
            var currentState = CreateReceivingState();
            var eventToTriggerTransition = new UnsubscribeAllEvent();

            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<UnsubscribedState>(result.State);
        }

    }
}
