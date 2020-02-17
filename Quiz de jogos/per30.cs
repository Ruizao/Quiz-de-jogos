using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Quiz_de_jogos
{
    public partial class per30 : Form
    {
        private SoundPlayer _soundPlayer;
        public per30()
        {
            InitializeComponent();
            _soundPlayer = new SoundPlayer("James.wav");
        }

        private void Per30_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button3.Enabled = false;
        }

        private void DuelStateButton_CheckedChanged(object sender, EventArgs e)
        {
            if (duelStateButton.Checked)
            {
                duelStateButton.Text = "Stop";
                _soundPlayer.Play();
            }
            else
            {
                duelStateButton.Text = "Play";
                _soundPlayer.Stop();
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (Verifica1(true))
            {
                button3.Enabled = true;
            }
            button1.Enabled = false;
            button2.Enabled = false;
            _soundPlayer.Stop();

        }
        private Boolean Verifica1(bool valor)
        {
            if (radioButton1.Checked)
            {
                resposta.Text = "Resposta Correta";
                label3.Visible = true;


            }
            else if (radioButton3.Checked)
            {
                resposta.Text = "Resposta Incorreta";
                label4.Visible = true;

            }
            return true;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            per31 p31 = new per31();
            p31.ShowDialog();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            per31 p31 = new per31();
            p31.ShowDialog();
        }
    }
}
