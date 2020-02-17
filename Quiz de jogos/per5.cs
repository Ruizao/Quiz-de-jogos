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
    public partial class per5 : Form
    {
        public per5()
        {
            InitializeComponent();
        }

        private void Per5_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = false;
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

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            per6 p6 = new per6();
            p6.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            per6 p6 = new per6();
            p6.ShowDialog();
        }
        private Boolean Verifica1(bool valor)
        {
            if (radioButton1.Checked)
            {
                resposta.Text = "Resposta Incorreta";
                label4.Visible = true;


            }
            else if (radioButton2.Checked)
            {
                resposta.Text = "Resposta Incorreta";
                label4.Visible = true;

            }

            else if (radioButton3.Checked)
            {
                resposta.Text = "Resposta Correta";
                label3.Visible = true;
            }
            return true;
        }

    }
}
