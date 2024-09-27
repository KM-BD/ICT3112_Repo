Feature: UsingCalculatorSSI
  In order to track the total number of SSI across releases
  As a system quality engineer
  I want to calculate the new total number of SSI for each release based on new, changed, and deleted code

  Scenario: Calculate new total number of SSI for a successive release
    Given I have a calculator
    When I input a previous SSI of 50 KLOC, 20 KLOC of new and changed code, and 4 KLOC of deleted code into the calculator    
    Then the total SSI result should be "66 KLOC"