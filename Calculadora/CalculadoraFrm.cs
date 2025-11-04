namespace Calculadora
{
    public partial class CalculadoraFrm : Form
    {
        private Calculadora calculadora;

        public CalculadoraFrm()
        {
            InitializeComponent();
            calculadora = new Calculadora();
            calculadora.CambioBuffer += Calculadora_CambioBuffer;
            ActualizarVisor();
            ActualizarDivisa();
        }

        private void Calculadora_CambioBuffer(object? sender, EventArgs e)
        {
            ActualizarVisor();
        }

        private void ActualizarVisor()
        {
            textBox1.Text = calculadora.Buffer.ToString($"N{calculadora.NumeroDecimales}");
            textBox1.SelectAll();
        }

        private void ActualizarDivisa()
        {
            Divisa.Text = calculadora.Moneda == Moneda.Euro ? "€" : "Pts";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '-')
            {
                string textoLimpio = textBox1.Text.Replace(".", "").Replace(",", ".");
                if (decimal.TryParse(textoLimpio,
                    System.Globalization.NumberStyles.Any,
                    System.Globalization.CultureInfo.InvariantCulture,
                    out decimal valor))
                {
                    valor = -valor;
                    textBox1.Text = valor.ToString($"N{calculadora.NumeroDecimales}");
                    textBox1.SelectAll();
                }
                e.Handled = true;
                return;
            }

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (decimal.TryParse(textBox1.Text.Replace(".", "").Replace(",", "."),
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valor))
            {
                calculadora.Buffer = valor;
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void Suma_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Operacion = Operacion.Suma;
            textBox1.Focus();
        }

        private void Resta_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Operacion = Operacion.Resta;
            textBox1.Focus();
        }

        private void Multiplicacion_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Operacion = Operacion.Multiplicacion;
            textBox1.Focus();
        }

        private void Division_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Operacion = Operacion.Division;
            textBox1.Focus();
        }

        private void Porcentaje_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Operacion = Operacion.Porcentaje;
            textBox1.Focus();
        }

        private void Igual_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Calcular();
            textBox1.Focus();
        }

        private void Borrar_Click(object sender, EventArgs e)
        {
            calculadora.Limpiar();
            textBox1.Focus();
        }

        private void ConversorMoneda_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.Moneda = calculadora.Moneda == Moneda.Euro ? Moneda.Peseta : Moneda.Euro;
            ActualizarDivisa();
            textBox1.Focus();
        }

        private void MMas_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.SumarEnMemoria();
            textBox1.Focus();
        }

        private void MMenos_Click(object sender, EventArgs e)
        {
            ActualizarBuffer();
            calculadora.RestarEnMemoria();
            textBox1.Focus();
        }

        private void CM_Click(object sender, EventArgs e)
        {
            calculadora.LimpiarMemoria();
            textBox1.Focus();
        }

        private void RM_Click(object sender, EventArgs e)
        {
            calculadora.RecuperarMemoria();
            textBox1.Focus();
        }

        private void ActualizarBuffer()
        {
            string texto = textBox1.Text.Replace(".", "").Replace(",", ".");
            if (decimal.TryParse(texto,
                System.Globalization.NumberStyles.Any,
                System.Globalization.CultureInfo.InvariantCulture,
                out decimal valor))
            {
                calculadora.Buffer = valor;
            }
        }

        private void ajusteDecimalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var modalForm = new ModalFrm(calculadora.NumeroDecimales))
            {
                if (modalForm.ShowDialog() == DialogResult.OK)
                {
                    calculadora.NumeroDecimales = modalForm.NumeroDecimales;
                    ActualizarVisor();
                }
            }
            textBox1.Focus();
        }
    }
}
