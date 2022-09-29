using System.Globalization;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class AvailabilityStepDefinitions
{
    private String _result;
    private readonly GivenDefinition _givenDefinition;

    public AvailabilityStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressMtbf(float mttf, float mttr)
    {
        _result = _givenDefinition.calculator.Add(mttf, mttr).ToString(CultureInfo.InvariantCulture);
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndPressAvailability(float mttf, float mtbf)
    {
        _result = Math.Round(_givenDefinition.calculator.Divide(mttf,mtbf), 2).ToString(CultureInfo.InvariantCulture);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheDivisionResultShouldBe(string result)
    {
        Assert.That(_result, Is.EqualTo(result));
    }
}