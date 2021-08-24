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
namespace SeleniumMSFlow.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [Microsoft.VisualStudio.TestTools.UnitTesting.TestClassAttribute()]
    public partial class MobileTableGamesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = new string[] {
                "Mobile"};
        
#line 1 "MobileTableGames.feature"
#line hidden
        
        public virtual Microsoft.VisualStudio.TestTools.UnitTesting.TestContext TestContext
        {
            get
            {
                return this._testContext;
            }
            set
            {
                this._testContext = value;
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassInitializeAttribute()]
        public static void FeatureSetup(Microsoft.VisualStudio.TestTools.UnitTesting.TestContext testContext)
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "MobileTableGames", null, ProgrammingLanguage.CSharp, new string[] {
                        "Mobile"});
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.ClassCleanupAttribute()]
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute()]
        public virtual void TestInitialize()
        {
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MobileTableGames")))
            {
                global::SeleniumMSFlow.Features.MobileTableGamesFeature.FeatureSetup(null);
            }
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<Microsoft.VisualStudio.TestTools.UnitTesting.TestContext>(_testContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void CheckMobileTableGamesAsAnAuthorizedUser(string tableGame, string url, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Table Game", tableGame);
            argumentsOfScenario.Add("Url", url);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check mobile Table Games as an authorized user", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
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
#line 5
 testRunner.Given("I have opened Adjarabet.com home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.And("I log in using \'sqatmp2p\' and \'Paroli1#\' credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.And("I navigate to mobile \'Table Games\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.When(string.Format("I click \'{0}\' button", tableGame), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then("Table Game is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
 testRunner.And(string.Format("\'{0}\' is correct", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as an authorized user: Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=")]
        public virtual void CheckMobileTableGamesAsAnAuthorizedUser_Dominoes()
        {
#line 4
this.CheckMobileTableGamesAsAnAuthorizedUser("Dominoes", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as an authorized user: Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=")]
        public virtual void CheckMobileTableGamesAsAnAuthorizedUser_Bura()
        {
#line 4
this.CheckMobileTableGamesAsAnAuthorizedUser("Bura", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as an authorized user: Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?use" +
            "r=")]
        public virtual void CheckMobileTableGamesAsAnAuthorizedUser_Backgammon()
        {
#line 4
this.CheckMobileTableGamesAsAnAuthorizedUser("Backgammon", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?use" +
                    "r=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as an authorized user: Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=")]
        public virtual void CheckMobileTableGamesAsAnAuthorizedUser_Seka()
        {
#line 4
this.CheckMobileTableGamesAsAnAuthorizedUser("Seka", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckMobileTableGamesAsNotAuthorizedUser(string tableGame, string url, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Table Game", tableGame);
            argumentsOfScenario.Add("Url", url);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check mobile Table Games as not authorized user", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
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
#line 21
 testRunner.Given("I have opened Adjarabet.com home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 22
 testRunner.And("I navigate to mobile \'Table Games\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("I click \'{0}\' button", tableGame), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When("I log in using \'sqatmp2p\' and \'Paroli1#\' from opened login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.Then("Table Game is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.And(string.Format("\'{0}\' is correct", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as not authorized user: Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Dominoes")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=")]
        public virtual void CheckMobileTableGamesAsNotAuthorizedUser_Dominoes()
        {
#line 20
this.CheckMobileTableGamesAsNotAuthorizedUser("Dominoes", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/domino?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as not authorized user: Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Bura")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=")]
        public virtual void CheckMobileTableGamesAsNotAuthorizedUser_Bura()
        {
#line 20
this.CheckMobileTableGamesAsNotAuthorizedUser("Bura", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/bura?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as not authorized user: Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Backgammon")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?use" +
            "r=")]
        public virtual void CheckMobileTableGamesAsNotAuthorizedUser_Backgammon()
        {
#line 20
this.CheckMobileTableGamesAsNotAuthorizedUser("Backgammon", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/backgammon?use" +
                    "r=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Table Games as not authorized user: Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTableGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Table Game", "Seka")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=")]
        public virtual void CheckMobileTableGamesAsNotAuthorizedUser_Seka()
        {
#line 20
this.CheckMobileTableGamesAsNotAuthorizedUser("Seka", "https://p2p.adjarabet.com/?https://spgames.adjarabet.com/p2p/lobby/seka?user=", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
