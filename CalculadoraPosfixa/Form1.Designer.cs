
namespace CalculadoraPosfixa
{
    partial class calculadora
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
            this.txtVisor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lbSequencias = new System.Windows.Forms.Label();
            this.btnPotencia = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicar = new System.Windows.Forms.Button();
            this.btnSubtrair = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.btnDouble = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btnParenteses = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnParenteses2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVisor
            // 
            this.txtVisor.Location = new System.Drawing.Point(13, 69);
            this.txtVisor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtVisor.Name = "txtVisor";
            this.txtVisor.Size = new System.Drawing.Size(494, 26);
            this.txtVisor.TabIndex = 0;
            this.txtVisor.TextChanged += new System.EventHandler(this.txtVisor_TextChanged);
            this.txtVisor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVisor_KeyDown);
            this.txtVisor.Leave += new System.EventHandler(this.txtVisor_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Calculadora";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(13, 105);
            this.txtResultado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ReadOnly = true;
            this.txtResultado.Size = new System.Drawing.Size(494, 26);
            this.txtResultado.TabIndex = 2;
            // 
            // lbSequencias
            // 
            this.lbSequencias.AutoSize = true;
            this.lbSequencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSequencias.Location = new System.Drawing.Point(12, 153);
            this.lbSequencias.Name = "lbSequencias";
            this.lbSequencias.Size = new System.Drawing.Size(129, 24);
            this.lbSequencias.TabIndex = 3;
            this.lbSequencias.Text = "Pósfixa - Infixa";
            // 
            // btnPotencia
            // 
            this.btnPotencia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPotencia.Location = new System.Drawing.Point(16, 197);
            this.btnPotencia.Name = "btnPotencia";
            this.btnPotencia.Size = new System.Drawing.Size(112, 40);
            this.btnPotencia.TabIndex = 4;
            this.btnPotencia.Text = "^";
            this.btnPotencia.UseVisualStyleBackColor = false;
            this.btnPotencia.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDivisao.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDivisao.Location = new System.Drawing.Point(134, 197);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(112, 40);
            this.btnDivisao.TabIndex = 5;
            this.btnDivisao.Text = "/";
            this.btnDivisao.UseVisualStyleBackColor = false;
            this.btnDivisao.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnMultiplicar
            // 
            this.btnMultiplicar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnMultiplicar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMultiplicar.Location = new System.Drawing.Point(252, 197);
            this.btnMultiplicar.Name = "btnMultiplicar";
            this.btnMultiplicar.Size = new System.Drawing.Size(112, 40);
            this.btnMultiplicar.TabIndex = 6;
            this.btnMultiplicar.Text = "*";
            this.btnMultiplicar.UseVisualStyleBackColor = false;
            this.btnMultiplicar.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnSubtrair
            // 
            this.btnSubtrair.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnSubtrair.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubtrair.Location = new System.Drawing.Point(370, 197);
            this.btnSubtrair.Name = "btnSubtrair";
            this.btnSubtrair.Size = new System.Drawing.Size(112, 40);
            this.btnSubtrair.TabIndex = 7;
            this.btnSubtrair.Text = "-";
            this.btnSubtrair.UseVisualStyleBackColor = false;
            this.btnSubtrair.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.Location = new System.Drawing.Point(16, 243);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 40);
            this.button5.TabIndex = 8;
            this.button5.Text = "7";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(134, 243);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(112, 40);
            this.button6.TabIndex = 9;
            this.button6.Text = "8";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(252, 244);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(112, 40);
            this.button7.TabIndex = 10;
            this.button7.Text = "9";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(370, 244);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(112, 40);
            this.btnAdicionar.TabIndex = 11;
            this.btnAdicionar.Text = "+";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(16, 290);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(112, 40);
            this.button9.TabIndex = 12;
            this.button9.Text = "4";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(134, 290);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(112, 40);
            this.button10.TabIndex = 13;
            this.button10.Text = "5";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(252, 292);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(112, 40);
            this.button11.TabIndex = 14;
            this.button11.Text = "6";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnDouble
            // 
            this.btnDouble.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnDouble.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDouble.Location = new System.Drawing.Point(370, 292);
            this.btnDouble.Name = "btnDouble";
            this.btnDouble.Size = new System.Drawing.Size(112, 40);
            this.btnDouble.TabIndex = 15;
            this.btnDouble.Text = ".";
            this.btnDouble.UseVisualStyleBackColor = false;
            this.btnDouble.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(134, 338);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(112, 40);
            this.button13.TabIndex = 16;
            this.button13.Text = "2";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button14
            // 
            this.button14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button14.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.Location = new System.Drawing.Point(16, 338);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(112, 40);
            this.button14.TabIndex = 17;
            this.button14.Text = "1";
            this.button14.UseVisualStyleBackColor = false;
            this.button14.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button15.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button15.Location = new System.Drawing.Point(252, 338);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(112, 40);
            this.button15.TabIndex = 18;
            this.button15.Text = "3";
            this.button15.UseVisualStyleBackColor = false;
            this.button15.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnParenteses
            // 
            this.btnParenteses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnParenteses.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParenteses.Location = new System.Drawing.Point(370, 338);
            this.btnParenteses.Name = "btnParenteses";
            this.btnParenteses.Size = new System.Drawing.Size(112, 40);
            this.btnParenteses.TabIndex = 19;
            this.btnParenteses.Text = ")";
            this.btnParenteses.UseVisualStyleBackColor = false;
            this.btnParenteses.Click += new System.EventHandler(this.botoes_Click);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button17.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button17.Location = new System.Drawing.Point(16, 384);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(112, 40);
            this.button17.TabIndex = 20;
            this.button17.Text = "0";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.botoes_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIgual.Location = new System.Drawing.Point(134, 384);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(112, 40);
            this.btnIgual.TabIndex = 21;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = false;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.Location = new System.Drawing.Point(252, 384);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(112, 40);
            this.btnLimpar.TabIndex = 22;
            this.btnLimpar.Text = "C";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnParenteses2
            // 
            this.btnParenteses2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnParenteses2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnParenteses2.Location = new System.Drawing.Point(370, 384);
            this.btnParenteses2.Name = "btnParenteses2";
            this.btnParenteses2.Size = new System.Drawing.Size(112, 40);
            this.btnParenteses2.TabIndex = 23;
            this.btnParenteses2.Text = "(";
            this.btnParenteses2.UseVisualStyleBackColor = false;
            this.btnParenteses2.Click += new System.EventHandler(this.botoes_Click);
            // 
            // calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(520, 445);
            this.Controls.Add(this.btnParenteses2);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.btnParenteses);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnDouble);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnSubtrair);
            this.Controls.Add(this.btnMultiplicar);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnPotencia);
            this.Controls.Add(this.lbSequencias);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVisor);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtVisor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lbSequencias;
        private System.Windows.Forms.Button btnPotencia;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicar;
        private System.Windows.Forms.Button btnSubtrair;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btnDouble;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btnParenteses;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button btnIgual;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnParenteses2;
    }
}

