using System;
using System.IO;

namespace ImportTxtData
{
    class Program
    {
        private static int[,] ImportDataFromTxtToMatrix(string textName, int rows, int columns, char seperator)
        {
            var matrix = new int[rows, columns];

            using (TextReader reader = File.OpenText(textName))
            {
                for (int i = 0; i <= rows - 1; i++)
                {
                    string text = reader.ReadLine();
                    string[] bits = text.Split(seperator); // For space separator: ' '
                    for (int j = 0; j <= columns - 1; j++)
                    {
                        matrix[i, j] = int.Parse(bits[j]);
                    }
                }
            }
            return matrix;
        }
    }
}
