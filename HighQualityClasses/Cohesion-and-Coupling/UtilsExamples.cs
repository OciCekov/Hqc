namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(FileUtilities.GetFileExtension("example"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileExtension("example.new.pdf"));

            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(FileUtilities.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", CalculateDistance.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", CalculateDistance.CalcDistance3D(5, 2, -1, 3, -6, 4));
            Console.WriteLine("Volume = {0:f2}", CalculateDistance.CalcVolume());

            CuboidProperties.Width = 3;
            CuboidProperties.Height = 4;
            CuboidProperties.Depth = 5;

            Console.WriteLine("Diagonal XYZ = {0:f2}", CalculateDiagonal.CalcDiagonalXYZ());
            Console.WriteLine("Diagonal XY = {0:f2}", CalculateDiagonal.CalcDiagonalXY());
            Console.WriteLine("Diagonal XZ = {0:f2}", CalculateDiagonal.CalcDiagonalXZ());
            Console.WriteLine("Diagonal YZ = {0:f2}", CalculateDiagonal.CalcDiagonalYZ());
        }
    }
}
