Feature: UsingCalculatorBasicReliability
  In order to calculate the Basic Musa model's failures and intensities
  As a Software Quality Metric enthusiast
  I want to use my calculator to do this

  @Reliability
  Scenario: Calculating average number of expected failures (μ(𝜏))
    Given I have a calculator
    When I have entered initial failure intensity 0.02, total failures expected 100, and time 10 into the calculator and press ExpectedFailures
    Then the expected basic failures result should be "0.1998"

  @Reliability
  Scenario: Calculating current failure intensity (λ(𝜏))
    Given I have a calculator
    When I have entered initial failure intensity 0.02, cumulative failures 0.1998, and total failures expected 100 into the calculator and press FailureIntensity
    Then the basic failure intensity result should be "0.01996"