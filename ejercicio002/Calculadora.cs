using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio001
{
    public class Calculadora
    {
        private int a = 20;
        private int b = 4;
        public void Imprimir()
        {
            Console.WriteLine
                ($"Números: {a} y {b}\n" +
                $"Suma: {Sumar(a, b)}\n" +
                $"Resta {Restar(a, b)}\n" +
                $"Multiplicación: {Multiplicar(a, b)}\n" +
                $"División {Dividir(a, b)}\n");
        }
        public static int Sumar(int a, int b)
        {
            return a + b;
        }

        public static int Restar(int a, int b)
        {
            return a - b;
        }
        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            return a / b;
        }
    }
}