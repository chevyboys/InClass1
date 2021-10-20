using FluentAssertions;
using System;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.Specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        /*private readonly Calculator _calculator = new Calculator();
        private int _result;
        private float _FResult;
        private string testThrownError;*/

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            _scenarioContext.Add("_calculator", new Calculator());
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _scenarioContext["_calculator"].As<Calculator>().FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _scenarioContext["_calculator"].As<Calculator>().SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _scenarioContext["_calculator"].As<Calculator>().result = _scenarioContext["_calculator"].As<Calculator>().Add();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            _scenarioContext["_calculator"].As<Calculator>().result.Should().Be(result);
        }

        [When("the two numbers are subtracted")]
        public void theTwoNumbersAreSubtracted()
        {
            _scenarioContext["_calculator"].As<Calculator>().result = _scenarioContext["_calculator"].As<Calculator>().Subtract();
        }


        [When(@"the two numbers are multiplied")]
        public void WhenTheTwoNumbersAreMultiplied()
        {
            _scenarioContext["_calculator"].As<Calculator>().result = _scenarioContext["_calculator"].As<Calculator>().Multiply();
        }

        [When(@"operation add is done to the number (.*)")]
        public void WhenOperationAddIsDoneToTheNumber(int p0)
        {
            _scenarioContext["_calculator"].As<Calculator>().SecondNumber = p0;
            _scenarioContext["_calculator"].As<Calculator>().result = _scenarioContext["_calculator"].As<Calculator>().Add();
            _scenarioContext["_calculator"].As<Calculator>().FirstNumber = _scenarioContext["_calculator"].As<Calculator>().result;

        }

        [When(@"operation divide is done to the number (.*)")]
        public void WhenOperationDivideIsDoneToTheNumber(int p0)
        {
            _scenarioContext["_calculator"].As<Calculator>().SecondNumber = p0;
            _scenarioContext["_calculator"].As<Calculator>().result = (int) _scenarioContext["_calculator"].As<Calculator>().Divide();
            _scenarioContext["_calculator"].As<Calculator>().FirstNumber = _scenarioContext["_calculator"].As<Calculator>().result;
        }

        [When(@"operation subtract is done to the number (.*)")]
        public void WhenOperationSubtractIsDoneToTheNumber(int p0)
        {
            _scenarioContext["_calculator"].As<Calculator>().SecondNumber = p0;
            _scenarioContext["_calculator"].As<Calculator>().result = (int)_scenarioContext["_calculator"].As<Calculator>().Subtract();
            _scenarioContext["_calculator"].As<Calculator>().FirstNumber = _scenarioContext["_calculator"].As<Calculator>().result;
        }

        [When(@"operation Remainder is done to the number (.*)")]
        public void WhenOperationRemainderIsDoneToTheNumber(int p0)
        {
            _scenarioContext["_calculator"].As<Calculator>().SecondNumber = p0;
            _scenarioContext["_calculator"].As<Calculator>().result = (int)_scenarioContext["_calculator"].As<Calculator>().Remainder();
            _scenarioContext["_calculator"].As<Calculator>().FirstNumber = _scenarioContext["_calculator"].As<Calculator>().result;
        }

    }
}