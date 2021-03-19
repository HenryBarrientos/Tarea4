using System;
using System.Threading;

namespace tarea62
{
    class Program
    {
        static string Mid(string parametro, int startIndex, int length)
        {
            string result = parametro.Substring(startIndex, length); return result;
        }
        static void Main(string[] args)
        {
            string nombre;
            string l;
            int K = 0;
            int orden = 0;
            int letra = 0;
            int final = 0;
            Console.Write(" Ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.SetCursorPosition(1, 12);
            Console.Write(nombre);
            letra = nombre.Length;
            final = 70;
            nombre = nombre.ToUpper();
            for (orden = letra; orden >= 1; orden --)
            {
                l = Mid(nombre, orden- 1, 1);
                for (K = letra; K <= final; K++)
                {
                    Console.SetCursorPosition(K, 12);
                    Console.Write(" " + l);
                    Thread.Sleep(50);
                }
                final = final - 1;
                letra = letra - 1;

            }
            Console.WriteLine();
        }
    }
}
