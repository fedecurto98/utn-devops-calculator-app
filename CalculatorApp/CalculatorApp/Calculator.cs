namespace CalculatorApp
{
    public class Calculator
    {
        /// <summary>
        /// Suma dos elementos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Add(int a, int b) => a + b;

        /// <summary>
        /// Resta dos elementos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Subtract(int a, int b) => a - b;

        /// <summary>
        /// Multiplica dos elementos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static int Multiply(int a, int b) => a * b;

        /// <summary>
        /// Divide dos elementos
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        public static double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Cannot divide by zero.");

            return a / b;
        }
    }
}
