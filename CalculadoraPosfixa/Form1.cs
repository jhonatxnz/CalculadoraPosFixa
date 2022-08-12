﻿using System;
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
        private void btnIgual_Click(object sender, EventArgs e)
        {
            //mostrar essa parte
            if (txtVisor.Text != "")
            {
                string expressao = txtVisor.Text;
                char[] values;
                values = expressao.ToCharArray(0, expressao.Length);
                char letra = 'A';
                for (int j = 0;j < expressao.Length; j++)
                {
                    if ("1234567890.".Contains(expressao[j])) {
                        MessageBox.Show(values[j].ToString());
                        values[j] = letra++;
                        MessageBox.Show(values[j].ToString());
                    }
                        
                }
                MessageBox.Show(values.Length.ToString());
                

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

            double resultado = 1;
            txtResultado.Text = resultado.ToString();
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
            Balanceamento(txtVisor.Text);
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
