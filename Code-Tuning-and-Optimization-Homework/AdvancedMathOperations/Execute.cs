namespace AdvancedMathOperations
{
    using System;

    public class Execute
    {
        public static void Main()
        {
            TestAdvancedOperations();
        }

        private static void TestAdvancedOperations()
        {
            double numDouble = 3.14;
            Console.WriteLine("Test double operations: ");
            PrintAdvancedTests<double>(numDouble);
            float numFloat = 3.14f;
            Console.WriteLine("Test float operations: ");
            PrintAdvancedTests<float>(numFloat);
            decimal numDecimal = 3.14m;
            Console.WriteLine("Test decimal operations: ");
            PrintAdvancedTests<decimal>(numDecimal);

            Console.WriteLine(new string('-', 20));
        }

        private static void PrintAdvancedTests<T>(T num) where T : struct
        {
            var tester = new AdvancedOperationsTester<T>(num);
            Console.WriteLine("Math square root: " + tester.TestSquareRoot());
            Console.WriteLine("Math natural lograithm: " + tester.TestLogarithm());
            Console.WriteLine("Math sinus: " + tester.TestSinus());
            Console.WriteLine(new string('-', 20));
        }
    }
}
