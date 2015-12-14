﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:1.9.0.77
//      SpecFlow Generator Version:1.9.0.0
//      Runtime Version:4.0.30319.42000
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Sitecore.Feature.Accounts.Specflow
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public partial class PageAfterLoginFeature : Xunit.IUseFixture<PageAfterLoginFeature.FixtureData>, System.IDisposable
    {
        
        private static TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "Page after login.feature"
#line hidden
        
        public PageAfterLoginFeature()
        {
            this.TestInitialize();
        }
        
        public static void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Page after login", "", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        public static void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        public virtual void ScenarioTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioSetup(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioStart(scenarioInfo);
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        public virtual void SetFixture(PageAfterLoginFeature.FixtureData fixtureData)
        {
        }
        
        void System.IDisposable.Dispose()
        {
            this.ScenarioTearDown();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC1_Define custom page")]
        public virtual void Accounts_PageAfterLogin_UC1_DefineCustomPage()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC1_Define custom page", new string[] {
                        "NeedImplementation"});
#line 5
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table1 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table1.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 6
 testRunner.Given("User is registered in Habitat", ((string)(null)), table1, "Given ");
#line hidden
            TechTalk.SpecFlow.Table table2 = new TechTalk.SpecFlow.Table(new string[] {
                        "ItemPath",
                        "Field",
                        "Value"});
            table2.AddRow(new string[] {
                        "/Sitecore/Content/Habitat",
                        "AfterLoginPage",
                        "/sitecore/content/Habitat/Home/Contact Us"});
#line 9
 testRunner.And("Value set to item field", ((string)(null)), table2, "And ");
#line 12
 testRunner.When("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            TechTalk.SpecFlow.Table table3 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table3.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 13
 testRunner.And("Actor enteres following data into fields", ((string)(null)), table3, "And ");
#line 16
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 17
 testRunner.Then("Page URL ends on /Contact-Us", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 18
 testRunner.And("Contact-Us title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC2_Define custom page_defined page does not exists")]
        public virtual void Accounts_PageAfterLogin_UC2_DefineCustomPage_DefinedPageDoesNotExists()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC2_Define custom page_defined page does not exists", new string[] {
                        "NeedImplementation"});
#line 23
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table4 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table4.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 24
 testRunner.Given("User is registered in Habitat", ((string)(null)), table4, "Given ");
#line 27
 testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 28
 testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 29
 testRunner.When("User inputs </sitecore/content/Habitat/Home/KOV> page in to the AfterLoginPage: f" +
                    "ield", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 30
 testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 31
 testRunner.And("User clicks Save button on Message dialog popup", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 32
 testRunner.And("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table5 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table5.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 33
 testRunner.And("Actor enteres following data into fields", ((string)(null)), table5, "And ");
#line 36
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 37
 testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC3_Define custom page_empty value")]
        public virtual void Accounts_PageAfterLogin_UC3_DefineCustomPage_EmptyValue()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC3_Define custom page_empty value", new string[] {
                        "NeedImplementation"});
#line 41
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table6 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table6.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 42
 testRunner.Given("User is registered in Habitat", ((string)(null)), table6, "Given ");
#line 45
 testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 46
 testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 47
 testRunner.When("User inputs <empty> page in to the AfterLoginPage: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 48
 testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 49
 testRunner.And("Actor opens Habitat website on Login page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table7 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table7.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 50
 testRunner.And("Actor enteres following data into fields", ((string)(null)), table7, "And ");
#line 53
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 54
 testRunner.Then("Page URL ends on /en", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC4_After login page for new registered user")]
        public virtual void Accounts_PageAfterLogin_UC4_AfterLoginPageForNewRegisteredUser()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC4_After login page for new registered user", new string[] {
                        "NeedImplementation"});
#line 58
this.ScenarioSetup(scenarioInfo);
#line 59
 testRunner.Given("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 60
 testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 61
 testRunner.When("User inputs </sitecore/content/Habitat/Home/Contact Us> page in to the AfterLogin" +
                    "Page: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 62
 testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 63
 testRunner.And("User opens Habitat website on Register page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table8 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "ConfirmPassword"});
            table8.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 64
 testRunner.When("Actor enters following data in to the register fields", ((string)(null)), table8, "When ");
#line 67
 testRunner.And("Actor clicks Register button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 68
 testRunner.Then("Page URL ends on /Contact-Us", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line 69
 testRunner.And("Contact-Us title presents on page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [Xunit.FactAttribute()]
        [Xunit.TraitAttribute("FeatureTitle", "Page after login")]
        [Xunit.TraitAttribute("Description", "Accounts_Page after login_UC5_After login behavior for login pop up")]
        public virtual void Accounts_PageAfterLogin_UC5_AfterLoginBehaviorForLoginPopUp()
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Accounts_Page after login_UC5_After login behavior for login pop up", new string[] {
                        "NeedImplementation"});
#line 73
this.ScenarioSetup(scenarioInfo);
#line hidden
            TechTalk.SpecFlow.Table table9 = new TechTalk.SpecFlow.Table(new string[] {
                        "Email",
                        "Password",
                        "Confirm password"});
            table9.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k",
                        "k"});
#line 74
 testRunner.Given("User is registered in Habitat", ((string)(null)), table9, "Given ");
#line 77
 testRunner.And("Content Editor is opened by Admin", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 78
 testRunner.And("Sitecore/Content/Habitat item is selected", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 79
 testRunner.When("User inputs </sitecore/content/Habitat/Home/Contact Us> page in to the AfterLogin" +
                    "Page: field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 80
 testRunner.And("User presses Save button on the Content Editor ribbon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 81
 testRunner.And("Actor opens Habitat website on Main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 82
 testRunner.And("Actor moves cursor over User icon", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 83
 testRunner.And("Actor clicks Login from drop-down menu", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            TechTalk.SpecFlow.Table table10 = new TechTalk.SpecFlow.Table(new string[] {
                        "E-mail",
                        "Password"});
            table10.AddRow(new string[] {
                        "kov@sitecore.net",
                        "k"});
#line 84
 testRunner.And("Actor enteres following data into fields", ((string)(null)), table10, "And ");
#line 87
 testRunner.And("Actor clicks Login button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 88
 testRunner.Then("User remains on the Main page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "1.9.0.77")]
        [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
        public class FixtureData : System.IDisposable
        {
            
            public FixtureData()
            {
                PageAfterLoginFeature.FeatureSetup();
            }
            
            void System.IDisposable.Dispose()
            {
                PageAfterLoginFeature.FeatureTearDown();
            }
        }
    }
}
#pragma warning restore
#endregion
