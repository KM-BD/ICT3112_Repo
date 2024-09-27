Feature: UsingCalculatorMusaLogModel
  In order to predict system reliability over time
  As a system quality engineer
  I want to calculate failure intensity and the expected number of failures using the Musa Logarithmic model

Scenario: Calculate failure intensity using Musa model
  Given I have a calculator
  When I input values to calculate the failure intensity with an initial failure intensity of 10, a total number of failures expected of 0.02, and a time of 50
  Then the failure intensity result should be "3.67"

Scenario: Calculate expected failures using Musa model
  Given I have a calculator
  When I input values to calculate the expected number of failures with an initial failure intensity of 10, a total number of failures expected of 0.02, and a time of 50
  Then the expected number of failures result should be "119.89"

