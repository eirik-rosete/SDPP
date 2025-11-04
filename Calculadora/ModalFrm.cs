using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class ModalFrm : Form
    {
        public uint NumeroDecimales { get; private set; }

        public ModalFrm(uint decimalesActuales)
        {
            InitializeComponent();
            NumeroDecimales = decimalesActuales;
  numericUpDown1.Value = decimalesActuales;
    }

   private void btnAceptar_Click(object sender, EventArgs e)
        {
     NumeroDecimales = (uint)numericUpDown1.Value;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
   DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
