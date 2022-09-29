using System.Globalization;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class BasicMusaStepDefinitions
{
    private String _result;
    private readonly GivenDefinition _givenDefinition;

    public BasicMusaStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }

    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press CurrentFailureIntensity")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressCurrentFailureIntensity(float initial, float average,
        float total)
    {
        _result = Math.Round(_givenDefinition.calculator.CalculateCurrentFailureIntensity(initial, average, total), 2)
            .ToString();
    }


    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press AverageExpectedFailure")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(float initial, float total, float time)
    {
        _result = Math.Round(_givenDefinition.calculator.CalculateAverageExpectedFailure(initial, total, time), 2)
            .ToString();
    }

    [Then(@"the basic musa result should be (.*)")]
    public void ThenTheBasicMusaResultShouldBe(string p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}