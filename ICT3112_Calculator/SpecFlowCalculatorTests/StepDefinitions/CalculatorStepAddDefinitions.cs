using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{        
    // Binding for UsingCalculatorAddition.feature
    [Binding]
    // Inherit from the abstract base class
    public sealed class UsingCalculatorAddStepDefinitions : CalculatorStepsBase
    {                        
        // Constructor, Specflow BoDI parameter injection, passes the CalcContext
        // will pass into class constructor
        // BoDI will check if the calculator context is already created
        // if not this class will instatiate it
        public UsingCalculatorAddStepDefinitions(CalcContext context) : base(context) { }

        // Shared step definition for initializing the calculator
        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            // The calculator is initialized via the shared context
            // Calculator is initialized through the context
            _context._calculator = _context._calculator ?? new Calculator();
        }

        [When(@"I have entered (.*) and (.*) into the calculator and press add")]
        public void WhenIHaveEnteredAndIntoTheCalculator(double p0, double p1)
        {
            _context._result = _context._calculator.Add(p0, p1);
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {
            Assert.That(_context._result, Is.EqualTo(p0));
        }
    }
}