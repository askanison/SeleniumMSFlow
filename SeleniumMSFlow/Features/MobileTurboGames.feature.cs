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
    public partial class MobileTurboGamesFeature
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
        private Microsoft.VisualStudio.TestTools.UnitTesting.TestContext _testContext;
        
        private string[] _featureTags = new string[] {
                "Mobile"};
        
#line 1 "MobileTurboGames.feature"
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
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "MobileTurboGames", null, ProgrammingLanguage.CSharp, new string[] {
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
                        && (testRunner.FeatureContext.FeatureInfo.Title != "MobileTurboGames")))
            {
                global::SeleniumMSFlow.Features.MobileTurboGamesFeature.FeatureSetup(null);
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
        
        public virtual void CheckMobileTurboGamesAsALoggedInUser(string turboGame, string url, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Turbo Game", turboGame);
            argumentsOfScenario.Add("Url", url);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check mobile Turbo Games as a logged in user", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.And("I log in using \'sqatmturbo\' and \'Paroli1#\' credentials", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 7
 testRunner.And("I navigate to mobile \'Turbo Games\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 8
 testRunner.When(string.Format("I click \'{0}\' button", turboGame), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then("Turbo Game is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
 testRunner.And(string.Format("\'{0}\' is correct", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/plinko?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_Plinko()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("Plinko", "https://spgames.adjarabet.com/turbo/play/plinko?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/mines?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_Mines()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("Mines", "https://spgames.adjarabet.com/turbo/play/mines?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/goal?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_Goal()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("Goal", "https://spgames.adjarabet.com/turbo/play/goal?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/hi-lo?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_HiLo()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("HiLo", "https://spgames.adjarabet.com/turbo/play/hi-lo?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/dice?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_Dice()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("Dice", "https://spgames.adjarabet.com/turbo/play/dice?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a logged in user: Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/mini-roulette?user=")]
        public virtual void CheckMobileTurboGamesAsALoggedInUser_MiniRoulette()
        {
#line 4
this.CheckMobileTurboGamesAsALoggedInUser("Mini Roulette", "https://spgames.adjarabet.com/turbo/play/mini-roulette?user=", ((string[])(null)));
#line hidden
        }
        
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser(string turboGame, string url, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Turbo Game", turboGame);
            argumentsOfScenario.Add("Url", url);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Check mobile Turbo Games as a not logged in user", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 21
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
#line 22
 testRunner.Given("I have opened Adjarabet.com home page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 23
 testRunner.And("I navigate to mobile \'Turbo Games\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("I click \'{0}\' button", turboGame), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.When("I log in using \'sqatmturbo\' and \'Paroli1#\' from opened login form", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then("Turbo Game is launched", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.And(string.Format("\'{0}\' is correct", url), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Plinko")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/plinko?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_Plinko()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("Plinko", "https://spgames.adjarabet.com/turbo/play/plinko?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Mines")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/mines?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_Mines()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("Mines", "https://spgames.adjarabet.com/turbo/play/mines?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Goal")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/goal?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_Goal()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("Goal", "https://spgames.adjarabet.com/turbo/play/goal?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "HiLo")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/hi-lo?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_HiLo()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("HiLo", "https://spgames.adjarabet.com/turbo/play/hi-lo?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Dice")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/dice?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_Dice()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("Dice", "https://spgames.adjarabet.com/turbo/play/dice?user=", ((string[])(null)));
#line hidden
        }
        
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestMethodAttribute()]
        [Microsoft.VisualStudio.TestTools.UnitTesting.DescriptionAttribute("Check mobile Turbo Games as a not logged in user: Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("FeatureTitle", "MobileTurboGames")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute("Mobile")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("VariantName", "Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Turbo Game", "Mini Roulette")]
        [Microsoft.VisualStudio.TestTools.UnitTesting.TestPropertyAttribute("Parameter:Url", "https://spgames.adjarabet.com/turbo/play/mini-roulette?user=")]
        public virtual void CheckMobileTurboGamesAsANotLoggedInUser_MiniRoulette()
        {
#line 21
this.CheckMobileTurboGamesAsANotLoggedInUser("Mini Roulette", "https://spgames.adjarabet.com/turbo/play/mini-roulette?user=", ((string[])(null)));
#line hidden
        }
    }
}
#pragma warning restore
#endregion
