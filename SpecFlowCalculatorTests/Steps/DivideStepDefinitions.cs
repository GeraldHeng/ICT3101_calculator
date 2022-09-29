using System.Globalization;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class DivideStepDefinitions
{
    private String _result;
    private readonly GivenDefinition _givenDefinition;

    public DivideStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }

    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressDivide(int p0, int p1)
    {
        _result =  _givenDefinition.calculator.Divide(p0, p1).ToString(CultureInfo.InvariantCulture);
    }

    [Then(@"the division result should be (.*)")]
    public void ThenTheDivisionResultShouldBe(string p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}