namespace Ej1
{
    partial class Form1
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
            groupBox1 = new GroupBox();
            btnRegistrarNumero = new Button();
            tbNumero = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lbMinimo = new Label();
            lbMaximo = new Label();
            groupBox2 = new GroupBox();
            btnActualizarMM = new Button();
            groupBox3 = new GroupBox();
            btnActualizarP = new Button();
            lbPromedio = new Label();
            label4 = new Label();
            groupBox4 = new GroupBox();
            btnActualizarI = new Button();
            lbCantidad = new Label();
            label6 = new Label();
            btnReiniciarVariables = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRegistrarNumero);
            groupBox1.Controls.Add(tbNumero);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(386, 153);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Procesar número";
            // 
            // btnRegistrarNumero
            // 
            btnRegistrarNumero.BackColor = SystemColors.ControlDark;
            btnRegistrarNumero.Location = new Point(72, 86);
            btnRegistrarNumero.Name = "btnRegistrarNumero";
            btnRegistrarNumero.Size = new Size(202, 44);
            btnRegistrarNumero.TabIndex = 2;
            btnRegistrarNumero.Text = "Registrar número";
            btnRegistrarNumero.UseVisualStyleBackColor = false;
            btnRegistrarNumero.Click += btnRegistrarNumero_Click;
            // 
            // tbNumero
            // 
            tbNumero.Location = new Point(207, 46);
            tbNumero.Name = "tbNumero";
            tbNumero.Size = new Size(155, 34);
            tbNumero.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(179, 28);
            label1.TabIndex = 0;
            label1.Text = "Ingrese un número:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 40);
            label2.Name = "label2";
            label2.Size = new Size(136, 28);
            label2.TabIndex = 1;
            label2.Text = "Valor máximo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 88);
            label3.Name = "label3";
            label3.Size = new Size(133, 28);
            label3.TabIndex = 2;
            label3.Text = "Valor mínimo:";
            // 
            // lbMinimo
            // 
            lbMinimo.AutoSize = true;
            lbMinimo.BackColor = SystemColors.ButtonHighlight;
            lbMinimo.Location = new Point(165, 88);
            lbMinimo.Name = "lbMinimo";
            lbMinimo.Size = new Size(65, 28);
            lbMinimo.TabIndex = 3;
            lbMinimo.Text = "label4";
            // 
            // lbMaximo
            // 
            lbMaximo.AutoSize = true;
            lbMaximo.BackColor = SystemColors.ButtonHighlight;
            lbMaximo.Location = new Point(165, 42);
            lbMaximo.Name = "lbMaximo";
            lbMaximo.Size = new Size(65, 28);
            lbMaximo.TabIndex = 4;
            lbMaximo.Text = "label5";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnActualizarMM);
            groupBox2.Controls.Add(lbMinimo);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(lbMaximo);
            groupBox2.Location = new Point(18, 183);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(407, 150);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Procesar máximo y mínimo";
            // 
            // btnActualizarMM
            // 
            btnActualizarMM.BackColor = SystemColors.ButtonShadow;
            btnActualizarMM.Location = new Point(260, 60);
            btnActualizarMM.Name = "btnActualizarMM";
            btnActualizarMM.Size = new Size(120, 47);
            btnActualizarMM.TabIndex = 5;
            btnActualizarMM.Text = "Actualizar";
            btnActualizarMM.UseVisualStyleBackColor = false;
            btnActualizarMM.Click += btnActualizarMM_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnActualizarP);
            groupBox3.Controls.Add(lbPromedio);
            groupBox3.Controls.Add(label4);
            groupBox3.Location = new Point(18, 355);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(407, 106);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Procesar promedio";
            // 
            // btnActualizarP
            // 
            btnActualizarP.BackColor = SystemColors.ButtonShadow;
            btnActualizarP.Location = new Point(260, 42);
            btnActualizarP.Name = "btnActualizarP";
            btnActualizarP.Size = new Size(120, 47);
            btnActualizarP.TabIndex = 8;
            btnActualizarP.Text = "Actualizar";
            btnActualizarP.UseVisualStyleBackColor = false;
            btnActualizarP.Click += btnActualizarP_Click;
            // 
            // lbPromedio
            // 
            lbPromedio.AutoSize = true;
            lbPromedio.BackColor = SystemColors.ButtonHighlight;
            lbPromedio.Location = new Point(165, 51);
            lbPromedio.Name = "lbPromedio";
            lbPromedio.Size = new Size(65, 28);
            lbPromedio.TabIndex = 7;
            lbPromedio.Text = "label5";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 51);
            label4.Name = "label4";
            label4.Size = new Size(102, 28);
            label4.TabIndex = 2;
            label4.Text = "Promedio:";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnActualizarI);
            groupBox4.Controls.Add(lbCantidad);
            groupBox4.Controls.Add(label6);
            groupBox4.Location = new Point(18, 481);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(407, 106);
            groupBox4.TabIndex = 7;
            groupBox4.TabStop = false;
            groupBox4.Text = "Mostrar cantidad de ingresados";
            // 
            // btnActualizarI
            // 
            btnActualizarI.BackColor = SystemColors.ButtonShadow;
            btnActualizarI.Location = new Point(260, 42);
            btnActualizarI.Name = "btnActualizarI";
            btnActualizarI.Size = new Size(120, 47);
            btnActualizarI.TabIndex = 8;
            btnActualizarI.Text = "Actualizar";
            btnActualizarI.UseVisualStyleBackColor = false;
            btnActualizarI.Click += btnActualizarI_Click;
            // 
            // lbCantidad
            // 
            lbCantidad.AutoSize = true;
            lbCantidad.BackColor = SystemColors.ButtonHighlight;
            lbCantidad.Location = new Point(165, 51);
            lbCantidad.Name = "lbCantidad";
            lbCantidad.Size = new Size(65, 28);
            lbCantidad.TabIndex = 7;
            lbCantidad.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(37, 51);
            label6.Name = "label6";
            label6.Size = new Size(95, 28);
            label6.TabIndex = 2;
            label6.Text = "Cantidad:";
            // 
            // btnReiniciarVariables
            // 
            btnReiniciarVariables.BackColor = SystemColors.ButtonShadow;
            btnReiniciarVariables.Location = new Point(470, 289);
            btnReiniciarVariables.Name = "btnReiniciarVariables";
            btnReiniciarVariables.Size = new Size(120, 77);
            btnReiniciarVariables.TabIndex = 8;
            btnReiniciarVariables.Text = "Reiniciar variables";
            btnReiniciarVariables.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 629);
            Controls.Add(btnReiniciarVariables);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Segoe UI", 12F);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox tbNumero;
        private Label label1;
        private Button btnRegistrarNumero;
        private Label label2;
        private Label label3;
        private Label lbMinimo;
        private Label lbMaximo;
        private GroupBox groupBox2;
        private Button btnActualizarMM;
        private GroupBox groupBox3;
        private Label label4;
        private Button btnActualizarP;
        private Label lbPromedio;
        private GroupBox groupBox4;
        private Button btnActualizarI;
        private Label lbCantidad;
        private Label label6;
        private Button btnReiniciarVariables;
    }
}
