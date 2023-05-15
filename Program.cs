using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Missing_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 9, 6, 4, 2, 3, 5, 7, 0, 1 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    arr[i] = 8;
                    {
                        Console.Write("Missing number is =" + arr[i]);




                    }
                    Console.ReadLine();

                }
            }
        }
    }
}
        
    

