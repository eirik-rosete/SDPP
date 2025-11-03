using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio003
{
    public class Entero
    {
        private int numero;
        public Entero(int numero) 
        { 
            this.numero = numero;
        }

        public void Imprimir()
        {
            Console.WriteLine(
                $"El cuadrado de {numero} es {CalcularCuadrado(numero)}\n" +
                $"El cubo de {numero} es {CalcularCubo(numero)}\n");
        }

        private static int CalcularCuadrado(int numero)
        {
            int cuadrado = numero * numero;

            return cuadrado;
        }
        private static int CalcularCubo(int numero)
        {
            int cubo = numero * numero * numero;

            return cubo;
        }
    }
}
