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
            this.rb256 = new System.Windows.Forms.RadioButton();
            this.rb192 = new System.Windows.Forms.RadioButton();
            this.rb128 = new System.Windows.Forms.RadioButton();
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
            this.panel2.Size = new System.Drawing.Size(534, 309);
            this.panel2.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "64 bits";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb256);
            this.groupBox1.Controls.Add(this.rb192);
            this.groupBox1.Controls.Add(this.rb128);
            this.groupBox1.Location = new System.Drawing.Point(419, 117);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 72);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Block/Key size";
            // 
            // rb256
            // 
            this.rb256.AutoSize = true;
            this.rb256.Location = new System.Drawing.Point(6, 48);
            this.rb256.Name = "rb256";
            this.rb256.Size = new System.Drawing.Size(66, 17);
            this.rb256.TabIndex = 9;
            this.rb256.Text = "128/256";
            this.rb256.UseVisualStyleBackColor = true;
            this.rb256.Click += new System.EventHandler(this.rb128_Click);
            // 
            // rb192
            // 
            this.rb192.AutoSize = true;
            this.rb192.Location = new System.Drawing.Point(6, 33);
            this.rb192.Name = "rb192";
            this.rb192.Size = new System.Drawing.Size(66, 17);
            this.rb192.TabIndex = 8;
            this.rb192.Text = "128/192";
            this.rb192.UseVisualStyleBackColor = true;
            this.rb192.Click += new System.EventHandler(this.rb128_Click);
            // 
            // rb128
            // 
            this.rb128.AutoSize = true;
            this.rb128.Location = new System.Drawing.Point(6, 18);
            this.rb128.Name = "rb128";
            this.rb128.Size = new System.Drawing.Size(66, 17);
            this.rb128.TabIndex = 7;
            this.rb128.Text = "128/128";
            this.rb128.UseVisualStyleBackColor = true;
            this.rb128.Click += new System.EventHandler(this.rb128_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Key";
            // 
            // tbKey
            // 
            this.tbKey.Location = new System.Drawing.Point(6, 135);
            this.tbKey.MaxLength = 64;
            this.tbKey.Name = "tbKey";
            this.tbKey.Size = new System.Drawing.Size(265, 20);
            this.tbKey.TabIndex = 10;
            // 
            // btnCifrar
            // 
            this.btnCifrar.Location = new System.Drawing.Point(6, 162);
            this.btnCifrar.Name = "btnCifrar";
            this.btnCifrar.Size = new System.Drawing.Size(75, 23);
            this.btnCifrar.TabIndex = 1;
            this.btnCifrar.Text = "Cifrar";
            this.btnCifrar.UseVisualStyleBackColor = true;
            this.btnCifrar.Click += new System.EventHandler(this.btnCifrar_Click);
            // 
            // btnDesc
            // 
            this.btnDesc.Location = new System.Drawing.Point(87, 161);
            this.btnDesc.Name = "btnDesc";
            this.btnDesc.Size = new System.Drawing.Size(75, 23);
            this.btnDesc.TabIndex = 9;
            this.btnDesc.Text = "Descifrar";
            this.btnDesc.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Salida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Entrada";
            // 
            // tbSalida
            // 
            this.tbSalida.Location = new System.Drawing.Point(3, 207);
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
            this.ClientSize = new System.Drawing.Size(560, 332);
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
        private System.Windows.Forms.RadioButton rb256;
        private System.Windows.Forms.RadioButton rb192;
        private System.Windows.Forms.RadioButton rb128;
    }
}