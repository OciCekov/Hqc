namespace Methods
{
    using System;
    using System.Security.Authentication;

    public static class Methods
    {
        public static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides shlud be greater than zero.");
            }

            double halfPerimeter = (a + b + c) / 2;
            double area = Math.Sqrt(halfPerimeter * (halfPerimeter - a) * (halfPerimeter - b) * (halfPerimeter - c));
            return area;
        }

        public static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0:
                    return "zero";
                case 1:
                    return "one";
                case 2:
                    return "two";
                case 3:
                    return "three";
                case 4:
                    return "four";
                case 5:
                    return "five";
                case 6:
                    return "six";
                case 7:
                    return "seven";
                case 8:
                    return "eight";
                case 9:
                    return "nine";
                default: throw new AuthenticationException("Invalid digit: " + number);
            }
        }

        public static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                // return -1; This was probably not that bad, but anyway...
                throw new ArgumentNullException("elements");
            }

            for (var i = 1; i < elements.Length; i++)
            {
                if (elements[i] > elements[0])
                {
                    elements[0] = elements[i];
                }
            }

            return elements[0];
        }

        // This methods were probably better with "double number",
        // but don't wana do it, maybe there is some mastermind behind object
        public static string FormatWithFixedPoint(object number)
        {
            if (number == null)
            {
                throw new ArgumentException("parameter can't be null");
            }

            return string.Format("{0:f2}", number);
        }

        public static string FormatWithPercentage(object number)
        {
            if (number == null)
            {
                throw new ArgumentException("parameter can't be null");
            }

            return string.Format("{0:p0}", number);
        }

        public static string FormatWithSpacesToLeft(object number)
        {
            if (number == null)
            {
                throw new ArgumentException("parameter can't be null");
            }

            return string.Format("{0,8}", number);
        }

        public static double CalculateDistance(double x1, double y1, double x2, double y2, out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = Math.Abs(y1 - y2) < 0.0000;
            isVertical = Math.Abs(x1 - x2) < 0.0000;

            double distance = Math.Sqrt(((x2 - x1) * (x2 - x1)) + ((y2 - y1) * (y2 - y1)));
            return distance;
        }

        // public static void Main()
        // {
        //     Console.WriteLine(CalcTriangleArea(3, 4, 5));
        //
        //     Console.WriteLine(NumberToDigit(5));
        //
        //     Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
        //
        //     Console.WriteLine(FormatWithFixedPoint(1.3));
        //
        //     Console.WriteLine(FormatWithPercentage(0.75));
        //
        //     Console.WriteLine(FormatWithSpacesToLeft(2.30));
        //
        //     bool horizontal, vertical;
        //     Console.WriteLine(CalculateDistance(3, -1, 3, 2.5, out horizontal, out vertical));
        //     Console.WriteLine("Horizontal? " + horizontal);
        //     Console.WriteLine("Vertical? " + vertical);
        //
        //     var peter = new Student
        //     {
        //         FirstName = "Peter",
        //         LastName = "Ivanov",
        //         OtherInfo = "From Sofia, born at 17.03.1992"
        //     };
        //
        //     var stella = new Student
        //     {
        //         FirstName = "Stella",
        //         LastName = "Markova",
        //         OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993"
        //     };
        //
        //     Console.WriteLine("{0} older than {1} -> {2}",
        //         peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        // }
    }
}
