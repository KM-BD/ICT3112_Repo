using ICT3112_Calculator;
using NUnit.Framework;
using BoDi;


namespace SpecFlowCalculatorTests.StepDefinitions
{
    [Binding]
    public sealed class UsingCalculatorSSIStepDefinitions : CalculatorStepsBase
    {
        public UsingCalculatorSSIStepDefinitions(CalcContext context) : base(context) { }

        [When(@"I input a previous SSI of (.*) KLOC, (.*) KLOC of new and changed code, and (.*) KLOC of deleted code into the calculator")]
        public void WhenIInputSSIValuesIntoTheCalculatorAndPressCalculateTotalSSI(double previousSSI, double newChangedCode, double deletedCode)
        {
            _context._result = _context._calculator.SecondReleaseTotalSSI(previousSSI, newChangedCode, deletedCode);
        }

        [Then(@"the total SSI result should be ""(.*) KLOC""")]
        public void ThenTheTotalSSIResultShouldBe(string expectedResult)
        {
            double expectedValue = Convert.ToDouble(expectedResult.Replace(" KLOC", ""));
            Assert.That(_context._result, Is.EqualTo(expectedValue).Within(0.0001));
        }
    }

}
