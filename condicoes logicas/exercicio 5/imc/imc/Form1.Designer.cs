﻿namespace imc
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.altura = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.IMC = new System.Windows.Forms.Label();
            this.resultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CALCULAR IMC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altura:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Peso:";
            // 
            // altura
            // 
            this.altura.Location = new System.Drawing.Point(104, 92);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(209, 20);
            this.altura.TabIndex = 3;
            this.altura.TextChanged += new System.EventHandler(this.altura_TextChanged);
            // 
            // peso
            // 
            this.peso.Location = new System.Drawing.Point(104, 131);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(209, 20);
            this.peso.TabIndex = 4;
            this.peso.TextChanged += new System.EventHandler(this.peso_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "IMC:";
            // 
            // IMC
            // 
            this.IMC.AutoSize = true;
            this.IMC.Location = new System.Drawing.Point(68, 192);
            this.IMC.Name = "IMC";
            this.IMC.Size = new System.Drawing.Size(0, 13);
            this.IMC.TabIndex = 6;
            // 
            // resultado
            // 
            this.resultado.AutoSize = true;
            this.resultado.Location = new System.Drawing.Point(228, 192);
            this.resultado.Name = "resultado";
            this.resultado.Size = new System.Drawing.Size(0, 13);
            this.resultado.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 254);
            this.Controls.Add(this.resultado);
            this.Controls.Add(this.IMC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label IMC;
        private System.Windows.Forms.Label resultado;
    }
}

