Feature: UsingCalculatorBasicReliability
In order to calculate the Basic Musa model's failures/intensities
As a Software Quality Metric enthusiast
I want to use my calculator to do this

    @BasicMusa
    Scenario: Calculate current failure intensity
        Given I have a calculator
        When I have entered <initial>, <average> and <total> into the calculator and press CurrentFailureIntensity
        Then the basic musa result should be <result>

    Examples:
      | initial | average | total | result |
      | 10      | 50      | 100   | 5      |
      | 5       | 55      | 110   | 2.5    |
      | 10      | 40      | 90    | 5.56   |

    @BasicMusa
    Scenario: Calculate average number of expected failures
        Given I have a calculator
        When I have entered <initial>, <total> and <time> into the calculator and press AverageExpectedFailure
        Then the basic musa result should be <result>

    Examples:
      | initial | total | time | result |
      | 10      | 100   | 10   | 63     |
      | 10      | 100   | 100  | 100    |