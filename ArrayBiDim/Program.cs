using System;

namespace ArrayBiDim
{
    class Program
    {
        static void Main(string[] args)
        {
            // The bi-dimensional float array
            float[,] biDim;

            // Variables to store array dimensions
            int h, v;

            // Variables to store average and sum values
            float val = 0, sum = 0;
            float[] avg;

            // Ask user for array horizontal values and store in INT
            Console.Write("Array horizontal dimensions: ");
            h = Convert.ToInt32(Console.ReadLine());

            // Ask user for array vertical values and store in INT
            Console.Write("Array vertical dimensions: ");
            v = Convert.ToInt32(Console.ReadLine());

            // Define array dimensions based on INT variables
            biDim = new float[v, h];
            avg = new float[v];

            // Go through each line in the array
            for (int i = 0; i < biDim.GetLength(0); i++)
            {   
                for (int j = 0; j < biDim.GetLength(1); j++)
                {
                    // Request value for each array position
                    Console.Write($"Assign a float value to position {i}, {j}: ");

                    // Save array value from user input
                    biDim[i, j] = Convert.ToSingle(Console.ReadLine());

                    // Add position value to values INT
                    val += biDim[i, j];
                }

                // Assign current average to variable and reset values INT
                avg[i] = val / h;
                val = 0;
            }

            // Add space before results
            Console.WriteLine();

            // Print average values for each line
            for (int i = 0; i < avg.Length; i++)
            {
                Console.WriteLine($"Average for line {i}: {avg[i]}");

                // Add current line's average to sum value
                sum += avg[i];
            }

            // Print sum of all averages
            Console.WriteLine($"Sum of all line averages: {sum}");
        }
    }
}
