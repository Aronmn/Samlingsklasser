﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samlingsklasser
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, int> resultat = new Dictionary<int, int>();

            Random random = new Random();

            for (int i = 0; i < 1000; i++)
            {
                int tal = random.Next(1, 7);

                if (!resultat.ContainsKey(tal))
                    resultat.Add(tal, 0);

                resultat[tal]++;
            }

            foreach (KeyValuePair<int, int> kvp in resultat)
            {
                Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
            }

        }
    }
}
