Feature: UsingCalculatorAvailability
	In order to calculate MTBF and Availability 
	As someone who struggles with math 
	I want to be able to use my calculator to do this

	# This feature allows users to calculate Mean Time Between Failures (MTBF) 
	# and Availability using a calculator based on the correct formulas.
	# MTBF = MTTF + MTTR
	# Availability = MTTF / (MTTF + MTTR)


@Availability 
Scenario: Calculating MTBF 
	Given I have a calculator 
	When I have entered 200 and 10 into the calculator and press MTBF
	Then the MTBF result should be "210" 

@Availability 
Scenario: Calculating Availability 
	Given I have a calculator 
	When I have entered 200 and 210 into the calculator and press Availability 
	Then the availability result should be "0.9523" 

  @Availability 
 Scenario: Calculating Availability with zero uptime
    Given I have a calculator
    When I have entered 0 and 10 into the calculator and press Availability
    Then the availability result should be "0"