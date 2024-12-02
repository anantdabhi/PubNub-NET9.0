using System;
using NUnit.Framework.Legacy;
using System.Threading;
using PubnubApi;
using System.Collections.Generic;
using MockServer;
using System.Diagnostics;
using NUnit.Framework.Legacy;
using NUnit.Framework;

namespace PubNubMessaging.Tests
{
    [NUnit.Framework.TestFixture]
    public class WhenUserIdInPNConfig : TestHarness
    {
        [NUnit.Framework.Test]
        public static void ThenUuidSetShouldFailWithUserIdConstructorValue()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                PNConfiguration config = new PNConfiguration(new UserId("newuserid"))
                {
                    SubscribeKey = "somesubkey",
                    PublishKey = "somepubkey",
                    SecretKey = "someseckey",
                    Uuid = "altnewuuidthatshouldfail"
                };
            });
        }

        [NUnit.Framework.Test]
        public static void ThenUserIdSetShouldFailWithUuidConstructorValue()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                PNConfiguration config = new PNConfiguration("newuuid")
                {
                    SubscribeKey = "somesubkey",
                    PublishKey = "somepubkey",
                    SecretKey = "someseckey",
                    UserId = new UserId("altnewuseridthatshouldfail")
                };
            });
        }

        [NUnit.Framework.Test]
        public static void ThenUserIdSetShouldGiveSameForUuid() 
        {
            PNConfiguration config = new PNConfiguration(new UserId("newuserid"))
            {
                SubscribeKey = "somesubkey",
                PublishKey = "somepubkey",
                SecretKey = "someseckey",
            };
            ClassicAssert.AreEqual(config.UserId.ToString(), config.Uuid);
        }

        [NUnit.Framework.Test]
        public static void ThenUuidSetShouldGiveSameForUserId()
        {
            PNConfiguration config = new PNConfiguration("newuuid")
            {
                SubscribeKey = "somesubkey",
                PublishKey = "somepubkey",
                SecretKey = "someseckey",
            };
            ClassicAssert.AreEqual(config.UserId.ToString(), config.Uuid);
        }

        [NUnit.Framework.Test]
        public static void ThenChangeUuidShouldGiveCurrentNewUuid()
        {
            ManualResetEvent mre = new ManualResetEvent(false);
            PNConfiguration config = new PNConfiguration("olduuid")
            {
                SubscribeKey = "demo",
                PublishKey = "demo",
                LogVerbosity = PNLogVerbosity.BODY,
                ReconnectionPolicy = PNReconnectionPolicy.LINEAR
            };
            
            Pubnub pubnub = new Pubnub(config);
            Thread.Sleep(1000);
            pubnub.ChangeUUID("newuuid");
            mre.WaitOne(1000);
            ClassicAssert.AreEqual("newuuid", pubnub.GetCurrentUserId().ToString());
        }

        [NUnit.Framework.Test]
        public static void ThenChangeUserIdShouldGiveCurrentNewUserId()
        {
            ManualResetEvent mre = new ManualResetEvent(false);
            PNConfiguration config = new PNConfiguration(new UserId("olduserid"))
            {
                SubscribeKey = "demo",
                PublishKey = "demo",
                LogVerbosity = PNLogVerbosity.BODY,
                ReconnectionPolicy = PNReconnectionPolicy.LINEAR
            };
            Pubnub pubnub = new Pubnub(config);
            Thread.Sleep(1000);
            pubnub.ChangeUserId(new UserId("newuserid"));
            mre.WaitOne(1000);
            ClassicAssert.AreEqual("newuserid", pubnub.GetCurrentUserId().ToString());
        }
    }
}
