using ICT3112_Calculator;
using BoDi;
using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    public abstract class CalculatorStepsBase
    {
        protected readonly CalcContext _context;

        // Constructor to inject the CalculatorContext
        protected CalculatorStepsBase(CalcContext context)
        {
            _context = context;
            _context._calculator = _context._calculator ?? new Calculator();  // Initialize Calculator in context if not already initialized

        }
        
    }
}

