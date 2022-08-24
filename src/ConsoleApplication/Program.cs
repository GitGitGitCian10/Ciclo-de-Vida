//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            for (int x = 0; x < 10000000; x++)
            {
                new Train($"Tren {x++}");
            }
            Console.WriteLine(Train.Count);
            Train t1 = new Train("Last Train to London");
            Train t2 = new Train("Last Train to London");
            Train t3 = new Train("Runaway Train");
            Console.WriteLine(t1 == t2);
            Console.WriteLine(t2 == t3);
        }
    }
}