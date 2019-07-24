namespace SimonCipher
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb10 = new System.Windows.Forms.RadioButton();
            this.rb9 = new System.Windows.Forms.RadioButton();
            this.rb8 = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKey = new System.Windows.Forms.TextBox();
            this.btnCifrar = new System.Windows.Forms.Button();
            this.btnDesc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSalida = new System.Windows.Forms.TextBox();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.tbKey);
            this.panel2.Controls.Add(this.btnCifrar);
            this.panel2.Controls.Add(this.btnDesc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbSalida);
            this.panel2.Controls.Add(this.tbEntrada);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(540, 381);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "64 bits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb10);
            this.groupBox1.Controls.Add(this.rb9);
            this.groupBox1.Controls.Add(this.rb8);
            this.groupBox1.Location = new System.Drawing.Point(418, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(107, 116);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block/Key size";
            // 
            // rb10
            // 
            this.rb10.AutoSize = true;
            this.rb10.Location = new System.Drawing.Point(6, 57);
            this.rb10.Name = "rb10";
            this.rb10.Size = new System.Drawing.Size(66, 17);
            this.rb10.TabIndex = 9;
            this.rb10.Text = "128/256";
            this.rb10.UseVisualStyleBackColor = true;
            this.rb10.Click += new System.EventHandler(this.rb10_Click);
            // 
            // rb9
            // 
            this.rb9.AutoSize = true;
            this.rb9.Location = new System.Drawing.Point(6, 38);
            this.rb9.Name = "rb9";
            this.rb9.Size = new System.Drawing.Size(66, 17);
            this.rb9.TabIndex = 8;
            this.rb9.Text = "128/192";
            this.rb9.UseVisualStyleBackColor = true;
            this.rb9.Click += new System.EventHandler(this.rb10_Click);
            // 
            // rb8
            // 
            this.rb8.AutoSize = true;
            this.rb8.Location = new System.Drawing.Point(6, 19);
            this.rb8.Name = "rb8";
            this.rb8.Size = new System.Drawing.Size(66, 17);
            this.rb8.TabIndex = 7;
            this.rb8.Text = "128/128";
            this.rb8.UseVisualStyleBackColor = true;
            this.rb8.Click += new System.EventHandler(this.rb10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(6, 153);
            this.tbKey.MaxLength = 64;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(391, 20);
            this.tbKey.TabIndex = 10;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(6, 210);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 1;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(87, 210);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 9;
            this.btnDesc.Text = "Descifrar";
            this.btnDesc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrada";
            // 
            // tbSalida
            // 
            this.tbSalida.Location = new System.Drawing.Point(6, 252);
            this.tbSalida.Multiline = true;
            this.tbSalida.Name = "tbSalida";
            this.tbSalida.Size = new System.Drawing.Size(522, 82);
            this.tbSalida.TabIndex = 6;
            // 
            // tbEntrada
            // 
            this.tbEntrada.Location = new System.Drawing.Point(3, 24);
            this.tbEntrada.Multiline = true;
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(522, 87);
            this.tbEntrada.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Simon Cipher";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSalida;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKey;
        private System.Windows.Forms.Button btnCifrar;
        private System.Windows.Forms.Button btnDesc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rb10;
        private System.Windows.Forms.RadioButton rb9;
        private System.Windows.Forms.RadioButton rb8;
    }
}