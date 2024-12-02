using NUnit.Framework.Legacy;
using PubnubApi.EventEngine.Core;
using PubnubApi.EventEngine.Presence.Common;
using PubnubApi.EventEngine.Presence.Events;
using PubnubApi.EventEngine.Presence.States;
using System.Linq;

namespace PubnubApi.Tests.EventEngine.Presence
{
    internal class InactiveStateTransitions
    {
        private static readonly object[] testCases = {
            new object[] {
                new InactiveState(),
                new JoinedEvent() { Input = new PresenceInput() { Channels = new [] { "a" } } },
                new HeartbeatingState() { Input = new PresenceInput() { Channels = new [] { "a" } } },
                null
            },
            new object[] {
                new InactiveState(),
                new LeftEvent() { Input = new PresenceInput() { Channels = new [] { "a" } } },
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new LeftAllEvent(),
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new HeartbeatSuccessEvent(),
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new HeartbeatFailureEvent() { Status = new PNStatus() },
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new ReconnectEvent(),
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new DisconnectEvent(),
                null,
                null
            },
            new object[] {
                new InactiveState(),
                new TimesUpEvent(),
                null,
                null
            },
        };

        [NUnit.Framework.TestCaseSource(nameof(testCases))]
        public void TestTransition(APresenceState @sut, IEvent @ev, APresenceState @expected, IEffectInvocation[] @_)
        {
            var result = @sut.Transition(@ev);

            if (result == null && expected == null)
            {
                // it's expected result
                return;
            }

            ClassicAssert.AreEqual(@expected, result.State);
        }

        [NUnit.Framework.TestCaseSource(nameof(testCases))]
        public void TestReturnedInvocations(State @sut, IEvent @ev, State @_, IEffectInvocation[] @expected)
        {
            var result = @sut.Transition(@ev);

            if (result == null && expected == null)
            {
                // it's expected result
                return;
            }

            foreach (var item in result.Invocations)
            {
                ClassicAssert.True(expected.Select(i => i.GetType()).Contains(item.GetType()));
            }
        }
    }
}
