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

                if (char.IsLetter(numero)) //se o que foi digitado no txtCodigo não seja numero
                {
                    MessageBox.Show("Digite um valor válido!(Sem letras e sem caracteres que não fazem uma operação matemática!)"); //um aviso será disparado
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                    txtVisor.Focus();
                }
            }
        }

        private void botoes_Click(object sender, EventArgs e)
        {
            char letra = (sender as Button).Text[0];
            txtVisor.Text += letra.ToString();
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
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
    }
}
