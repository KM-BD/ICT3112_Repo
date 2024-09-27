using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorBasicReliabilityStepDefinition : CalculatorStepsBase
    {
        public UsingCalculatorBasicReliabilityStepDefinition(CalcContext context) : base(context) { }

        // Calculated Expected Failure rate
        [When(@"I have entered initial failure intensity (.*), total failures expected (.*), and time (.*) into the calculator and press ExpectedFailures")]
        public void WhenIHaveEnteredValuesIntoTheCalculatorAndPressExpectedFailures(double lambda0, double nu0, double tau)
        {
            _context._result = _context._calculator.ExpectedFailures(lambda0, nu0, tau);
        }

        [Then(@"the expected basic failures result should be ""(.*)""")]
        public void ThenTheExpectedFailuresResultShouldBe(string expectedResult)
        {
            double expectedValue = Convert.ToDouble(expectedResult);
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.0001));
        }

        //Calculate Failure Intensity
        [When(@"I have entered initial failure intensity (.*), cumulative failures (.*), and total failures expected (.*) into the calculator and press FailureIntensity")]
        public void WhenIHaveEnteredValuesIntoTheCalculatorAndPressFailureIntensity(double lambda0, double muTau, double nu0)
        {
            _context._result = _context._calculator.FailureIntensity(lambda0, muTau, nu0);
        }

        [Then(@"the basic failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(string expectedResult)
        {
            double expectedValue = Convert.ToDouble(expectedResult);
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.0001));
        }
    }

}
