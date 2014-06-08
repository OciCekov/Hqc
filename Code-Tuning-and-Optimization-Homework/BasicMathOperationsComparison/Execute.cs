namespace BasicMathOperationsComparison
{
    using System;
    using System.Collections.Generic;

    public class Execute
    {
        public static void Main()
        {
            TestBasicOperations();
        }

        private static void TestBasicOperations()
        {
            var intCollection = new int[] { 3, 5, 2, 9, 10, 4, 32, 110000, 932819, -321421312, -2, 15151, -83215, 27 };
            Console.WriteLine("Test integers operations: ");
            PrintBasicTests<int>(intCollection);

            var longCollection = new long[]
            {
                191919191919191, -123128382183, 55, 4, 12315412, 7, -521839214921321234, 110000,
                3213213, -8392175812, -2, 15151, 1200000000000000000, 27
            };

            Console.WriteLine("Test long operations: ");
            PrintBasicTests<long>(longCollection);

            var floatCollection = new float[]
            {
                3.14f, -3213.38321f, 55.555f, -0.92574f, 12315412.5213f, 7.0f, -52121.321234f, 110000.1f,
                3.213213f, -83921.75812f, -2.0f, 151.51f, 1000.1000f, -132.27f
            };

            Console.WriteLine("Test float operations: ");
            PrintBasicTests(floatCollection);

            var doubleCollection = new double[]
            {
                3.14, -3213.383242131, 55.555555, -0.92574, 12315412.5213, 7.0, -52121.3212343212,
                110000.11111, 231233.213213, -83921.75812, -2.0, 151.51, 1000.10000000012342, -132.27
            };

            Console.WriteLine("Test double operations: ");
            PrintBasicTests(doubleCollection);

            var decimalCollection = new decimal[]
            {
                332213.168921374823913264m, -3213.383281293887531342131m,
                5555555555.5555532131251231512316661235m, -0.925232232311509481256798376518274m, 12315412.5213m, 7.0m,
                -5212423123131.32123432152131232m, 110000.11111m, 231233.213213m, -83921.75812m, -2.0m, 151.51m, 1000.10000000012342m,
                -132.27m
            };

            Console.WriteLine("Test decimal operations: ");
            PrintBasicTests(decimalCollection);

            Console.WriteLine(new string('-', 20));
        }

        private static void PrintBasicTests<T>(IList<T> collection) where T : struct
        {
            var tester = new BasicOperationsTester<T>(collection);
            Console.WriteLine("Addition: " + tester.TestAddition());
            Console.WriteLine("Subtraction: " + tester.TestSubtraction());
            Console.WriteLine("Multiplication: " + tester.TestMultiplication());
            Console.WriteLine("Division: " + tester.TestDivision());
            Console.WriteLine("Increments: " + tester.TestIncremention(1000));
            Console.WriteLine(new string('-', 20));
        }
    }
}
