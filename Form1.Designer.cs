
namespace RSA_Luis
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtP = new System.Windows.Forms.TextBox();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBN = new System.Windows.Forms.Label();
            this.LBZ = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtE = new System.Windows.Forms.TextBox();
            this.LBMDC = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.LB_ModZ1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnChaves = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTexto = new System.Windows.Forms.TextBox();
            this.txtCripto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDescripto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Btnchar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtGrande = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDigitos = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "P =";
            // 
            // txtP
            // 
            this.txtP.Location = new System.Drawing.Point(49, 13);
            this.txtP.Margin = new System.Windows.Forms.Padding(4);
            this.txtP.Name = "txtP";
            this.txtP.Size = new System.Drawing.Size(34, 23);
            this.txtP.TabIndex = 2;
            this.txtP.Text = "17";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(128, 13);
            this.txtQ.Margin = new System.Windows.Forms.Padding(4);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(34, 23);
            this.txtQ.TabIndex = 4;
            this.txtQ.Text = "41";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 16);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Q =";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 16);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "N =";
            // 
            // LBN
            // 
            this.LBN.AutoSize = true;
            this.LBN.BackColor = System.Drawing.Color.Yellow;
            this.LBN.Location = new System.Drawing.Point(201, 15);
            this.LBN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBN.Name = "LBN";
            this.LBN.Size = new System.Drawing.Size(32, 17);
            this.LBN.TabIndex = 6;
            this.LBN.Text = "___";
            // 
            // LBZ
            // 
            this.LBZ.AutoSize = true;
            this.LBZ.BackColor = System.Drawing.Color.Yellow;
            this.LBZ.Location = new System.Drawing.Point(274, 16);
            this.LBZ.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBZ.Name = "LBZ";
            this.LBZ.Size = new System.Drawing.Size(32, 17);
            this.LBZ.TabIndex = 8;
            this.LBZ.Text = "___";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(246, 16);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Z =";
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(183, 49);
            this.txtE.Margin = new System.Windows.Forms.Padding(4);
            this.txtE.Name = "txtE";
            this.txtE.Size = new System.Drawing.Size(38, 23);
            this.txtE.TabIndex = 27;
            this.txtE.Text = "23";
            // 
            // LBMDC
            // 
            this.LBMDC.AutoSize = true;
            this.LBMDC.BackColor = System.Drawing.Color.Yellow;
            this.LBMDC.Location = new System.Drawing.Point(363, 52);
            this.LBMDC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LBMDC.Name = "LBMDC";
            this.LBMDC.Size = new System.Drawing.Size(16, 17);
            this.LBMDC.TabIndex = 28;
            this.LBMDC.Text = "_";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 17);
            this.label10.TabIndex = 32;
            this.label10.Text = "D =";
            // 
            // LB_ModZ1
            // 
            this.LB_ModZ1.AutoSize = true;
            this.LB_ModZ1.BackColor = System.Drawing.Color.Yellow;
            this.LB_ModZ1.Location = new System.Drawing.Point(361, 16);
            this.LB_ModZ1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LB_ModZ1.Name = "LB_ModZ1";
            this.LB_ModZ1.Size = new System.Drawing.Size(32, 17);
            this.LB_ModZ1.TabIndex = 31;
            this.LB_ModZ1.Text = "___";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 17);
            this.label4.TabIndex = 33;
            this.label4.Text = "Numeros Primos para E:";
            // 
            // btnChaves
            // 
            this.btnChaves.Location = new System.Drawing.Point(421, 16);
            this.btnChaves.Margin = new System.Windows.Forms.Padding(4);
            this.btnChaves.Name = "btnChaves";
            this.btnChaves.Size = new System.Drawing.Size(115, 25);
            this.btnChaves.TabIndex = 34;
            this.btnChaves.Text = "Gerar Chaves";
            this.btnChaves.UseVisualStyleBackColor = true;
            this.btnChaves.Click += new System.EventHandler(this.btnChaves_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(229, 52);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 17);
            this.label5.TabIndex = 35;
            this.label5.Text = "(E*D) modZ == 1 ?";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 84);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Numero ASCII :";
            // 
            // txtTexto
            // 
            this.txtTexto.Location = new System.Drawing.Point(121, 84);
            this.txtTexto.Margin = new System.Windows.Forms.Padding(4);
            this.txtTexto.Name = "txtTexto";
            this.txtTexto.Size = new System.Drawing.Size(38, 23);
            this.txtTexto.TabIndex = 37;
            this.txtTexto.Text = "101";
            // 
            // txtCripto
            // 
            this.txtCripto.Location = new System.Drawing.Point(315, 84);
            this.txtCripto.Margin = new System.Windows.Forms.Padding(4);
            this.txtCripto.Name = "txtCripto";
            this.txtCripto.Size = new System.Drawing.Size(89, 23);
            this.txtCripto.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(168, 84);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(139, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "ASCII Criptografado :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 119);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(162, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "ASCII Descriptografado :";
            // 
            // txtDescripto
            // 
            this.txtDescripto.Location = new System.Drawing.Point(185, 116);
            this.txtDescripto.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescripto.Name = "txtDescripto";
            this.txtDescripto.Size = new System.Drawing.Size(38, 23);
            this.txtDescripto.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 115);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 25);
            this.button1.TabIndex = 42;
            this.button1.Text = "Cript / Desc - ASCII";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 240);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(296, 23);
            this.textBox1.TabIndex = 43;
            this.textBox1.Text = "Teste  de Criptografia em 25/04/2021";
            // 
            // Btnchar
            // 
            this.Btnchar.Location = new System.Drawing.Point(326, 240);
            this.Btnchar.Name = "Btnchar";
            this.Btnchar.Size = new System.Drawing.Size(144, 43);
            this.Btnchar.TabIndex = 45;
            this.Btnchar.Text = "Crip/Descrip - frase";
            this.Btnchar.UseVisualStyleBackColor = true;
            this.Btnchar.Click += new System.EventHandler(this.Btnchar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 270);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(296, 67);
            this.richTextBox1.TabIndex = 47;
            this.richTextBox1.Text = "";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(16, 356);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(296, 23);
            this.textBox2.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 150);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = "Valor ASCII ^ E =";
            // 
            // txtGrande
            // 
            this.txtGrande.Location = new System.Drawing.Point(135, 147);
            this.txtGrande.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrande.Name = "txtGrande";
            this.txtGrande.Size = new System.Drawing.Size(469, 23);
            this.txtGrande.TabIndex = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(13, 180);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = "Quantidade de dígitos :";
            // 
            // txtDigitos
            // 
            this.txtDigitos.Location = new System.Drawing.Point(176, 177);
            this.txtDigitos.Margin = new System.Windows.Forms.Padding(4);
            this.txtDigitos.Name = "txtDigitos";
            this.txtDigitos.Size = new System.Drawing.Size(38, 23);
            this.txtDigitos.TabIndex = 52;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(617, 408);
            this.Controls.Add(this.txtDigitos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtGrande);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.Btnchar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtDescripto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtCripto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTexto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnChaves);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.LB_ModZ1);
            this.Controls.Add(this.LBMDC);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.LBZ);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtP);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criptografia RSA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtP;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBN;
        private System.Windows.Forms.Label LBZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.Label LBMDC;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LB_ModZ1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnChaves;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTexto;
        private System.Windows.Forms.TextBox txtCripto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDescripto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Btnchar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtGrande;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtDigitos;
    }
}

