using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JogoShowDoMilhao
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int resposta = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (resposta == 1)
            {
                MessageBox.Show("Certa resposta!");
            }

            else
            {
                MessageBox.Show("Que pena! Resposta errada!");
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            resposta = 1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            resposta = 2;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            resposta = 3;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            resposta = 4;
        }
    }
}
