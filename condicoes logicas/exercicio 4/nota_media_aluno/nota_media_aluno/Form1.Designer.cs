namespace nota_media_aluno
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nome = new System.Windows.Forms.TextBox();
            this.nota1 = new System.Windows.Forms.TextBox();
            this.nota2 = new System.Windows.Forms.TextBox();
            this.nota3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nomeLabel = new System.Windows.Forms.Label();
            this.media = new System.Windows.Forms.Label();
            this.mencao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "NOTA MÉDIA DO ALUNO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nota 1:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nota 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nota 3:";
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(78, 79);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(213, 20);
            this.nome.TabIndex = 5;
            this.nome.TextChanged += new System.EventHandler(this.nome_TextChanged);
            // 
            // nota1
            // 
            this.nota1.Location = new System.Drawing.Point(78, 109);
            this.nota1.Name = "nota1";
            this.nota1.Size = new System.Drawing.Size(213, 20);
            this.nota1.TabIndex = 6;
            this.nota1.TextChanged += new System.EventHandler(this.nota1_TextChanged);
            // 
            // nota2
            // 
            this.nota2.Location = new System.Drawing.Point(78, 140);
            this.nota2.Name = "nota2";
            this.nota2.Size = new System.Drawing.Size(213, 20);
            this.nota2.TabIndex = 7;
            this.nota2.TextChanged += new System.EventHandler(this.nota2_TextChanged);
            // 
            // nota3
            // 
            this.nota3.Location = new System.Drawing.Point(78, 170);
            this.nota3.Name = "nota3";
            this.nota3.Size = new System.Drawing.Size(213, 20);
            this.nota3.TabIndex = 8;
            this.nota3.TextChanged += new System.EventHandler(this.nota3_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Nome:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 252);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Média:";
            // 
            // nomeLabel
            // 
            this.nomeLabel.AutoSize = true;
            this.nomeLabel.Location = new System.Drawing.Point(75, 218);
            this.nomeLabel.Name = "nomeLabel";
            this.nomeLabel.Size = new System.Drawing.Size(0, 13);
            this.nomeLabel.TabIndex = 11;
            // 
            // media
            // 
            this.media.AutoSize = true;
            this.media.Location = new System.Drawing.Point(75, 252);
            this.media.Name = "media";
            this.media.Size = new System.Drawing.Size(0, 13);
            this.media.TabIndex = 12;
            // 
            // mencao
            // 
            this.mencao.AutoSize = true;
            this.mencao.Location = new System.Drawing.Point(210, 252);
            this.mencao.Name = "mencao";
            this.mencao.Size = new System.Drawing.Size(0, 13);
            this.mencao.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 303);
            this.Controls.Add(this.mencao);
            this.Controls.Add(this.media);
            this.Controls.Add(this.nomeLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nota3);
            this.Controls.Add(this.nota2);
            this.Controls.Add(this.nota1);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
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
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox nota1;
        private System.Windows.Forms.TextBox nota2;
        private System.Windows.Forms.TextBox nota3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label nomeLabel;
        private System.Windows.Forms.Label media;
        private System.Windows.Forms.Label mencao;
    }
}

