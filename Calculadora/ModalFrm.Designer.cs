namespace Calculadora
{
  partial class ModalFrm
    {
        /// <summary>
    /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

   /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
    if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
  /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
      {
   label1 = new Label();
 numericUpDown1 = new NumericUpDown();
        btnAceptar = new Button();
            btnCancelar = new Button();
     ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
     SuspendLayout();
            // 
            // label1
         // 
    label1.AutoSize = true;
 label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
      label1.Location = new Point(30, 40);
            label1.Name = "label1";
    label1.Size = new Size(158, 20);
            label1.TabIndex = 0;
            label1.Text = "Número de decimales:";
       // 
     // numericUpDown1
 // 
         numericUpDown1.Location = new Point(200, 38);
       numericUpDown1.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
   numericUpDown1.Name = "numericUpDown1";
    numericUpDown1.Size = new Size(80, 27);
            numericUpDown1.TabIndex = 1;
   numericUpDown1.Value = new decimal(new int[] { 2, 0, 0, 0 });
   // 
            // btnAceptar
         // 
        btnAceptar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnAceptar.Location = new Point(50, 120);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(94, 40);
         btnAceptar.TabIndex = 2;
         btnAceptar.Text = "Aceptar";
 btnAceptar.UseVisualStyleBackColor = true;
   btnAceptar.Click += btnAceptar_Click;
            // 
        // btnCancelar
// 
        btnCancelar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCancelar.Location = new Point(180, 120);
        btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(94, 40);
         btnCancelar.TabIndex = 3;
            btnCancelar.Text = "Cancelar";
     btnCancelar.UseVisualStyleBackColor = true;
       btnCancelar.Click += btnCancelar_Click;
// 
            // ModalFrm
    // 
  AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(333, 205);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
    Controls.Add(numericUpDown1);
        Controls.Add(label1);
   FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
  MinimizeBox = false;
            Name = "ModalFrm";
    StartPosition = FormStartPosition.CenterParent;
        Text = "Ajuste de Decimales";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
     ResumeLayout(false);
      PerformLayout();
      }

        #endregion

      private Label label1;
  private NumericUpDown numericUpDown1;
        private Button btnAceptar;
        private Button btnCancelar;
    }
}
