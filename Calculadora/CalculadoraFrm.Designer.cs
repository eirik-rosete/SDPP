namespace Calculadora
{
    partial class CalculadoraFrm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            Suma = new Button();
            Resta = new Button();
            Multiplicacion = new Button();
            Division = new Button();
            Porcentaje = new Button();
            ConversorMoneda = new Button();
            Borrar = new Button();
            Igual = new Button();
            MMas = new Button();
            MMenos = new Button();
            CM = new Button();
            RM = new Button();
            Divisa = new Label();
            menuStrip1 = new MenuStrip();
            opcionesToolStripMenuItem = new ToolStripMenuItem();
            ajusteDecimalesToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            textBox1.Location = new Point(47, 63);
            textBox1.Name = "textBox1";
            textBox1.ShortcutsEnabled = false;
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 0;
            textBox1.TextAlign = HorizontalAlignment.Right;
            textBox1.Enter += textBox1_Enter;
            textBox1.KeyPress += textBox1_KeyPress;
            textBox1.Leave += textBox1_Leave;
            // 
            // Suma
            // 
            Suma.AccessibleRole = AccessibleRole.PushButton;
            Suma.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Suma.Location = new Point(12, 110);
            Suma.Name = "Suma";
            Suma.Size = new Size(50, 40);
            Suma.TabIndex = 1;
            Suma.Text = "+";
            Suma.UseVisualStyleBackColor = true;
            Suma.Click += Suma_Click;
            // 
            // Resta
            // 
            Resta.AccessibleRole = AccessibleRole.PushButton;
            Resta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Resta.Location = new Point(68, 110);
            Resta.Name = "Resta";
            Resta.Size = new Size(50, 40);
            Resta.TabIndex = 2;
            Resta.Text = "-";
            Resta.UseVisualStyleBackColor = true;
            Resta.Click += Resta_Click;
            // 
            // Multiplicacion
            // 
            Multiplicacion.AccessibleRole = AccessibleRole.PushButton;
            Multiplicacion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Multiplicacion.Location = new Point(124, 110);
            Multiplicacion.Name = "Multiplicacion";
            Multiplicacion.Size = new Size(50, 40);
            Multiplicacion.TabIndex = 3;
            Multiplicacion.Text = "x";
            Multiplicacion.UseVisualStyleBackColor = true;
            Multiplicacion.Click += Multiplicacion_Click;
            // 
            // Division
            // 
            Division.AccessibleRole = AccessibleRole.PushButton;
            Division.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Division.Location = new Point(180, 110);
            Division.Name = "Division";
            Division.Size = new Size(50, 40);
            Division.TabIndex = 4;
            Division.Text = "/";
            Division.UseVisualStyleBackColor = true;
            Division.Click += Division_Click;
            // 
            // Porcentaje
            // 
            Porcentaje.AccessibleRole = AccessibleRole.PushButton;
            Porcentaje.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Porcentaje.Location = new Point(236, 110);
            Porcentaje.Name = "Porcentaje";
            Porcentaje.Size = new Size(50, 40);
            Porcentaje.TabIndex = 5;
            Porcentaje.Text = "%";
            Porcentaje.UseVisualStyleBackColor = true;
            Porcentaje.Click += Porcentaje_Click;
            // 
            // ConversorMoneda
            // 
            ConversorMoneda.AccessibleRole = AccessibleRole.PushButton;
            ConversorMoneda.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            ConversorMoneda.Location = new Point(12, 166);
            ConversorMoneda.Name = "ConversorMoneda";
            ConversorMoneda.Size = new Size(106, 40);
            ConversorMoneda.TabIndex = 6;
            ConversorMoneda.Text = "Pts/Euros";
            ConversorMoneda.UseVisualStyleBackColor = true;
            ConversorMoneda.Click += ConversorMoneda_Click;
            // 
            // Borrar
            // 
            Borrar.AccessibleRole = AccessibleRole.PushButton;
            Borrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Borrar.Location = new Point(124, 166);
            Borrar.Name = "Borrar";
            Borrar.Size = new Size(106, 40);
            Borrar.TabIndex = 7;
            Borrar.Text = "Borrar";
            Borrar.UseVisualStyleBackColor = true;
            Borrar.Click += Borrar_Click;
            // 
            // Igual
            // 
            Igual.AccessibleRole = AccessibleRole.PushButton;
            Igual.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Igual.Location = new Point(236, 166);
            Igual.Name = "Igual";
            Igual.Size = new Size(50, 40);
            Igual.TabIndex = 8;
            Igual.Text = "=";
            Igual.UseVisualStyleBackColor = true;
            Igual.Click += Igual_Click;
            // 
            // MMas
            // 
            MMas.AccessibleRole = AccessibleRole.PushButton;
            MMas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MMas.Location = new Point(12, 223);
            MMas.Name = "MMas";
            MMas.Size = new Size(64, 40);
            MMas.TabIndex = 9;
            MMas.Text = "M+";
            MMas.UseVisualStyleBackColor = true;
            MMas.Click += MMas_Click;
            // 
            // MMenos
            // 
            MMenos.AccessibleRole = AccessibleRole.PushButton;
            MMenos.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            MMenos.Location = new Point(82, 223);
            MMenos.Name = "MMenos";
            MMenos.Size = new Size(64, 40);
            MMenos.TabIndex = 10;
            MMenos.Text = "M-";
            MMenos.UseVisualStyleBackColor = true;
            MMenos.Click += MMenos_Click;
            // 
            // CM
            // 
            CM.AccessibleRole = AccessibleRole.PushButton;
            CM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            CM.Location = new Point(152, 223);
            CM.Name = "CM";
            CM.Size = new Size(64, 40);
            CM.TabIndex = 11;
            CM.Text = "CM";
            CM.UseVisualStyleBackColor = true;
            CM.Click += CM_Click;
            // 
            // RM
            // 
            RM.AccessibleRole = AccessibleRole.PushButton;
            RM.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            RM.Location = new Point(222, 223);
            RM.Name = "RM";
            RM.Size = new Size(64, 40);
            RM.TabIndex = 12;
            RM.Text = "RM";
            RM.UseVisualStyleBackColor = true;
            RM.Click += RM_Click;
            // 
            // Divisa
            // 
            Divisa.AutoSize = true;
            Divisa.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Divisa.Location = new Point(130, 36);
            Divisa.Name = "Divisa";
            Divisa.Size = new Size(19, 23);
            Divisa.TabIndex = 13;
            Divisa.Text = "€";
            Divisa.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { opcionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(299, 28);
            menuStrip1.TabIndex = 14;
            menuStrip1.Text = "menuStrip1";
            // 
            // opcionesToolStripMenuItem
            // 
            opcionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { ajusteDecimalesToolStripMenuItem });
            opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            opcionesToolStripMenuItem.Size = new Size(85, 24);
            opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // ajusteDecimalesToolStripMenuItem
            // 
            ajusteDecimalesToolStripMenuItem.Name = "ajusteDecimalesToolStripMenuItem";
            ajusteDecimalesToolStripMenuItem.Size = new Size(208, 26);
            ajusteDecimalesToolStripMenuItem.Text = "Ajuste Decimales";
            ajusteDecimalesToolStripMenuItem.Click += ajusteDecimalesToolStripMenuItem_Click;
            // 
            // CalculadoraFrm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 280);
            Controls.Add(Divisa);
            Controls.Add(RM);
            Controls.Add(CM);
            Controls.Add(MMenos);
            Controls.Add(MMas);
            Controls.Add(Igual);
            Controls.Add(Borrar);
            Controls.Add(ConversorMoneda);
            Controls.Add(Porcentaje);
            Controls.Add(Division);
            Controls.Add(Multiplicacion);
            Controls.Add(Resta);
            Controls.Add(Suma);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "CalculadoraFrm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button Suma;
        private Button Resta;
        private Button Multiplicacion;
        private Button Division;
        private Button Porcentaje;
        private Button ConversorMoneda;
        private Button Borrar;
        private Button Igual;
        private Button MMas;
        private Button MMenos;
        private Button CM;
        private Button RM;
        private Label Divisa;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem opcionesToolStripMenuItem;
        private ToolStripMenuItem ajusteDecimalesToolStripMenuItem;
    }
}
