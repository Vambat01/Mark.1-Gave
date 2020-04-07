using System;
using System.Collections;

namespace TestSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            #region l1
            int[] intArray = new int[4];
            intArray[0] = 1;
            intArray[1] = 2;
            intArray[2] = 3;
            intArray[3] = 4;

            int[] intArray2 = { 1, 2, 3, 4 };

            Console.WriteLine($"{intArray.Length}/{intArray2.Length} {intArray.ToString()}");

            // NOT OK
            object[] objArray = { 1, 5m, "dqwd", Math.PI };
            Console.WriteLine(((string)objArray[2]).ToUpper());

            string[] strArray = { "qaz", "wsx", "edc" };
            Console.WriteLine(strArray[0].ToUpper());

            /*  
             *  0 1 2
             *  1 2 3
             *  2 3 4
             */

            int[,] intArray2dim = new int[3, 3];
            intArray2dim[0, 0] = 0;

            intArray2dim[1, 0] = 1;
            intArray2dim[0, 1] = 1;

            intArray2dim[0, 2] = 2;
            intArray2dim[1, 1] = 2;
            intArray2dim[2, 0] = 2;

            intArray2dim[1, 2] = 3;
            intArray2dim[2, 1] = 3;

            intArray2dim[2, 2] = 4;

            for (int i = 0; i < intArray2dim.GetLength(0); i++)
            {
                for (int k = 0; k < intArray2dim.GetLength(1); k++)
                {
                    Console.Write("{0}; ", intArray2dim[i, k]);
                }
                Console.Write(Environment.NewLine);
            }

            ArrayList arrayList = new ArrayList(objArray);

            string c = "123";

            while (c.Length < 10)
            {
                c += "q";
            }

            do
            {
                c += "8";
            }
            while (c.Length < 15);

            Console.WriteLine(c);

            foreach (int item in intArray2)
            {
                Console.WriteLine(item);
            }

            int[,,] nums3 = {
                {
                    { 0, 1, 2 },
                    { 3, 4, 5 }
                },
                {
                    { 0, 1, 2 },
                    { 3, 4, 5 }
                }
            };
            var arr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 } };
            ShowArray(arr, separator: " | ");
            Console.WriteLine();
            ShowArray(arr);
            #endregion

            Cat cat = new Cat("Barsik", 5, 5.5, "grey", "yellow");
            cat.Meow();
            int barsikHumanAge = cat.InHumanAge(15);
            Console.WriteLine($"barsikHumanAge: {barsikHumanAge}");
        }

        static void ShowArray(int[,] array, string separator = ", ")
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int k = 0; k < array.GetLength(1); k++)
                {
                    Console.Write($"{array[i, k]}{separator}");
                    array[i, k]++;
                }
                Console.WriteLine();
            }
        }
    }
}
