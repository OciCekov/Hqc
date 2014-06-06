namespace CohesionAndCoupling
{
    public class CalculateDiagonal : CuboidProperties
    {
        public static double CalcDiagonalXYZ()
        {
            // double distance = CalculateDistance.CalcDistance3D(0, 0, 0, Width, Height, Depth);
            // according to how the formula is called, this is much better way for this to be just alone. 
            // also with this it depends only on cuboidCalculations.
            // and yes it could be better if this was a method with parameters, but it'll loose the point.
            double diagonal = (Width * Width) + (Height * Height) + (Depth * Depth);
            return diagonal;
        }

        public static double CalcDiagonalXY()
        {
            double diagonal = (Width * Width) + (Height * Height);
            return diagonal;
        }

        public static double CalcDiagonalXZ()
        {
            double diagonal = (Width * Width) + (Height * Height);
            return diagonal;
        }

        public static double CalcDiagonalYZ()
        {
            double diagonal = (Height * Height) + (Depth * Depth);
            return diagonal;
        }
    }
}
