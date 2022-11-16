namespace jogo_da_forca_csharp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbPalavraEscolhida = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbTentativas = new System.Windows.Forms.Label();
            this.tbPalavra = new System.Windows.Forms.TextBox();
            this.mbLetra = new System.Windows.Forms.MaskedTextBox();
            this.btIniciar = new System.Windows.Forms.Button();
            this.btOk = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pbTronco = new System.Windows.Forms.PictureBox();
            this.pbBracos = new System.Windows.Forms.PictureBox();
            this.pbPerna = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lbVidas = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTronco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerna)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(202, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "*JOGO DA FORCA*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Digite a letra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(12, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Digite a palavra:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(104, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Palavra escolhida:";
            // 
            // lbPalavraEscolhida
            // 
            this.lbPalavraEscolhida.AutoSize = true;
            this.lbPalavraEscolhida.Location = new System.Drawing.Point(119, 232);
            this.lbPalavraEscolhida.Name = "lbPalavraEscolhida";
            this.lbPalavraEscolhida.Size = new System.Drawing.Size(12, 15);
            this.lbPalavraEscolhida.TabIndex = 4;
            this.lbPalavraEscolhida.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(12, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Letras digitadas:";
            // 
            // lbTentativas
            // 
            this.lbTentativas.AutoSize = true;
            this.lbTentativas.Location = new System.Drawing.Point(114, 265);
            this.lbTentativas.Name = "lbTentativas";
            this.lbTentativas.Size = new System.Drawing.Size(27, 15);
            this.lbTentativas.TabIndex = 6;
            this.lbTentativas.Text = "____";
            // 
            // tbPalavra
            // 
            this.tbPalavra.Location = new System.Drawing.Point(13, 87);
            this.tbPalavra.Name = "tbPalavra";
            this.tbPalavra.PasswordChar = '*';
            this.tbPalavra.Size = new System.Drawing.Size(100, 23);
            this.tbPalavra.TabIndex = 7;
            // 
            // mbLetra
            // 
            this.mbLetra.Enabled = false;
            this.mbLetra.Location = new System.Drawing.Point(13, 163);
            this.mbLetra.Mask = "a";
            this.mbLetra.Name = "mbLetra";
            this.mbLetra.Size = new System.Drawing.Size(100, 23);
            this.mbLetra.TabIndex = 8;
            // 
            // btIniciar
            // 
            this.btIniciar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btIniciar.Location = new System.Drawing.Point(119, 86);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(75, 23);
            this.btIniciar.TabIndex = 9;
            this.btIniciar.Text = "Iniciar";
            this.btIniciar.UseVisualStyleBackColor = false;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // btOk
            // 
            this.btOk.Enabled = false;
            this.btOk.Location = new System.Drawing.Point(119, 162);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 10;
            this.btOk.Text = "Ok";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::jogo_da_forca_csharp.Properties.Resources.forca1;
            this.pictureBox1.Location = new System.Drawing.Point(315, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::jogo_da_forca_csharp.Properties.Resources.forca2;
            this.pictureBox2.Location = new System.Drawing.Point(410, 87);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pbTronco
            // 
            this.pbTronco.Image = global::jogo_da_forca_csharp.Properties.Resources.membrosforca;
            this.pbTronco.Location = new System.Drawing.Point(448, 140);
            this.pbTronco.Name = "pbTronco";
            this.pbTronco.Size = new System.Drawing.Size(10, 82);
            this.pbTronco.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTronco.TabIndex = 13;
            this.pbTronco.TabStop = false;
            // 
            // pbBracos
            // 
            this.pbBracos.Image = global::jogo_da_forca_csharp.Properties.Resources.membrosforca;
            this.pbBracos.Location = new System.Drawing.Point(410, 150);
            this.pbBracos.Name = "pbBracos";
            this.pbBracos.Size = new System.Drawing.Size(95, 10);
            this.pbBracos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBracos.TabIndex = 14;
            this.pbBracos.TabStop = false;
            // 
            // pbPerna
            // 
            this.pbPerna.Image = global::jogo_da_forca_csharp.Properties.Resources.pernaforca;
            this.pbPerna.Location = new System.Drawing.Point(405, 214);
            this.pbPerna.Name = "pbPerna";
            this.pbPerna.Size = new System.Drawing.Size(100, 50);
            this.pbPerna.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPerna.TabIndex = 15;
            this.pbPerna.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(13, 298);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 15);
            this.label8.TabIndex = 16;
            this.label8.Text = "Vidas:";
            // 
            // lbVidas
            // 
            this.lbVidas.AutoSize = true;
            this.lbVidas.Location = new System.Drawing.Point(49, 298);
            this.lbVidas.Name = "lbVidas";
            this.lbVidas.Size = new System.Drawing.Size(13, 15);
            this.lbVidas.TabIndex = 17;
            this.lbVidas.Text = "5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(534, 328);
            this.Controls.Add(this.lbVidas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pbPerna);
            this.Controls.Add(this.pbBracos);
            this.Controls.Add(this.pbTronco);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.mbLetra);
            this.Controls.Add(this.tbPalavra);
            this.Controls.Add(this.lbTentativas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbPalavraEscolhida);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTronco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBracos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerna)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbPalavraEscolhida;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbTentativas;
        private System.Windows.Forms.TextBox tbPalavra;
        private System.Windows.Forms.MaskedTextBox mbLetra;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pbTronco;
        private System.Windows.Forms.PictureBox pbBracos;
        private System.Windows.Forms.PictureBox pbPerna;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbVidas;
    }
}
