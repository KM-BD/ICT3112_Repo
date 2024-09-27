using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;
using System.Runtime.InteropServices;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorMusaLogModelDefinitions : CalculatorStepsBase
    {
        public UsingCalculatorMusaLogModelDefinitions(CalcContext context) : base(context) { }

        [When(@"I input values to calculate the failure intensity with an initial failure intensity of (.*), a total number of failures expected of (.*), and a time of (.*)")]
        public void WhenIInputFailureValuesIntoTheCalculatorAndPressCalculateFailureIntensity(double lambda0, double theta, double mu)
        {
            _context._result = _context._calculator.LogFailureIntensity(lambda0, theta, mu);
        }

        [Then(@"the failure intensity result should be ""(.*)""")]
        public void ThenTheFailureIntensityResultShouldBe(string expectedResult)
        {
            double expectedValue = Convert.ToDouble(expectedResult);
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.01));
        }
        [When(@"I input values to calculate the expected number of failures with an initial failure intensity of (.*), a total number of failures expected of (.*), and a time of (.*)")]
        public void WhenIInputExpectedFailureValuesIntoTheCalculatorAndPressCalculateExpectedFailures(double lambda0, double theta, double tau)
        {
            _context._result = _context._calculator.LogExpectedFailures(lambda0, theta, tau);
        }

        [Then(@"the expected number of failures result should be ""(.*)""")]
        public void ThenTheExpectedFailuresResultShouldBe(string expectedResult)
        {
            double expectedValue = Convert.ToDouble(expectedResult);
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.01));
        }

    }

}
