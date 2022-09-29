using ICT3101_Calculator;
using NUnit.Framework;
using SpecFlowCalculatorTests.Steps;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorStepDefinitions
    {
        private double _result;
        private readonly GivenDefinition _givenDefinition;

        public UsingCalculatorStepDefinitions(GivenDefinition givenDefinition)
        {
            _givenDefinition = givenDefinition;
        }


        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _result = _givenDefinition.calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_result, Is.EqualTo(p0));
        }
    }
}