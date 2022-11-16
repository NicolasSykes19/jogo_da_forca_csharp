using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jogo_da_forca_csharp
{
    public partial class Form1 : Form
    {
        string palavra;
        char[] palEscondida, tentativas;
        char letra;
        int count = 0, count2 = 0, countErros = 0, vidas = 4;

        public Form1()
        {
            InitializeComponent();

            //Tratamento das variáveis
            #region
            //Zera a palavra e as tentativas
            lbPalavraEscolhida.Text = "";
            lbTentativas.Text = "";

            //Some com a forca
            pictureBox2.Visible = false;
            pbTronco.Visible = false;
            pbBracos.Visible = false;
            pbPerna.Visible = false;
            
            //atualiza a quantidade de vidas
            lbVidas.Text = vidas.ToString();
            #endregion
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if (tbPalavra.Text != "")
            {
                //Tratamento das variáveis
                #region
                palavra = tbPalavra.Text.ToLower();
                tentativas = new char[palavra.Length + 4]; //cria um vetor para armazenar a quantidade de letras ja digitadas

                //Cria um vetor palEscondida do tamanho da palavra e armazena '*'
                palEscondida = new char[palavra.Length];
                for (int i = 0; i < palavra.Length; i++)
                {
                    palEscondida[i] = '*';
                    lbPalavraEscolhida.Text += palEscondida[i];
                }
                #endregion

                //Formatação das caixas de texto
                #region
                //Habilita a caixa de digitação da palavra
                tbPalavra.Text = "";
                tbPalavra.Enabled = false;
                btIniciar.Enabled = false;

                //Habilita a caixa de digitação da letra
                mbLetra.Enabled = true;
                btOk.Enabled = true;
                mbLetra.Focus();
                #endregion
            }
            tbPalavra.Focus();
        }

        private void btOk_Click(object sender, EventArgs e)
        {
            //Chama a função do jogo em sí
            if (mbLetra.Text != "") { Jogo(); }

            mbLetra.Focus();
        }

        private void Jogo()
        {
            bool jaDigitou = false, temLetra = false;

            letra = mbLetra.Text[0]; 
            
            //Verificações na palavra
            #region
            //Verifica se a letra ja foi digitada
            for (int i = 0; i < tentativas.Length; i++)
            {
                if (letra == tentativas[i])
                {
                    jaDigitou = true;
                }
            }

            //Verifica se a letra tem na palavra
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letra == palavra[i])
                {
                    palEscondida[i] = letra;
                    temLetra = true;
                }
            }

            //Ajusta a caixa de texto
            mbLetra.Text = "";
            mbLetra.Focus();
            #endregion

            //Tratamento das letras
            #region
            //se o usuário ja digitou a letra
            if (jaDigitou) { MessageBox.Show("Você ja digitou essa letra!"); mbLetra.Text = ""; mbLetra.Focus(); }

            //se o usuário ainda não digitou a letra
            else { tentativas[count] = letra; lbTentativas.Text += letra + " - "; count++; }

            //se o usuário não digitou a letra porém ela não tem na palavra
            if (!temLetra & !(jaDigitou))
            {
                MessageBox.Show("Não tem essa letra na palavra!");
                countErros++;
                vidas--;
                lbVidas.Text = vidas.ToString();
                mbLetra.Text = ""; 
                mbLetra.Focus();
            }
            #endregion

            //Faz aparecer a forca com base na quantidade de erros
            #region
            if (countErros == 1) { pictureBox2.Visible = true; }
            if (countErros == 2) { pbTronco.Visible = true; }
            if (countErros == 3) { pbBracos.Visible = true; }
            if (countErros == 4) { pbPerna.Visible = true; }
            #endregion

            //Reescreve a palavra com as letras
            #region
            lbPalavraEscolhida.Text = "";
            for (int i = 0; i < palavra.Length; i++)
            {
                lbPalavraEscolhida.Text += palEscondida[i];
            }
            #endregion

            //Verifica se o jogador ganhou ou não
            #region
            if (vidas == 0) { Perdeu(); }
            if (lbPalavraEscolhida.Text == palavra) { Ganhou(); }
            #endregion

        }
        private void Perdeu()
        {
            MessageBox.Show("Você perdeu!");
            Reset();
        }
        private void Ganhou()
        {
            MessageBox.Show("Você Ganhou!");
            Reset();
        }
        private void Reset()
        {
            //reseta as variáveis
            vidas = 4;
            count = 0;
            countErros = 0;
            lbPalavraEscolhida.Text = "";
            lbTentativas.Text = "";
            lbVidas.Text = vidas.ToString();

            //Habilita as caixas de texto
            tbPalavra.Enabled = true;
            mbLetra.Enabled = false;
            btIniciar.Enabled = true;
            btOk.Enabled = false;
            pictureBox2.Visible = false;
            pbTronco.Visible = false;
            pbBracos.Visible = false;
            pbPerna.Visible = false;
            tbPalavra.Focus();
        }
    }
}
