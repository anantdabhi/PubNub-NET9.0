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
namespace AcceptanceTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Grant an access token")]
    [NUnit.Framework.CategoryAttribute("featureSet=access")]
    public partial class GrantAnAccessTokenFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = new string[] {
                "featureSet=access"};
        
#line 1 "grant-token.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "Grant an access token", "  As a PubNub customer I want to restrict and allow access to\r\n  specific PubNub " +
                    "resources (channels, channel groups, uuids)\r\n  by my user base (both people and " +
                    "devices) which are each\r\n  identified by a unique UUID.", ProgrammingLanguage.CSharp, new string[] {
                        "featureSet=access"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void FeatureBackground()
        {
#line 8
  #line hidden
#line 9
    testRunner.Given("I have a keyset with access manager enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Grant an access token with all permissions on all resource types with authorized " +
            "uuid")]
        [NUnit.Framework.CategoryAttribute("contract=grantAllPermissions")]
        public virtual void GrantAnAccessTokenWithAllPermissionsOnAllResourceTypesWithAuthorizedUuid()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantAllPermissions"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Grant an access token with all permissions on all resource types with authorized " +
                    "uuid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 12
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 14
    testRunner.Given("the authorized UUID \"test-authorized-uuid\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 15
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 16
    testRunner.Given("the \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 17
    testRunner.And("grant resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 18
    testRunner.And("grant resource permission WRITE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 19
    testRunner.And("grant resource permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 20
    testRunner.And("grant resource permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 21
    testRunner.And("grant resource permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 22
    testRunner.And("grant resource permission JOIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 23
    testRunner.And("grant resource permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 24
    testRunner.Given("the \'channel_group-1\' CHANNEL_GROUP resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 25
    testRunner.And("grant resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 26
    testRunner.And("grant resource permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 27
    testRunner.Given("the \'uuid-1\' UUID resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 28
    testRunner.And("grant resource permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 29
    testRunner.And("grant resource permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 30
    testRunner.And("grant resource permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 31
    testRunner.Given("the \'^channel-\\S*$\' CHANNEL pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 32
    testRunner.And("grant pattern permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 33
    testRunner.And("grant pattern permission WRITE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 34
    testRunner.And("grant pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 35
    testRunner.And("grant pattern permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 36
    testRunner.And("grant pattern permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 37
    testRunner.And("grant pattern permission JOIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 38
    testRunner.And("grant pattern permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 39
    testRunner.Given("the \'^:channel_group-\\S*$\' CHANNEL_GROUP pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 40
    testRunner.And("grant pattern permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 41
    testRunner.And("grant pattern permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 42
    testRunner.Given("the \'^uuid-\\S*$\' UUID pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 43
    testRunner.And("grant pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 44
    testRunner.And("grant pattern permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 45
    testRunner.And("grant pattern permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 46
    testRunner.When("I grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
    testRunner.Then("the token contains the authorized UUID \"test-authorized-uuid\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
    testRunner.Then("the token contains the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
    testRunner.Then("the token has \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
    testRunner.And("token resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 51
    testRunner.And("token resource permission WRITE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 52
    testRunner.And("token resource permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 53
    testRunner.And("token resource permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 54
    testRunner.And("token resource permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 55
    testRunner.And("token resource permission JOIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 56
    testRunner.And("token resource permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 57
    testRunner.Then("the token has \'channel_group-1\' CHANNEL_GROUP resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
    testRunner.And("token resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 59
    testRunner.And("token resource permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 60
    testRunner.Then("the token has \'uuid-1\' UUID resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
    testRunner.And("token resource permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 62
    testRunner.And("token resource permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 63
    testRunner.And("token resource permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 64
    testRunner.Then("the token has \'^channel-\\S*$\' CHANNEL pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
    testRunner.And("token pattern permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 66
    testRunner.And("token pattern permission WRITE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 67
    testRunner.And("token pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 68
    testRunner.And("token pattern permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 69
    testRunner.And("token pattern permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 70
    testRunner.And("token pattern permission JOIN", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 71
    testRunner.And("token pattern permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 72
    testRunner.Then("the token has \'^:channel_group-\\S*$\' CHANNEL_GROUP pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
    testRunner.And("token pattern permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 74
    testRunner.And("token pattern permission MANAGE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 75
    testRunner.Then("the token has \'^uuid-\\S*$\' UUID pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 76
    testRunner.And("token pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 77
    testRunner.And("token pattern permission UPDATE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 78
    testRunner.And("token pattern permission DELETE", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Grant an access token without an authorized uuid")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithoutAuthorizedUUID")]
        public virtual void GrantAnAccessTokenWithoutAnAuthorizedUuid()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithoutAuthorizedUUID"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Grant an access token without an authorized uuid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 81
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 82
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 83
    testRunner.Given("the \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 84
    testRunner.And("grant resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 85
    testRunner.When("I grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 86
    testRunner.Then("the token contains the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
    testRunner.Then("the token does not contain an authorized uuid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
    testRunner.Then("the token has \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
    testRunner.And("token resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Grant an access token successfully with an authorized uuid")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithAuthorizedUUID")]
        public virtual void GrantAnAccessTokenSuccessfullyWithAnAuthorizedUuid()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithAuthorizedUUID"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Grant an access token successfully with an authorized uuid", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 92
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 93
    testRunner.Given("the authorized UUID \"test-authorized-uuid\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 94
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 95
    testRunner.Given("the \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 96
    testRunner.And("grant resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 97
    testRunner.When("I grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
    testRunner.Then("the token contains the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
    testRunner.Then("the token contains the authorized UUID \"test-authorized-uuid\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
    testRunner.Then("the token has \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
    testRunner.And("token resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attempt to grant an access token with all permissions empty or false and expect a" +
            " server error")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithoutAnyPermissionsError")]
        public virtual void AttemptToGrantAnAccessTokenWithAllPermissionsEmptyOrFalseAndExpectAServerError()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithoutAnyPermissionsError"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attempt to grant an access token with all permissions empty or false and expect a" +
                    " server error", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 104
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 105
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 106
    testRunner.Given("the \'uuid-1\' UUID resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 107
    testRunner.And("deny resource permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 108
    testRunner.When("I attempt to grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
    testRunner.Then("an error is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
    testRunner.And("the error status code is 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 111
    testRunner.And("the error message is \'Invalid permissions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 112
    testRunner.And("the error source is \'grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 113
    testRunner.And("the error detail message is \'Unexpected value: `permissions.resources.uuids.uuid-" +
                        "1` must be positive and non-zero.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 114
    testRunner.And("the error detail location is \'permissions.resources.uuids.uuid-1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 115
    testRunner.And("the error detail location type is \'body\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attempt to grant an access token with a regular expression containing a syntax er" +
            "ror and expect a server error")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithRegExpSyntaxError")]
        public virtual void AttemptToGrantAnAccessTokenWithARegularExpressionContainingASyntaxErrorAndExpectAServerError()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithRegExpSyntaxError"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attempt to grant an access token with a regular expression containing a syntax er" +
                    "ror and expect a server error", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 118
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 119
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 120
    testRunner.Given("the \'!<[^>]+>++\' UUID pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 121
    testRunner.And("grant pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 122
    testRunner.When("I attempt to grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 123
    testRunner.Then("an error is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 124
    testRunner.And("the error status code is 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 125
    testRunner.And("the error message is \'Invalid RegExp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 126
    testRunner.And("the error source is \'grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 127
    testRunner.And("the error detail message is \'Syntax error: multiple repeat.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 128
    testRunner.And("the error detail location is \'permissions.patterns.uuids.!<[^>]+>++\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 129
    testRunner.And("the error detail location type is \'body\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attempt to grant an access token with a regular expression containing capturing g" +
            "roups and expect a server error")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithRegExpNonCapturingError")]
        public virtual void AttemptToGrantAnAccessTokenWithARegularExpressionContainingCapturingGroupsAndExpectAServerError()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithRegExpNonCapturingError"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attempt to grant an access token with a regular expression containing capturing g" +
                    "roups and expect a server error", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 132
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 133
    testRunner.Given("the TTL 60", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 134
    testRunner.Given("the \'(!<[^>]+>)+\' UUID pattern access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 135
    testRunner.And("grant pattern permission GET", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 136
    testRunner.When("I attempt to grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
    testRunner.Then("an error is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
    testRunner.And("the error status code is 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 139
    testRunner.And("the error message is \'Invalid RegExp\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 140
    testRunner.And("the error source is \'grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 141
    testRunner.And("the error detail message is \'Only non-capturing groups are allowed. Try replacing" +
                        " `(` with `(?:`.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 142
    testRunner.And("the error detail location is \'permissions.patterns.uuids.(!<[^>]+>)+\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 143
    testRunner.And("the error detail location type is \'body\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Attempt to grant an access token when ttl provided exceeds the max ttl configured" +
            " (use default max 43200 for the test)")]
        [NUnit.Framework.CategoryAttribute("contract=grantWithTTLExceedMaxTTL")]
        [NUnit.Framework.CategoryAttribute("beta")]
        public virtual void AttemptToGrantAnAccessTokenWhenTtlProvidedExceedsTheMaxTtlConfiguredUseDefaultMax43200ForTheTest()
        {
            string[] tagsOfScenario = new string[] {
                    "contract=grantWithTTLExceedMaxTTL",
                    "beta"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Attempt to grant an access token when ttl provided exceeds the max ttl configured" +
                    " (use default max 43200 for the test)", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 146
  this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
  this.FeatureBackground();
#line hidden
#line 147
    testRunner.Given("the TTL 43201", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 148
    testRunner.Given("the \'channel-1\' CHANNEL resource access permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 149
    testRunner.And("grant resource permission READ", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 150
    testRunner.When("I attempt to grant a token specifying those permissions", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 151
    testRunner.Then("an error is returned", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 152
    testRunner.And("the error status code is 400", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 153
    testRunner.And("the error message is \'Invalid ttl\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 154
    testRunner.And("the error source is \'grant\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 155
    testRunner.And("the error detail message is \'Range should be 1 to 43200 minute(s).\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 156
    testRunner.And("the error detail location is \'ttl\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
#line 157
    testRunner.And("the error detail location type is \'body\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "* ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion