# Perform Quality Metric Calculations - EPIC
Feature: UsingCalculatorQualityMetric
In order to calculate the code defects and KSSI
As a System Quality Engineer
I want to use my calculator to do this
    
    @QualityMetrics
    Scenario: Calculate Defect Density
        Given I have a calculator
        When I enter 50 and 20 into the calculator and press DefectDensity
        Then the quality metrics result should be 2.5

    @QualityMetrics
    Scenario: Calculate KSSI
        Given I have a calculator
        When I enter 50, 20 and 4 into the calculator and press KSSI
        Then the quality metrics result should be 66