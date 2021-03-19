using System;
using System.Threading;

namespace Tarea61
{
    class Program
    {
        
            public static void dibuja(int Cantidad)
            {
                int alto = 56;
                int largo = 80;
                int lado2= 5;
                int lado1= 5;
                int F, C, A;
             
                for (A = 1; A <= Cantidad; A++)
                {
                    for (F = lado1; F <= alto; F++)
                    {
                        Console.SetCursorPosition(F, alto); Console.Write("l"); Console.SetCursorPosition(F, lado2); Console.Write("*");
                    }
                    for (C = lado2; C <= largo; C++)
                    {
                        Console.SetCursorPosition(lado1, C); Console.Write("#");
                        Console.SetCursorPosition(alto, C); Console.Write("@");
                    }
                    lado2 = lado2 + 1;
                    alto = alto  - 1;
                    lado1= lado1+ 1;
                    largo  = largo - 1;
                }


            }


            static void Main(string[] args)
            {
                for (int tam = 1; tam < 9; tam++)
                {
                    dibuja(tam);
                    Thread.Sleep(1000);
                }
                Console.SetCursorPosition(25, 24);
                Console.Write("Pulse una tecla ");
            }
        }
    }
