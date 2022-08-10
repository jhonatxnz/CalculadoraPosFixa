using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraPosfixa
{
    public partial class calculadora : Form
    {
        public calculadora()
        {
            InitializeComponent();
        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < txtVisor.Text.Length; i++) //percorre todos os valores que estao no txtCodigo
            {
                char numero = txtVisor.Text[i]; //numero recebe o que foi digitado no txtCodigo

                if (char.IsLetter(numero) || "!@#$%&".Contains(numero)) //se o que foi digitado no txtCodigo não seja numero
                {
                    MessageBox.Show("Digite um valor válido!(Sem letras e sem caracteres que não fazem uma operação matemática!)"); //um aviso será disparado
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                }
                else if (")]".Contains(txtVisor.Text.Substring(0,1))) {
                    MessageBox.Show("Expressões iniciada de maneira incorreta");
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                }
            }
        }

        private void botoes_Click(object sender, EventArgs e)        {
            char letra = (sender as Button).Text[0];
            txtVisor.Text += letra.ToString();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (txtVisor.Text != "")
            {
                string expressao = txtVisor.Text;
                string[] valores = new string[] { txtVisor.Text};
                PilhaLista<char> pilhaExpressoes = new PilhaLista<char>();
                MessageBox.Show(valores[0]);
                
            }
            else {
                MessageBox.Show("Digite a expressão!");
                txtVisor.Focus();
            }


            double resultado = 1;
            txtResultado.Text = resultado.ToString(); ;
            lbSequencias.Text = "A sequência...";
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Pósfixa ";
        }

        private void txtVisor_Leave(object sender, EventArgs e)
        {
            PilhaLista<char> pilha = new PilhaLista<char>();
            string expressao = txtVisor.Text;
            //BALANCEAMENTO DE PARENTESES
        }
    }
}
