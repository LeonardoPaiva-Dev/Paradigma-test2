using System;
using System.Collections.Generic;

namespace Paradigma2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOriginal = new int[] { 2, 7, 11, 15 };
            
            //aqui é setado o valor da soma
            int soma = 22;
            calculaPares(arrayOriginal, soma);
        }

        static void calculaPares(int[] array, int sum)
        {
            HashSet<int> s = new HashSet<int>();
            for (int i = 0; i < array.Length; ++i)
            {
                int temp = sum - array[i];

                if (s.Contains(temp))
                {
                    Console.Write("Numero da soma: " + sum + "\nO par da soma: (" + array[i] + ", " + temp + ")");
                }
                s.Add(array[i]);
            }
        }
    }
}
