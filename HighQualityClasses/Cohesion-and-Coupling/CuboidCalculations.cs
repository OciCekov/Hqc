namespace CohesionAndCoupling
{
    using System;

    public class CuboidProperties
    {
        private static double width;
        private static double height;
        private static double depth;

        public static double Width
        {
            get
            {
                return width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width can't be negative or equal to zero");
                }

                width = value;
            }
        }

        public static double Height
        {
            get
            {
                return height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Height can't be negative or equal to zero");
                }

                height = value;
            }
        }

        public static double Depth
        {
            get
            {
                return depth;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Depth can't be negative or equal to zero");
                }

                depth = value;
            }
        }
    }
}