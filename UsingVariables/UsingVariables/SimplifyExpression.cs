namespace UsingVariables
{
    using System;

    public class Size
    {
        private double width;
        private double heigth;

        public Size(double initialWidth, double initialHaight)
        {
            this.Width = initialWidth;
            this.Haigth = initialHaight;
        }

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

        public static Size GetRotatedSize(Size currentFigureSize, double angleOfTheFigure)
        {
            double width = Math.Abs(Math.Cos(angleOfTheFigure)) * currentFigureSize.width +
                           Math.Abs(Math.Sin(angleOfTheFigure)) * currentFigureSize.heigth;
            double height = Math.Abs(Math.Sin(angleOfTheFigure)) * currentFigureSize.width +
                            Math.Abs(Math.Cos(angleOfTheFigure)) * currentFigureSize.heigth;
            var rotatedFigure = new Size(width, height);
            return rotatedFigure;
        }
    }
}