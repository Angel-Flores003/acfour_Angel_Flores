﻿using System;
using System.Runtime.CompilerServices;
namespace acfour_angel_Flores
{
    public class Acfour
    {
        public static void Main()
        {
            const string Prime = "Introdueix quants números vols introduir";
            const string Num = "Introdueix un número de la llista";
            const string Mostra = "Els números introduÏts són: ";
            const string Ordenat = "Els números ordenats de més gran a més petit són: ";
            const string Error = "Error de programa";
            int num;
            try
            {
                Console.WriteLine(Prime);
                num = Convert.ToInt32(Console.ReadLine());
                int[] quantitat = new int[num];
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine(Num);
                    quantitat[i] = Convert.ToInt32(Console.ReadLine());

                }
                Console.WriteLine(Mostra);
                for (int i = 0; i < num; i++)
                {
                    Console.Write("{0} ", quantitat[i]);
                }
                for (int i = 0; i < num - 1; i++)
                {
                    for (int j = i + 1; j < num; j++)
                    {
                        if (quantitat[i] < quantitat[j])
                        {
                            int aux = quantitat[i];
                            quantitat[i] = quantitat[j];
                            quantitat[j] = aux;
                        }
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine(Ordenat);
                for (int i = 0; i < num; i++)
                {
                    Console.Write("{0} ", quantitat[i]);
                }
            }
            catch (FormatException)
            {
                Console.WriteLine(Error);
            }
        }
    }
}