using System.Globalization;
using ICT3101_Calculator;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class QualityMetricsStepDefinitions
{
    private String _result;
    private readonly GivenDefinition _givenDefinition;

    public QualityMetricsStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }

    [When(@"I enter (.*) and (.*) into the calculator and press DefectDensity")]
    public void WhenIEnteredIntoTheCalculatorAndPressDefectDensity(double p0, double p1)
    {
        _result = _givenDefinition.calculator.CalucateDefectDensity(p0, p1).ToString();
    }

    [When(@"I enter (.*), (.*) and (.*) into the calculator and press KSSI")]
    public void WhenIEnteredIntoTheCalculatorAndPressKssi(double p0, double p1, double p2)
    {
        _result = _givenDefinition.calculator.CalcuateKssi(p0, p1, p2).ToString();
    }

    [Then(@"the quality metrics result should be (.*)")]
    public void ThenTheQualityMetricsResultShouldBe(string p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}