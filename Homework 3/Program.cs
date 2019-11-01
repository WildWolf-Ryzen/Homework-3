using System;

namespace Homework_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, NOE, COP = 0, SON = 0, Input = 0;

            Console.Write("Input the number of elements to store in the array: ");
            NOE = Convert.ToInt32(Console.ReadLine());

            int[] arrOfInts = new int[NOE];

            Console.Write($"Input {NOE} elements\n");
            for (i = 0; i < NOE; i++)
            {
                Console.Write($"arr[{i}] = ");
                arrOfInts[i] = Convert.ToInt32(Console.ReadLine());

                if (arrOfInts[i] >= 0)
                {
                    COP++;
                }
                else
                {
                    SON += arrOfInts[i];
                }
            }


            int[] b = new int[2];
            b[0] = COP;
            b[1] = SON;

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            do
            {
                Console.WriteLine("Enter a number ");
                Input = Convert.ToInt32(Console.ReadLine());

            } while (Input <= 10);

            Console.WriteLine("Integer is grater than 10");
        }
    }
}