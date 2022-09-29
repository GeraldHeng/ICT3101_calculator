# Perform Quality Metric Calculations - EPIC
Feature: UsingCalculatorLogReliability
In order to calculate the Log Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    @LogMusa
    Scenario: Calculate log current failure intensity
        Given I have a calculator
        When I enter <decay>, <initial> and <average> into the calculator and press CurrentLogFailureIntensity
        Then the log musa result should be <result>

    Examples:
      | decay | initial | average | result |
      | 0.02  | 10      | 50      | 3.68   |

    @LogMusa
    Scenario: Calculate log average number of expected failures
        Given I have a calculator
        When I enter <decay>, <initial> and <time> into the calculator and press AverageLogExpectedFailure
        Then the log musa result should be <result>

    Examples:
      | decay | initial | time | result |
      | 0.02  | 10      | 10   | 55     |
      | 0.02  | 10     | 100  | 152    |