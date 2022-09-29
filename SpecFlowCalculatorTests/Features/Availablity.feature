Feature: UsingCalculatorAvailability
In order to calculate MTBF and Availability
As someone who struggles with math
I want to be able to use my calculator to do this
    @Availability
    Scenario: Calculating MTBF
        Given I have a calculator
        When I have entered <MTTF> and <MTTR> into the calculator and press MTBF
        Then the availability result should be <result>
        Examples:
          | MTTF | MTTR| result |
          | 12    |1   | 13     |
          | 34    |12  | 46     |
          | 100   |101 | 201    |
        
    @Availability
    Scenario: Calculating Availability
        Given I have a calculator
        When I have entered <MTTF> and <MTBF> into the calculator and press Availability
        Then the availability result should be <result>
        Examples:
          | MTTF | MTBF | result |
          | 200  |210   |0.95    |
          | 45   |60    | 0.75   |
          | 900  |1000  | 0.9    |
        