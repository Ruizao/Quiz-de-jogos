using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_de_jogos
{
    public partial class per1 : Form
    {
        public per1()
        {
            InitializeComponent();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            per2 p2 = new per2();
            p2.ShowDialog();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Verifica1(true))
            {
                button3.Enabled = true;
            }
            button1.Enabled = false;
            button2.Enabled = false;

        }

        private void Per1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = false;
        }


        private Boolean Verifica1(bool valor)
        {
            if (radioButton1.Checked)
            {
                resposta.Text = "Resposta Correta";

            }
            else if (radioButton2.Checked)
            {
                resposta.Text = "Resposta Incorreta";
            }

            else if (radioButton3.Checked)
            {
                resposta.Text = "Resposta Incorreta";
            }
            return true;
        }

        private void Resposta_Click(object sender, EventArgs e)
        {

        }


        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            per2 p2 = new per2();
            p2.ShowDialog();
        }
    }
}
