using System;

namespace laba9
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] myArray = new double[,]
            {
                {0.7, 0.1, 0.1, 0.1},
                {0.2, 0.6, 0.0, 0.2},
                {0.2, 0.0, 0.5, 0.3},
                {0.0, 0.0, 0.0, 1.0}

            };

            double result = 0;

            for(int i = 0; i< myArray.GetLength(0); i++)
            {
                for (int j = 0; j < myArray.GetLength(1); j++)
                {
                    Console.Write(myArray[i, j] + "\t");
                    
                    if (j % 2 == 0)
                    {
                        result += myArray[i,j];

                    }

                }
                Console.WriteLine(result);
                Console.ReadLine();

            }
            static void Print(double[,] myArray)
            {
                for (int i = 0; i < myArray.GetLength(0); i++)
                {
                    for (int j = 0; j < myArray.GetLength(1); i++)
                    {
                        Console.Write(myArray[i, j] + " ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

            }
        }
    }   
}
