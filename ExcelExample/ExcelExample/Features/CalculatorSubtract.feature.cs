﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (http://www.specflow.org/).
//      SpecFlow Version:2.3.2.0
//      SpecFlow Generator Version:2.3.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace ExcelExample.Features
{
    using TechTalk.SpecFlow;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "2.3.2.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [TechTalk.SpecRun.FeatureAttribute("Calculator Subtract Feature", Description="\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the diffe" +
        "rence of two numbers", SourceFile="Features\\CalculatorSubtract.feature", SourceLine=0)]
    public partial class CalculatorSubtractFeatureFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
#line 1 "CalculatorSubtract.feature"
#line hidden
        
        [TechTalk.SpecRun.FeatureInitialize()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Calculator Subtract Feature", "\tIn order to avoid silly mistakes\r\n\tAs a math idiot\r\n\tI want to be told the diffe" +
                    "rence of two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [TechTalk.SpecRun.FeatureCleanup()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        public virtual void TestInitialize()
        {
        }
        
        [TechTalk.SpecRun.ScenarioCleanup()]
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
        
        public virtual void SubtractTwoNumbers(string number1, string number2, string result, string[] exampleTags)
        {
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Subtract two numbers", exampleTags);
#line 6
this.ScenarioSetup(scenarioInfo);
#line 7
 testRunner.Given(string.Format("I have entered {0} into the calculator", number1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line 8
 testRunner.And(string.Format("I have also entered {0} into the calculator", number2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line 9
 testRunner.When("I press substract", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line 10
 testRunner.Then(string.Format("The result should be {0} on the screen", result), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            this.ScenarioCleanup();
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtract two numbers, 70", new string[] {
                "source:SubtractTwoNumbers.examples.xlsx"}, SourceLine=0)]
        public virtual void SubtractTwoNumbers_70()
        {
#line 6
this.SubtractTwoNumbers("70", "50", "20", new string[] {
                        "source:SubtractTwoNumbers.examples.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtract two numbers, 1", new string[] {
                "source:SubtractTwoNumbers.examples.xlsx"}, SourceLine=0)]
        public virtual void SubtractTwoNumbers_1()
        {
#line 6
this.SubtractTwoNumbers("1", "2", "-1", new string[] {
                        "source:SubtractTwoNumbers.examples.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtract two numbers, -10", new string[] {
                "source:SubtractTwoNumbers.examples.xlsx"}, SourceLine=0)]
        public virtual void SubtractTwoNumbers_10()
        {
#line 6
this.SubtractTwoNumbers("-10", "10", "-20", new string[] {
                        "source:SubtractTwoNumbers.examples.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.ScenarioAttribute("Subtract two numbers, 42", new string[] {
                "source:SubtractTwoNumbers.examples.xlsx"}, SourceLine=0)]
        public virtual void SubtractTwoNumbers_42()
        {
#line 6
this.SubtractTwoNumbers("42", "13", "29", new string[] {
                        "source:SubtractTwoNumbers.examples.xlsx"});
#line hidden
        }
        
        [TechTalk.SpecRun.TestRunCleanup()]
        public virtual void TestRunCleanup()
        {
            TechTalk.SpecFlow.TestRunnerManager.GetTestRunner().OnTestRunEnd();
        }
    }
}
#pragma warning restore
#endregion
