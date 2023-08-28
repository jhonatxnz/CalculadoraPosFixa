using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//dbasbdahs
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
                    txtVisor.Text = txtVisor.Text.Substring(0, txtVisor.Text.Length - 1);
                }
            }
        }

        private void botoes_Click(object sender, EventArgs e)
        {
            //mostrar essa parte
            char letra = (sender as Button).Text[0];
            txtVisor.Text += letra.ToString(); 
        }
        private void botoesOperadores_Click(object sender, EventArgs e)
        {
            char operador = (sender as Button).Text[0];
            txtVisor.Text += " " + operador + " "; 

        }
        private void btnIgual_Click(object sender, EventArgs e)
        {
            char cadeiaVazia = ' ';

            if (txtVisor.Text != cadeiaVazia.ToString())
            {
                if (!Balanceamento(txtVisor.Text)) {
                    lbSequencias.Text = " ";
                }

                txtVisor.Text = txtVisor.Text.TrimEnd(cadeiaVazia);
                lbSequencias.Text = "";
                PilhaLista<string> operadores = new PilhaLista<string>();
                string expressao = txtVisor.Text;

                string[] values = expressao.Split(' ');
                
                char letra = 'A';

                //for(int i =0;i< values.Length; i++)
                //{
                //    ConverterInfixaParaPosfixa(values[i]);
                //}

                txtResultado.Text = ConverterInfixaParaPosfixa(expressao);
                MessageBox.Show(values[1]);

                int j = 0;

                foreach (var caracter in values)
                {
                    if (!"+-*/^()".Contains(values[j]))
                    {
                        lbSequencias.Text += letra.ToString();
                        values[j] = letra++.ToString();
                    }
                    else
                    {
                        lbSequencias.Text += values[j].ToString();
                        operadores.Empilhar(values[j]);
                    }
                    j++;
                }
                
                lbSequencias.Text += "------------" + ConverterInfixaParaPosfixa(lbSequencias.Text).ToString();
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
            lbSequencias.Text = "Infixa - Pósfixa";
        }

        private void txtVisor_Leave(object sender, EventArgs e)
        {
            
        }
        /////CONVERTER DE INFIXA PARA POSFIXA

        bool EhOperador(char caracter)
        {
            return "+-^/*()".Contains(caracter);
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

                case ')': p = 5; break;
            }

            return (p);
        }

        ///CONVERTER DE INFIXA PARA POSFIXA
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
                        {
                            umaPilha.Empilhar(operadorComMaiorPrecedencia);
                            parar = true;

                        }
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
            return resultado;
        }
        ///CALCULA EXPRESSAO POSFIXA
        
        double ValorDaSubExpressao(double op, char simbolo, double op2)
        {
            double resultado = 0;
            switch (simbolo)
            {
                case '^': resultado = Math.Pow(op,op2);
                    break;

                case '*': resultado = op * op2;
                    break;

                case '/': resultado = op / op2;
                    break;

                case '+': resultado = op + op2;
                    break;

                case '-': resultado = op - op2;
                    break;
            }
            return resultado;
        }
        //double ValorDaExpressaoPosfixa(string cadeiaPosfixa)
        //{
            
        //    PilhaLista<double> umaPilha = new PilhaLista<double>();
        //    for (int atual = 0; atual < cadeiaPosfixa.Length; atual++)
        //    {
        //        char simbolo = cadeiaPosfixa[atual];
        //        if (!EhOperador(simbolo)) // É Operando 
        //            umaPilha.Empilhar(ValorDe[simbolo - 'A']);
        //        else
        //        {
        //            double operando2 = umaPilha.Desempilhar();
        //            double operando1 = umaPilha.Desempilhar();
        //            double valor = ValorDaSubExpressao(operando1, simbolo, operando2);
        //            umaPilha.Empilhar(valor);
        //        }
        //    }
        //    return umaPilha.Desempilhar();
        //}
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
                int abertos = 0;
                int fechados = 0;
                for (int i = 0; i < cadeia.Length && !erro; i++)
                {
                    char caracterLido = cadeia[i];
                    if (EhAbertura(caracterLido)) {
                        abertos++;
                        pilha.Empilhar(caracterLido);
                    }
                    else
                      if (EhFechamento(caracterLido))
                    {
                        fechados++;
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
                }
                if (abertos != fechados)
                {
                    MessageBox.Show("expressao nao balanceada!");
                    erro = true;
                }
                return true;
            }
            return false;
        }
    }
}