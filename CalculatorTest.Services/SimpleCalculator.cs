using CalculatorTest.Contracts;

namespace CalculatorTest.Services
{
    public class SimpleCalculator : ISimpleCalculator
    {
        // Assumption: test inputs are expected to stay within int bounds
        // Using checked() throws an OverflowException rather than silently wrapping around

        public int Add(int start, int amount)
        {
            return checked(start + amount);
        }


        public int Subtract(int start, int amount)
        {
            return checked(start - amount);
        }
    }
}
