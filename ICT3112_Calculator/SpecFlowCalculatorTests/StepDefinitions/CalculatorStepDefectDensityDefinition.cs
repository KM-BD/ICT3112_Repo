using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;

namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorDefectDensityDefinitions : CalculatorStepsBase
    {
        public UsingCalculatorDefectDensityDefinitions(CalcContext context) : base(context) { }

        // Step to simulate entering the defects and code size into the calculator
        [When(@"I input (.*) defects and a codebase size of (.*) lines of code into the calculator")]
        public void WhenIInputDefectsAndCodebaseSizeIntoTheCalculatorAndPressCalculateDefectDensity(double totalDefects, double codeSize)
        {
            _context._result = _context._calculator.Divide(totalDefects, codeSize);
        }

        // Step to validate the result of the defect density calculation
        [Then(@"the defect density result should be ""(.*) defects per line of code""")]
        public void ThenTheDefectDensityResultShouldBe(string expectedResult)
        {
            // Convert the expected result to double and perform the comparison
            double expectedValue = Convert.ToDouble(expectedResult.Replace(" defects per line of code", ""));
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.0001));
        }
    }
}
