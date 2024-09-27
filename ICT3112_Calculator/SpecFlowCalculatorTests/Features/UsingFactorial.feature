Feature: UsingFactorial

A short summary of the feature
// Ensure you have at least two scenarios, one for a normal factorial 
calculation and another for a zero factorial. Are there any issues you face here? 
@Factorial
Scenario: Factorial Operation on a number
	Given I have a calculator
	When I have entered 5 into the calculator and press Factorial
	Then the factorial result should be 120
#
@Factorial
Scenario: Zero Factorial
	Given I have a calculator
	When I have entered 0 into the calculator and press Factorial
	Then the factorial result should be 1
