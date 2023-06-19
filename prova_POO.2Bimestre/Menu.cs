using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prova_POO._2Bimestre
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string servico = Convert.ToString(cm_formaPag.Text);
            string servico1 = "formatação";
            string servico2 = "limpeza";
            string servico3 = "troca de peça";

            string formPag = Convert.ToString(cm_formaPag.Text);
            string formPag1 = "dinheiro";
            string formPag2 = "pix";
            string formPag3 = "cartão";

            double contador;

            Convert.ToDouble(lb_valor.Text);

            if(servico == servico1)
            {
                contador = 100;

                if(formPag == formPag1)
                {
                    contador = contador / 0.020;
                    lb_valor.Text = contador.ToString();
                }

                else if (formPag == formPag2)
                {
                    contador = contador / 0.010;
                    lb_valor.Text = contador.ToString();
                }

                else
                {
                    //lb_valor = contador.ToString();
                }

            }
            else if (servico == servico2)
            {
                contador = 50;

                if (formPag == formPag1)
                {
                    contador = contador / 0.020;
                    lb_valor.Text = contador.ToString();
                }

                else if (formPag == formPag2)
                {
                    contador = contador / 0.010;
                    lb_valor.Text = contador.ToString();
                }
            }
            else if(servico == servico3)
            {
                contador = 200;

                if (formPag == formPag1)
                {
                    contador = contador / 0.020;
                    lb_valor.Text = contador.ToString();
                }

                else if (formPag == formPag2)
                {
                    contador = contador / 0.010;
                    lb_valor.Text = contador.ToString();
                }
                MessageBox.Show(contador.ToString());

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tx_compt.Clear();
            tx_nome.Clear();
            //cm_formaPag.Clear();
        }

        private void tx_compt_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
