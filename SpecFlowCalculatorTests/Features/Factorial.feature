Feature: UsingCalculatorFactorial
In order to conquer factorials
As a factorial enthusiast
I want to understand a variety of factorial operations
    @Factorials
    Scenario: Factoring a normal number
        Given I have a calculator
        When I have entered <number> into the calculator and press factorial
        Then the factorial result should be <result>
        Examples:
          | number | result |
          | 5      | 120    |
          | 4      | 24     |
          | 3      | 6      |
    @Factorials
    Scenario: Factoring a zero
        Given I have a calculator
        When I have entered 0 into the calculator and press factorial
        Then the factorial result should be 1
    