namespace calculadora
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
            this.forButton = new System.Windows.Forms.Button();
            this.whileButton = new System.Windows.Forms.Button();
            this.doWhileButton = new System.Windows.Forms.Button();
            this.forLabel = new System.Windows.Forms.Label();
            this.whileLabel = new System.Windows.Forms.Label();
            this.doWhileLabel = new System.Windows.Forms.Label();
            this.input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "TABUADA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número: ";
            // 
            // forButton
            // 
            this.forButton.Location = new System.Drawing.Point(24, 111);
            this.forButton.Name = "forButton";
            this.forButton.Size = new System.Drawing.Size(75, 23);
            this.forButton.TabIndex = 3;
            this.forButton.Text = "For";
            this.forButton.UseVisualStyleBackColor = true;
            this.forButton.Click += new System.EventHandler(this.forButton_Click);
            // 
            // whileButton
            // 
            this.whileButton.Location = new System.Drawing.Point(158, 111);
            this.whileButton.Name = "whileButton";
            this.whileButton.Size = new System.Drawing.Size(75, 23);
            this.whileButton.TabIndex = 4;
            this.whileButton.Text = "While";
            this.whileButton.UseVisualStyleBackColor = true;
            // 
            // doWhileButton
            // 
            this.doWhileButton.Location = new System.Drawing.Point(289, 111);
            this.doWhileButton.Name = "doWhileButton";
            this.doWhileButton.Size = new System.Drawing.Size(75, 23);
            this.doWhileButton.TabIndex = 5;
            this.doWhileButton.Text = "Do While";
            this.doWhileButton.UseVisualStyleBackColor = true;
            // 
            // forLabel
            // 
            this.forLabel.AutoSize = true;
            this.forLabel.Location = new System.Drawing.Point(21, 151);
            this.forLabel.Name = "forLabel";
            this.forLabel.Size = new System.Drawing.Size(0, 13);
            this.forLabel.TabIndex = 6;
            // 
            // whileLabel
            // 
            this.whileLabel.AutoSize = true;
            this.whileLabel.Location = new System.Drawing.Point(160, 151);
            this.whileLabel.Name = "whileLabel";
            this.whileLabel.Size = new System.Drawing.Size(0, 13);
            this.whileLabel.TabIndex = 7;
            // 
            // doWhileLabel
            // 
            this.doWhileLabel.AutoSize = true;
            this.doWhileLabel.Location = new System.Drawing.Point(286, 151);
            this.doWhileLabel.Name = "doWhileLabel";
            this.doWhileLabel.Size = new System.Drawing.Size(0, 13);
            this.doWhileLabel.TabIndex = 8;
            // 
            // input
            // 
            this.input.Location = new System.Drawing.Point(77, 60);
            this.input.Name = "input";
            this.input.Size = new System.Drawing.Size(100, 20);
            this.input.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 311);
            this.Controls.Add(this.input);
            this.Controls.Add(this.doWhileLabel);
            this.Controls.Add(this.whileLabel);
            this.Controls.Add(this.forLabel);
            this.Controls.Add(this.doWhileButton);
            this.Controls.Add(this.whileButton);
            this.Controls.Add(this.forButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button forButton;
        private System.Windows.Forms.Button whileButton;
        private System.Windows.Forms.Button doWhileButton;
        private System.Windows.Forms.Label forLabel;
        private System.Windows.Forms.Label whileLabel;
        private System.Windows.Forms.Label doWhileLabel;
        private System.Windows.Forms.TextBox input;
    }
}

