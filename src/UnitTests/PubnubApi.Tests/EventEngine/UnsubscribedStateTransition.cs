using NUnit.Framework.Legacy;
using NUnit.Framework.Legacy;
using PubnubApi.EventEngine.Core;
using PubnubApi.EventEngine.Subscribe.Common;
using PubnubApi.EventEngine.Subscribe.Events;
using PubnubApi.EventEngine.Subscribe.States;
using System.Linq;

namespace PubnubApi.Tests.EventEngine
{
    internal class UnsubscribedStateTransition
    {
        [NUnit.Framework.Test]
        public void UnsubscribedState_OnSubscriptionChangedEvent_TransitionToHandshakingState()
        {
            //Arrange
            var currentState = new UnsubscribedState() { Channels = new string[] { "ch1", "ch2" } };   
            var eventToTriggerTransition = new SubscriptionChangedEvent()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" }
            };
            var expectedState = new HandshakingState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
            };

            //Act
            var result = currentState.Transition(eventToTriggerTransition);
            
            //Assert
            ClassicAssert.IsInstanceOf<HandshakingState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((HandshakingState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((HandshakingState)result.State).ChannelGroups);
        }
        
        [NUnit.Framework.Test]
        public void UnsubscribedState_OnSubscriptionRestoreEvent_TransitionToHandhsakingState()
        {
            //Arrange
            var currentState = new UnsubscribedState() { Channels = new string[] { "ch1", "ch2" }, ChannelGroups = new string[] { "cg1", "cg2" } };
            var eventToTriggerTransition = new SubscriptionRestoredEvent()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 }
            };
            var expectedState = new HandshakingState()
            {
                Channels = new string[] { "ch1", "ch2" },
                ChannelGroups = new string[] { "cg1", "cg2" },
                Cursor = new SubscriptionCursor() { Region = 1, Timetoken = 1234567890 },
            };
            
            //Act
            var result = currentState.Transition(eventToTriggerTransition);

            //Assert
            ClassicAssert.IsInstanceOf<HandshakingState>(result.State);
            CollectionAssert.AreEqual(expectedState.Channels, ((HandshakingState)result.State).Channels);
            CollectionAssert.AreEqual(expectedState.ChannelGroups, ((HandshakingState)result.State).ChannelGroups);
            ClassicAssert.AreEqual(expectedState.Cursor.Region, ((HandshakingState)result.State).Cursor.Region);
            ClassicAssert.AreEqual(expectedState.Cursor.Timetoken, ((HandshakingState)result.State).Cursor.Timetoken);
        }
    }
}
