
namespace Prova_01
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
            this.labelTitulo = new System.Windows.Forms.Label();
            this.bntCalcular = new System.Windows.Forms.Button();
            this.labelCPF = new System.Windows.Forms.Label();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.labelMes = new System.Windows.Forms.Label();
            this.txtMes = new System.Windows.Forms.TextBox();
            this.labelDia = new System.Windows.Forms.Label();
            this.txtDia = new System.Windows.Forms.TextBox();
            this.labelGastos1 = new System.Windows.Forms.Label();
            this.txtGastosDia1 = new System.Windows.Forms.TextBox();
            this.labelGastos2 = new System.Windows.Forms.Label();
            this.txtGastosDia2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitulo.Location = new System.Drawing.Point(172, 26);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(113, 32);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Despesas";
            // 
            // bntCalcular
            // 
            this.bntCalcular.Location = new System.Drawing.Point(357, 298);
            this.bntCalcular.Name = "bntCalcular";
            this.bntCalcular.Size = new System.Drawing.Size(116, 54);
            this.bntCalcular.TabIndex = 1;
            this.bntCalcular.Text = "Clacular Despesas";
            this.bntCalcular.UseVisualStyleBackColor = true;
            this.bntCalcular.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCPF.Location = new System.Drawing.Point(57, 84);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(37, 21);
            this.labelCPF.TabIndex = 2;
            this.labelCPF.Text = "CPF";
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(148, 86);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(140, 23);
            this.txtCPF.TabIndex = 3;
            // 
            // labelMes
            // 
            this.labelMes.AutoSize = true;
            this.labelMes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMes.Location = new System.Drawing.Point(328, 153);
            this.labelMes.Name = "labelMes";
            this.labelMes.Size = new System.Drawing.Size(39, 21);
            this.labelMes.TabIndex = 4;
            this.labelMes.Text = "Mês";
            // 
            // txtMes
            // 
            this.txtMes.Location = new System.Drawing.Point(417, 155);
            this.txtMes.Name = "txtMes";
            this.txtMes.Size = new System.Drawing.Size(56, 23);
            this.txtMes.TabIndex = 5;
            // 
            // labelDia
            // 
            this.labelDia.AutoSize = true;
            this.labelDia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelDia.Location = new System.Drawing.Point(61, 153);
            this.labelDia.Name = "labelDia";
            this.labelDia.Size = new System.Drawing.Size(33, 21);
            this.labelDia.TabIndex = 6;
            this.labelDia.Text = "Dia";
            // 
            // txtDia
            // 
            this.txtDia.Location = new System.Drawing.Point(148, 155);
            this.txtDia.Name = "txtDia";
            this.txtDia.Size = new System.Drawing.Size(56, 23);
            this.txtDia.TabIndex = 7;
            // 
            // labelGastos1
            // 
            this.labelGastos1.AutoSize = true;
            this.labelGastos1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGastos1.Location = new System.Drawing.Point(57, 220);
            this.labelGastos1.Name = "labelGastos1";
            this.labelGastos1.Size = new System.Drawing.Size(66, 21);
            this.labelGastos1.TabIndex = 8;
            this.labelGastos1.Text = "Gastos1";
            // 
            // txtGastosDia1
            // 
            this.txtGastosDia1.Location = new System.Drawing.Point(148, 218);
            this.txtGastosDia1.Name = "txtGastosDia1";
            this.txtGastosDia1.Size = new System.Drawing.Size(100, 23);
            this.txtGastosDia1.TabIndex = 9;
            // 
            // labelGastos2
            // 
            this.labelGastos2.AutoSize = true;
            this.labelGastos2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelGastos2.Location = new System.Drawing.Point(417, 226);
            this.labelGastos2.Name = "labelGastos2";
            this.labelGastos2.Size = new System.Drawing.Size(66, 21);
            this.labelGastos2.TabIndex = 10;
            this.labelGastos2.Text = "Gastos2";
            // 
            // txtGastosDia2
            // 
            this.txtGastosDia2.Location = new System.Drawing.Point(540, 226);
            this.txtGastosDia2.Name = "txtGastosDia2";
            this.txtGastosDia2.Size = new System.Drawing.Size(100, 23);
            this.txtGastosDia2.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 450);
            this.Controls.Add(this.txtGastosDia2);
            this.Controls.Add(this.labelGastos2);
            this.Controls.Add(this.txtGastosDia1);
            this.Controls.Add(this.labelGastos1);
            this.Controls.Add(this.txtDia);
            this.Controls.Add(this.labelDia);
            this.Controls.Add(this.txtMes);
            this.Controls.Add(this.labelMes);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.bntCalcular);
            this.Controls.Add(this.labelTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Name = "Form1";
            this.Text = "Suas Despesas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Button bntCalcular;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label labelMes;
        private System.Windows.Forms.TextBox txtMes;
        private System.Windows.Forms.Label labelDia;
        private System.Windows.Forms.TextBox txtDia;
        private System.Windows.Forms.Label labelGastos1;
        private System.Windows.Forms.TextBox txtGastosDia1;
        private System.Windows.Forms.Label labelGastos2;
        private System.Windows.Forms.TextBox txtGastosDia2;
    }
}

