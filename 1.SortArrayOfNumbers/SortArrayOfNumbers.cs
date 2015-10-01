using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SortArrayOfNumbers
    {
        static void Main()
        {
            string input = Console.ReadLine();
            int[] array = Array.ConvertAll(input.Split(' '), int.Parse);
            int holder;

            for (int k = 0; k < array.Length; k++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        holder = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = holder;
                    }
                }
            }
            Console.WriteLine(string.Join(" ", array));

        }
    }

