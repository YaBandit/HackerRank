using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ultimate1
{
    class Program
    {
        static void Main(string[] args)
        {
            int cases = Int32.Parse(Console.ReadLine());
            List<int> results = new List<int>();

            for (int i = 0; i < cases; i++)
            {
                string input = Console.ReadLine();
                string[] stringDimenstion = input.Split();

                int width = Int32.Parse(stringDimenstion[0]);
                int height = Int32.Parse(stringDimenstion[1]);

                if (width == height)
                {
                    results.Add(1);
                }
                else if (width < height)
                {
                    results.Add(returnSquares(width, height));
                }
                else
                {
                    results.Add(returnSquares(height, width));
                }
            }

            foreach (int result in results)
            {
                Console.WriteLine(result);
            }

            //Console.WriteLine("\nPress Any Key to exit\n");
            //Console.ReadLine();
        }

        static int returnSquares(int smaller, int larger)
        {
            int squares = 0;
            for (int i = 1; i <= smaller; i++)
            {
                if (smaller%i == 0 && larger%i == 0)
                {
                    int numAcross = smaller/i;
                    int numLong = larger/i;
                    squares = numAcross*numLong;
                }
            }
            return squares;
        }
    }
}
