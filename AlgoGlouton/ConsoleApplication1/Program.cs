using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoGlouton
{
    class Program
    {
        static void Main(string[] args)
        {
            var pieces = new List<double>() { 200, 100, 50, 20, 10, 5, 2, 1 };

            while (true) // Loop indefinitely
            {
                Console.WriteLine("Enter input:"); // Prompt
                double value = double.Parse(Console.ReadLine()); // Get string from user
                if (value == 0) // Check string
                {
                    break;
                }

                //double value = 37;
                string info = value + " = ";

                foreach (var piece in pieces)
                {
                    if (value == 0)
                    {
                        Console.WriteLine(info);
                        break;
                    }

                    if (piece <= value)
                    {
                        if (piece == value)
                        {
                            info += string.Format(" ({0} x {1}) +", 1, piece);
                            value = value - piece;
                        }
                        else
                        {
                            var totalPieces = Math.Floor(value / piece);
                            value -= (piece * totalPieces);
                            info += string.Format(" ({0} x {1}) +", totalPieces, piece);
                        }
                    }

                }
            }
        }
    }
}
