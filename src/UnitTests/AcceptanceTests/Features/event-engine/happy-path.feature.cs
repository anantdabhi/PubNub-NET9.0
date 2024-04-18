﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace AcceptanceTests.Features.Event_Engine
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Event Engine")]
    [NUnit.Framework.CategoryAttribute("featureSet=eventEngine")]
    [NUnit.Framework.CategoryAttribute("beta")]
    public partial class EventEngineFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private static string[] featureTags = new string[] {
                "featureSet=eventEngine",
                "beta"};
        
#line 1 "happy-path.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/event-engine", "Event Engine", "  This is a description of the feature", ProgrammingLanguage.CSharp, featureTags);
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 5
  #line hidden
#line 6
    testRunner.Given("the demo keyset with event engine enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully receive messages")]
        [NUnit.Framework.CategoryAttribute("contract=simpleSubscribe")]
        public void SuccessfullyReceiveMessages()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=simpleSubscribe"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully receive messages", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 9
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 10
    testRunner.When("I subscribe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then("I receive the message in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table1.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_CHANGED"});
                table1.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table1.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_SUCCESS"});
                table1.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table1.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
                table1.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
                table1.AddRow(new string[] {
                            "event",
                            "RECEIVE_SUCCESS"});
                table1.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_MESSAGES"});
                table1.AddRow(new string[] {
                            "invocation",
                            "EMIT_MESSAGES"});
                table1.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
#line 12
    testRunner.And("I observe the following:", ((string)(null)), table1, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully restore subscribe")]
        [NUnit.Framework.CategoryAttribute("contract=restoringSubscribe")]
        public void SuccessfullyRestoreSubscribe()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=restoringSubscribe"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully restore subscribe", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 27
    testRunner.When("I subscribe with timetoken 12345678901234567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
    testRunner.Then("I receive the message in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table2.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_RESTORED"});
                table2.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table2.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_SUCCESS"});
                table2.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table2.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
                table2.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
                table2.AddRow(new string[] {
                            "event",
                            "RECEIVE_SUCCESS"});
                table2.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_MESSAGES"});
                table2.AddRow(new string[] {
                            "invocation",
                            "EMIT_MESSAGES"});
                table2.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
#line 29
    testRunner.And("I observe the following:", ((string)(null)), table2, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Successfully restore subscribe with failures")]
        [NUnit.Framework.CategoryAttribute("contract=restoringSubscribeWithFailures")]
        public void SuccessfullyRestoreSubscribeWithFailures()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=restoringSubscribeWithFailures"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Successfully restore subscribe with failures", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 43
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 44
    testRunner.Given("a linear reconnection policy with 3 retries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 45
    testRunner.When("I subscribe with timetoken 12345678901234567", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
    testRunner.Then("I receive the message in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table3.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_RESTORED"});
                table3.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table3.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_FAILURE"});
                table3.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table3.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table3.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_SUCCESS"});
                table3.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table3.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
                table3.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
                table3.AddRow(new string[] {
                            "event",
                            "RECEIVE_SUCCESS"});
                table3.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_MESSAGES"});
                table3.AddRow(new string[] {
                            "invocation",
                            "EMIT_MESSAGES"});
                table3.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
#line 47
    testRunner.And("I observe the following:", ((string)(null)), table3, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Complete handshake failure")]
        [NUnit.Framework.CategoryAttribute("contract=subscribeHandshakeFailure")]
        public void CompleteHandshakeFailure()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=subscribeHandshakeFailure"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Complete handshake failure", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 64
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 65
    testRunner.Given("a linear reconnection policy with 3 retries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 66
    testRunner.When("I subscribe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
    testRunner.Then("I receive an error in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table4.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_CHANGED"});
                table4.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table4.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_FAILURE"});
                table4.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table4.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_FAILURE"});
                table4.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_FAILURE"});
                table4.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_FAILURE"});
                table4.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_GIVEUP"});
                table4.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table4.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
#line 68
    testRunner.And("I observe the following:", ((string)(null)), table4, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Handshake failure recovery")]
        [NUnit.Framework.CategoryAttribute("contract=subscribeHandshakeRecovery")]
        public void HandshakeFailureRecovery()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=subscribeHandshakeRecovery"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Handshake failure recovery", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 89
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 90
    testRunner.Given("a linear reconnection policy with 3 retries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 91
    testRunner.When("I subscribe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
    testRunner.Then("I receive the message in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table5.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_CHANGED"});
                table5.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table5.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_FAILURE"});
                table5.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table5.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table5.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_FAILURE"});
                table5.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table5.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE_RECONNECT"});
                table5.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_RECONNECT_SUCCESS"});
                table5.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE_RECONNECT"});
                table5.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
                table5.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
                table5.AddRow(new string[] {
                            "event",
                            "RECEIVE_SUCCESS"});
                table5.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_MESSAGES"});
                table5.AddRow(new string[] {
                            "invocation",
                            "EMIT_MESSAGES"});
                table5.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
#line 93
    testRunner.And("I observe the following:", ((string)(null)), table5, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Receiving failure recovery")]
        [NUnit.Framework.CategoryAttribute("contract=subscribeReceivingRecovery")]
        public void ReceivingFailureRecovery()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=subscribeReceivingRecovery"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Receiving failure recovery", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 113
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((TagHelper.ContainsIgnoreTag(tagsOfScenario) || TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 5
  this.FeatureBackground();
#line hidden
#line 114
    testRunner.Given("a linear reconnection policy with 3 retries", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 115
    testRunner.When("I subscribe", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 116
    testRunner.Then("I receive the message in my subscribe response", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
                TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                            "type",
                            "name"});
                table6.AddRow(new string[] {
                            "event",
                            "SUBSCRIPTION_CHANGED"});
                table6.AddRow(new string[] {
                            "invocation",
                            "HANDSHAKE"});
                table6.AddRow(new string[] {
                            "event",
                            "HANDSHAKE_SUCCESS"});
                table6.AddRow(new string[] {
                            "invocation",
                            "CANCEL_HANDSHAKE"});
                table6.AddRow(new string[] {
                            "invocation",
                            "EMIT_STATUS"});
                table6.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
                table6.AddRow(new string[] {
                            "event",
                            "RECEIVE_FAILURE"});
                table6.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_MESSAGES"});
                table6.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_RECONNECT"});
                table6.AddRow(new string[] {
                            "event",
                            "RECEIVE_RECONNECT_SUCCESS"});
                table6.AddRow(new string[] {
                            "invocation",
                            "CANCEL_RECEIVE_RECONNECT"});
                table6.AddRow(new string[] {
                            "invocation",
                            "EMIT_MESSAGES"});
                table6.AddRow(new string[] {
                            "invocation",
                            "RECEIVE_MESSAGES"});
#line 117
    testRunner.And("I observe the following:", ((string)(null)), table6, "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
