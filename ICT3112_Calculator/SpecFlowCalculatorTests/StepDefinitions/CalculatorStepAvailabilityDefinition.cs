using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorAvailabilityStepDefinition: CalculatorStepsBase
    {
        public UsingCalculatorAvailabilityStepDefinition(CalcContext context) : base(context) { }

        // MTBF Calculation Step Definitions
        [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
        public void WhenIHaveEnteredValuesIntoTheCalculatorAndPressAddition(double mttf, double mttr)
        {
            _context._result = _context._calculator.Add(mttf, mttr);
        }

        [Then(@"the MTBF result should be (.*)")]
        public void TheMTBFResultsShouldBe(string p0)
        {
            // Remove the quotation from the input
            double outcome = Convert.ToDouble(p0.Trim('"'));
            // Verify that the answer is correct in doubles
            Assert.That(_context._result, Is.EqualTo(outcome));
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
        public void WhenIHaveEnteredValuesIntoTheCalculatorAndPressDivision(double mttf, double mtbf)
        {
            _context._result = _context._calculator.Divide(mttf, mtbf);
        }

        [Then(@"the availability result should be (.*)")]
        public void TheAvailabilityResultShouldBe(string p0)
        {
            double outcome = Convert.ToDouble(p0.Trim('"'));
            // Check if the answer is similar
            Assert.That(_context._result, Is.EqualTo(outcome).Within(0.0001));
        }
        
    }
}
