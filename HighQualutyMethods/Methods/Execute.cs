namespace Methods
{
    using System;

    public class Execute
    {
        public static void Main()
        { 
            Console.WriteLine(Methods.CalcTriangleArea(3, 4, 5));

            Console.WriteLine(Methods.NumberToDigit(5));

            Console.WriteLine(Methods.FindMax(5, -1, 3, 2, 14, 2, 3));

            Console.WriteLine(Methods.FormatWithFixedPoint(1.3));

            Console.WriteLine(Methods.FormatWithPercentage(0.75));

            Console.WriteLine(Methods.FormatWithSpacesToLeft(2.30));

            bool horizontal, vertical;
            Console.WriteLine(Methods.CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            var peter = new Student
            {
                FirstName = "Peter",
                LastName = "Ivanov",
                OtherInfo = "From Sofia, born at 17.03.1992"
            };

            var stella = new Student
            {
                FirstName = "Stella",
                LastName = "Markova",
                OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
            };

            Console.WriteLine("{0} older than {1} -> {2}", peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
