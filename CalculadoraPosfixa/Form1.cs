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
        PilhaLista<char> umaPilha = new PilhaLista<char>(); // Instancia a Pilha
        public calculadora()
        {
            InitializeComponent();

        }

        private void txtVisor_TextChanged(object sender, EventArgs e)
        {

            for (int i = 0; i < txtVisor.Text.Length; i++) //percorre todos os valores que estao no txtCodigo
            {
                char numero = txtVisor.Text[i]; //numero recebe o que foi digitado no txtCodigo
                if (char.IsLetter(numero) || "!@#$%&=".Contains(numero)) //se o que foi digitado no txtCodigo não seja numero
                {
                    MessageBox.Show("Digite um valor válido!(Sem letras e sem caracteres que não fazem uma operação matemática!)"); //um aviso será disparado
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                }
                else if (")]}.".Contains(txtVisor.Text.Substring(0, 1)))
                {
                    MessageBox.Show("Expressão iniciada de maneira incorreta");
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 2);
                }
            }
        }

        private void botoes_Click(object sender, EventArgs e)
        {
            //mostrar essa parte
            char letra = (sender as Button).Text[0];
            if (letra.ToString() == ".")
            {
                txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                txtVisor.Text += letra.ToString();
            }
            else
                txtVisor.Text += letra.ToString() + " ";
        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //mostrar essa parte
            //fazer precedencia
            char cadeiaVazia = ' ';

            if (txtVisor.Text != cadeiaVazia.ToString())
            {
                txtVisor.Text = txtVisor.Text.TrimEnd(cadeiaVazia);


                lbSequencias.Text = "";
                PilhaLista<string> operadores = new PilhaLista<string>();
                string expressao = txtVisor.Text;

                string[] values = expressao.Split(' ');

                char letra = 'A';

                //for (int j = 0; j < values.Length; j++)
                //{
                //    if ("1234567890.".Contains(values[j]))
                //    {
                //        MessageBox.Show(values[j].ToString());
                //        values[j] = letra++.ToString();
                //        MessageBox.Show(values[j].ToString());
                //    }
                //}

                lbSequencias.Text = "Infixa: ";
                int j = 0;
                foreach (var caracter in values)
                {

                    if (!"+-*/^()".Contains(values[j]))
                    {


                        MessageBox.Show(values[j].ToString());

                        lbSequencias.Text += letra.ToString();

                        values[j] = letra++.ToString();
                        MessageBox.Show(values[j].ToString());

                    }
                    else
                    {
                        lbSequencias.Text += values[j].ToString();

                        operadores.Empilhar(values[j]);
                    }

                    j++;
                }
                MessageBox.Show(values.Length.ToString());

                ConverterInfixaParaPosfixa(lbSequencias.Text);
                //foreach (var caracter in values)
                //{
                //    MessageBox.Show(caracter);
                //}
                //MessageBox.Show(values.Length.ToString());

                //for (int i = 0; i < values.Length; i++){
                //}
            }
            else
            {
                MessageBox.Show("Digite a expressão!");
                txtVisor.Focus();
            }
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtVisor.Clear();
            txtResultado.Clear();
            lbSequencias.Text = "Pósfixa ";
        }

        private void txtVisor_Leave(object sender, EventArgs e)
        {
            Balanceamento(txtVisor.Text);
        }
        /////CONVERTER DE INFIXA PARA POSFIXA

        bool EhOperador(char caracter)
        {
            return "+-^/*(".Contains(caracter);
        }
        public static int TerPrecedencia(char op)   // devolve a prioridade do operador
        {
            int p = 0;

            switch (op)
            {
                case '(': p = 1; break;
                
                case '^': p = 2; break;
                
                case '*':
                case '/': p = 3; break;
                
                case '+':
                case '-': p = 4; break;
            }

            return (p);
        }

        string ConverterInfixaParaPosfixa(string cadeiaLida)
        {
            string resultado = "";

            for (int indice = 0; indice < cadeiaLida.Length; indice++)
            {
                char simboloLido = cadeiaLida[indice];
                if (!EhOperador(simboloLido)) // not In [‘(‘,’)’,’+’,’-‘,’*’,’/’,’’] 
                    resultado += simboloLido; // escreve Operando na saída
                else // operador
                {
                    bool parar = false;
                    while (!parar && !umaPilha.EstaVazia &&
                    TerPrecedencia(umaPilha.OTopo()) <= TerPrecedencia(simboloLido))
                    {
                        char operadorComMaiorPrecedencia = umaPilha.Desempilhar();
                        if (operadorComMaiorPrecedencia != '(')
                            resultado += operadorComMaiorPrecedencia;
                        else
                            parar = true;
                    }
                    if (simboloLido != ')')
                        umaPilha.Empilhar(simboloLido);
                    else // fará isso QUANDO o Pilha[TOPO] = ‘(‘
                    {
                        char operadorComMaiorPrecedencia;
                        operadorComMaiorPrecedencia = umaPilha.Desempilhar();
                    }

                }
            } // for
            while (!umaPilha.EstaVazia) // Descarrega a Pilha Para a Saída
            {
                char operadorComMaiorPrecedencia;
                operadorComMaiorPrecedencia = umaPilha.Desempilhar();
                if (operadorComMaiorPrecedencia != '(')
                    resultado += operadorComMaiorPrecedencia;
            }
            txtResultado.Text = resultado.ToString();
            return resultado;
        }

        /////EXERCICIO DO CHICO SOBRE BALANCEAMENTO DE PARENTESES
        bool EhAbertura(char caracter)
        {
            return "{[(".Contains(caracter);
        }
        bool EhFechamento(char caracter)
        {
            return "}])".Contains(caracter);
        }

        bool Combinam(char anterior, char atual)
        {
            return anterior == '{' && atual == '}' ||
                   anterior == '(' && atual == ')' ||
                   anterior == '[' && atual == ']';
        }
        bool Balanceamento(string expressao)
        {
            if (expressao != "")
            {
                PilhaLista<char> pilha = new PilhaLista<char>(); //new PilhaVetor<char>(200);
                string cadeia = expressao;
                bool erro = false;
                for (int i = 0; i < cadeia.Length && !erro; i++)
                {
                    char caracterLido = cadeia[i];
                    if (EhAbertura(caracterLido))
                        pilha.Empilhar(caracterLido);
                    else if (!EhAbertura(caracterLido) && !EhFechamento(caracterLido))
                    {
                        i++;
                    }
                    else
                      if (EhFechamento(caracterLido))
                    {
                        char aberturaAnterior = ' ';
                        try
                        {
                            aberturaAnterior = pilha.Desempilhar();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("expressao nao balanceada!");
                            erro = true;
                        }
                        if (!Combinam(aberturaAnterior, caracterLido))
                        {
                            MessageBox.Show("expressao nao balanceada!");
                            erro = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("expressao nao balanceada!");
                        erro = true;
                    }
                }
                return true;
            }
            return false;
        }
    }
}