namespace UsingVariables
{
    using System;

    public class Size
    {
        private double width;
        private double heigth;

        public double Width
        {
            get
            {
                return this.width;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width must have positive value");
                }
                this.width = value;
            }
        }

        public double Haigth
        {
            get
            {
                return this.heigth;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Heigth must have positive value");
                }
                this.heigth = value;
            }
        }

        public Size(double initialWidth, double initialHaight)
        {
            Width = initialWidth;
            Haigth = initialHaight;
        }


        public static Size GetRotatedSize(Size s, double angleOfTheFigureThatWillBeRotaed)
        {
            return new Size(
              Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.width +
                Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.heigth,
              Math.Abs(Math.Sin(angleOfTheFigureThatWillBeRotaed)) * s.width +
                Math.Abs(Math.Cos(angleOfTheFigureThatWillBeRotaed)) * s.heigth);
        }


    }

}
