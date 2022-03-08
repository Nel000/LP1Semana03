using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            // The bi-dimensional float array
            float[][] biDim;

            // Variables to store array dimensions
            int h, v;

            // Ask user for array horizontal values and store in INT
            Console.Write("Array horizontal dimensions: ");
            h = Convert.ToInt32(Console.ReadLine());

            // Ask user for array vertical values and store in INT
            Console.Write("Array vertical dimensions: ");
            v = Convert.ToInt32(Console.ReadLine());

            // Define array dimensions based on INT variables
            biDim = new float[h, v];
        }
    }
}
