using ICT3112_Calculator;

namespace SpecFlowCalculatorTests
{
    public class CalcContext
    {
        public double _result { get; set; }
        public Calculator _calculator { get; set; }
        public CalcContext()
        {
            _calculator = new Calculator();  // Initialize Calculator here if needed
        }
    }
}
