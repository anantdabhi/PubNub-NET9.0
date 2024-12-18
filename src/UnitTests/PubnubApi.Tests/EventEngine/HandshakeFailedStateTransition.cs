﻿using NUnit.Framework;
using NUnit.Framework.Legacy;
using NUnit.Framework.Legacy;
using PubnubApi.EventEngine.Core;
using PubnubApi.EventEngine.Subscribe.Common;
using PubnubApi.EventEngine.Subscribe.Events;
using PubnubApi.EventEngine.Subscribe.States;

namespace PubnubApi.Tests.EventEngine
{
    internal class HandshakeFailedStateTransition
    {
        private static object[] handshakeFailedEventCases = {
            new object[] {
                new HandshakeFailedState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new SubscriptionChangedEvent()
                {
                    Channels = new string[] { "ch1", "ch2", "ch3" },
                    ChannelGroups = new string[] { "cg1", "cg2", "cg3" }
                },
                new HandshakingState(){ Channels = new string[] { "ch1", "ch2", "ch3" }, ChannelGroups = new string[] { "cg1", "cg2", "cg3" } }
            },
            new object[]
            {
                new HandshakeFailedState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new SubscriptionRestoredEvent()
                {
                    Channels = new string[] { "ch1", "ch2" },
                    ChannelGroups = new string[] { "cg1", "cg2" }
                },
                new HandshakingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } }
            },
            new object[]
            {
                new HandshakeFailedState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } },
                new ReconnectEvent()
                {
                    Channels = new string[] { "ch1", "ch2" },
                    ChannelGroups = new string[] { "cg1", "cg2" },
                    Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 }
                },
                new HandshakingState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } }
            }
        };

        [TestCaseSource(nameof(handshakeFailedEventCases))]
        public void HandshakeFailedState_OnEvent_TransitionsToHandshakingState(
            HandshakeFailedState handshakeFailedState, IEvent @event, HandshakingState expectedState)
        {
            //Act
            var result = handshakeFailedState.Transition(@event);
            
            //Assert
            ClassicAssert.IsInstanceOf<HandshakingState>(result.State);
            ClassicAssert.AreEqual(expectedState.Channels, ((HandshakingState)result.State).Channels);
            ClassicAssert.AreEqual(expectedState.ChannelGroups, ((HandshakingState)result.State).ChannelGroups);
            if (@event is ReconnectEvent reconnectEvent)
            {
                ClassicAssert.AreEqual(reconnectEvent.Cursor, ((HandshakingState)result.State).Cursor);
            }
        }

        [TestCase]
        public void HandshakeFailedState_OnUnsubscribeAllEvent_TransitionToUnsubscribedState()
        {
            // Arrange
            var handshakeFailedState = new HandshakeFailedState()
            {
                Channels = new string[] { "ch1", "ch2" }, 
                ChannelGroups = new string[] { "cg1", "cg2" }
            };

            var @event = new UnsubscribeAllEvent() { };

            //Act
            var result = handshakeFailedState.Transition(@event);

            //Assert
            ClassicAssert.IsInstanceOf<UnsubscribedState>(result.State);
        }
        
    }
}
