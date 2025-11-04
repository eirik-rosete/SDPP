using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    public enum Moneda
    {
        Euro,
        Peseta
    }

    public enum Operacion
    {
        Ninguna,
        Suma,
        Resta,
        Multiplicacion,
        Division,
        Porcentaje
    }

    public class Calculadora
    {
        public const decimal CambioEuro = 166.386m;

        public event EventHandler? CambioBuffer;

        private decimal buffer;
        private Moneda moneda;
        private Operacion operacion;

        public decimal Buffer
        {
            get => buffer;
            set
            {
                if (buffer != value)
                {
                    buffer = value;
                    OnCambioBuffer();
                }
            }
        }

        public Moneda Moneda
        {
            get => moneda;
            set
            {
                if (moneda != value)
                {
                    ConvertirMoneda(moneda, value);
                    moneda = value;
                }
            }
        }

        public uint NumeroDecimales { get; set; }

        public Operacion Operacion
        {
            get => operacion;
            set
            {
                if (operacion != Operacion.Ninguna && value != Operacion.Ninguna)
                {
                    Calcular();
                }

                operacion = value;

                if (operacion != Operacion.Ninguna)
                {
                    Operando1 = Buffer;
                    Operando2 = 0;
                    Resultado = 0;
                }
            }
        }

        public decimal Operando1 { get; private set; }
        public decimal Operando2 { get; private set; }
        public decimal Resultado { get; private set; }

        public Calculadora()
        {
            buffer = 0;
            moneda = Moneda.Euro;
            NumeroDecimales = 2;
            operacion = Operacion.Ninguna;
            Operando1 = 0;
            Operando2 = 0;
            Resultado = 0;
        }

        protected virtual void OnCambioBuffer()
        {
            CambioBuffer?.Invoke(this, EventArgs.Empty);
        }

        private void ConvertirMoneda(Moneda origen, Moneda destino)
        {
            if (origen == destino)
                return;

            decimal factor = (origen == Moneda.Euro) ? CambioEuro : 1 / CambioEuro;

            Buffer = Math.Round(Buffer * factor, (int)NumeroDecimales);
            Operando1 = Math.Round(Operando1 * factor, (int)NumeroDecimales);
            Operando2 = Math.Round(Operando2 * factor, (int)NumeroDecimales);
            Resultado = Math.Round(Resultado * factor, (int)NumeroDecimales);
        }

        public void Calcular()
        {
            if (Operacion == Operacion.Ninguna)
            {
                return;
            }

            Operando2 = Buffer;

            switch (Operacion)
            {
                case Operacion.Suma:
                    Resultado = Operando1 + Operando2;
                    break;
                case Operacion.Resta:
                    Resultado = Operando1 - Operando2;
                    break;
                case Operacion.Multiplicacion:
                    Resultado = Operando1 * Operando2;
                    break;
                case Operacion.Division:
                    if (Operando2 != 0)
                    {
                        Resultado = Operando1 / Operando2;
                    }
                    else
                    {
                        Resultado = 0;
                    }
                    break;
                case Operacion.Porcentaje:
                    Resultado = (Operando1 * Operando2) / 100;
                    break;
            }

            Resultado = Math.Round(Resultado, (int)NumeroDecimales);

            Buffer = Resultado;

            Operando1 = Resultado;
            Operando2 = 0;
        }

        public void Limpiar()
        {
            Buffer = 0;
            Resultado = 0;
            Operando1 = 0;
            Operando2 = 0;
            operacion = Operacion.Ninguna;
        }

        public void LimpiarMemoria()
        {
            Operando1 = 0;
        }

        public void RecuperarMemoria()
        {
            Buffer = Operando1;
        }

        public void RestarEnMemoria()
        {
            Operando1 -= Buffer;
        }

        public void SumarEnMemoria()
        {
            Operando1 += Buffer;
        }
    }
}
