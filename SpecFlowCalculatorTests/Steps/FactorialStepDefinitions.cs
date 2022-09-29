using System.Globalization;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class FactorialStepDefinitions
{
    private String _result;
    private readonly GivenDefinition _givenDefinition;

    public FactorialStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }
    
    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressFactorial(int p0)
    {
        _result = _givenDefinition.calculator.Factorial(p0).ToString(CultureInfo.InvariantCulture);
    }

    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBe(string p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}