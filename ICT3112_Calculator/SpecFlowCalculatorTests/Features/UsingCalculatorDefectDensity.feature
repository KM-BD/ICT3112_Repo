Feature: UsingCalculatorDefectDensity
  In order to evaluate the quality of software in terms of defect concentration
  As a system quality engineer
  I want to calculate the defect density based on total defects and the size of the codebase

  Scenario: Calculate defect density for a system
    Given I have a calculator
    When I input 50 defects and a codebase size of 10000 lines of code into the calculator    
    Then the defect density result should be "0.005 defects per line of code"
