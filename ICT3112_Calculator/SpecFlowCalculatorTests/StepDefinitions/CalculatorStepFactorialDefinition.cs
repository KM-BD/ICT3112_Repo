using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorFactorialStepDefinitions : CalculatorStepsBase
    {
        public UsingCalculatorFactorialStepDefinitions(CalcContext context) : base(context) { }

        [When(@"I have entered (.*) into the calculator and press Factorial")]
        public void WhenIHaveEnteredIntoTheCalculator(int p0)
        {
            _context._result = _context._calculator.Factorial(p0);
        }

        // Renamed The result should be to this string
        // Conflicts were happening as it is the same Then from Add feature
        [Then(@"the factorial result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            Assert.That(_context._result, Is.EqualTo(p0));
        }
    }
}   
