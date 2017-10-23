using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public string Jogador_Atual = "x";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        public string InverteJogador()
        {
            if (Jogador_Atual == "x")
            {
                return "o";
            }
            else
            {
                return "x";
            }
            return "x";
        }
        public void Zerar()
        {
            a.Text = "";
            b.Text = "";
            c.Text = "";
            d.Text = "";
            eb.Text = "";
            f.Text = "";
            g.Text = "";
            h.Text = "";
            i.Text = "";
            Jogador_Atual = "x";
        }
        public void Ganhar()
        {
            MessageBox.Show("O jogador " + Jogador_Atual + " Ganhou!");
            Zerar();
        }
        public bool verificar(string jogador_at)
        { //VERTICAL
            if (a.Text == jogador_at && d.Text == jogador_at && g.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (b.Text == jogador_at && eb.Text == jogador_at && h.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (c.Text == jogador_at && f.Text == jogador_at && i.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            //HORIZONTAL
            if (a.Text == jogador_at && b.Text == jogador_at && c.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (d.Text == jogador_at && eb.Text == jogador_at && f.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (g.Text == jogador_at && h.Text == jogador_at && i.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            //DIAGONAL
            if (a.Text == jogador_at && eb.Text == jogador_at && i.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
            if (c.Text == jogador_at && eb.Text == jogador_at && g.Text == jogador_at)
            {
                Ganhar();
                return true;
            }
           
            Jogador_Atual = InverteJogador();
            label1.Text = "Jogador Atual: " + Jogador_Atual;
            return false;

        }



        private void btreset_Click(object sender, EventArgs e)
        {
            Zerar();
        }

        private void a_Click(object sender, EventArgs e)
        {
            if (a.Text == "")
            {
                a.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void b_Click(object sender, EventArgs e)
        {
            if (b.Text == "")
            {
                b.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void c_Click(object sender, EventArgs e)
        {
            if (c.Text == "")
            {
                c.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void d_Click(object sender, EventArgs e)
        {
            if (d.Text == "")
            {
                d.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

       

        private void f_Click(object sender, EventArgs e)
        {
            if (f.Text == "")
            {
                f.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void g_Click(object sender, EventArgs e)
        {
            if (g.Text == "")
            {
                g.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void h_Click(object sender, EventArgs e)
        {
            if (h.Text == "")
            {
                h.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void i_Click(object sender, EventArgs e)
        {
            if (i.Text == "")
            {
                i.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }

        private void eb_Click_1(object sender, EventArgs e)
        {
            if (eb.Text == "")
            {
                eb.Text = Jogador_Atual;
                verificar(Jogador_Atual);
            }
        }
    }
}