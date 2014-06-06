namespace Abstraction
{
    using System;

    public class Rectangle : IFigure
    {
        private double width;
        private double height;

        public Rectangle(double initialWidth, double initialHeight)
        {
            this.Width = initialWidth;
            this.Height = initialHeight;
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can't be negative or zero");
                }

                this.height = value;
            }
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
                    throw new ArgumentException("Width can't be negative or zero");
                }

                this.width = value;
            }
        }

        public double CalculatePerimeter()
        {
            double perimeter = 2 * (this.Width + this.Height);
            return perimeter;
        }

        public double CalculateSurface()
        {
            double surface = this.Width * this.Height;
            return surface;
        }
    }
}