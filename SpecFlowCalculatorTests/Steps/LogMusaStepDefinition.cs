using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ICT3101_Calculator;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.Steps;

[Binding]
public sealed class LogMusaStepDefinitions
{
    private string _result;
    private readonly GivenDefinition _givenDefinition;

    public LogMusaStepDefinitions(GivenDefinition givenDefinition)
    {
        _givenDefinition = givenDefinition;
    }

    [When(@"I enter (.*), (.*) and (.*) into the calculator and press CurrentLogFailureIntensity")]
    public void WhenIEnteredIntoTheCalculatorAndPressCurrentLogFailureIntensity(float decayParam,
        float initialFailure, float expectedFailures)
    {
        _result = Math.Round(_givenDefinition.calculator.CalculateLogCurrentFailureIntensity(decayParam, initialFailure,
            expectedFailures), 2).ToString();
    }

    [When(
        @"I enter (.*), (.*) and (.*) into the calculator and press AverageLogExpectedFailure")]
    public void WhenIEnteredIntoTheCalculatorAndPressAverageLogExpectedFailure(float decayParam, float initialFailure,
        float cpuHours)
    {
        _result = Math
            .Round(_givenDefinition.calculator.CalculateLogAverageExpectedFailure(decayParam, initialFailure, cpuHours),
                2).ToString();
    }

    [Then(@"the log musa result should be (.*)")]
    public void ThenTheLogMusaResultShouldBe(string p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}