using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    // Binding for UsingCalculatorAddition.feature
    [Binding]
    public sealed class UsingCalculatorDivStepDefinitions : CalculatorStepsBase
    {        
        // Constructor        
        public UsingCalculatorDivStepDefinitions(CalcContext context) : base(context) { }


        [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _context._result = _context._calculator.Divide(p0, p1);
        }

        [Then(@"the division result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(double p0)
        {
            Assert.That(_context._result, Is.EqualTo(p0));
        }
        [Then(@"the division result equals positive_infinity")]
        public void ThenTheDivisionResultEqualsPositiveInfinity()
        {
            // Assert that the result is positive infinity
            Assert.That(_context._result, Is.EqualTo(double.PositiveInfinity));
        }
    }
}