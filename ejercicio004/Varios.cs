using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio004
{
    public class Varios
    {
        private int rangoDeNumeros;

        public Varios() 
        {
            rangoDeNumeros = 30;
        }

        public static int[] MostrarPrimos(int rangoDeNumeros)
        {
            int contador = 0;

            for (int i = 2; i <= rangoDeNumeros; i++) 
            {
                if (EsPrimo(i))
                {
                    contador++;
                }
                    
            }

            int[] primos = new int[contador];

            int indice = 0;
            for (int i = 2; i <= rangoDeNumeros; i++) 
            {
                if (EsPrimo(i))
                {
                    primos[indice] = i;
                    indice++;
                }
            }

            return primos;
        }

        public void ImprimirPrimos()
        {
            int[] primos = MostrarPrimos(rangoDeNumeros);
            
            for (int i = 0; i < primos.Length; i++) 
            {
                Console.WriteLine($"El número {primos[i]} es primo");
            }
        }

        public static int[] MostrarNoPrimos(int rangoDeNumeros, int[] primos)
        {
            int[] noPrimos = new int[rangoDeNumeros - primos.Length];

            int indice = 0;
            int indicePrimos = 0;
            for (int i = 1; i <= rangoDeNumeros; i++)
            {
                if (indicePrimos >= primos.Length || i != primos[indicePrimos])
                {
                    noPrimos[indice] = i;
                    indice++;
                }
                else 
                {
                    indicePrimos++;
                }
            }

            return noPrimos;
        }
        public void ImprimirNoPrimos()
        {
            int[] primos = MostrarPrimos(rangoDeNumeros);
            int[] noPrimos = MostrarNoPrimos(rangoDeNumeros, primos);

            for (int i = 0; i < noPrimos.Length; i++)
            {
                Console.WriteLine($"El número {noPrimos[i]} no es primo");
            }
        }

        private static bool EsPrimo(int numero)
        {
            if (numero <= 1)
                return false;

            for (int i = 2; i <= Math.Sqrt(numero); i++)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}