using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cadastro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");
        }

        private void calcularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double sb, inss, bonus, sl, slb;
            sb = Convert.ToDouble(textBox5.Text);
            inss = sb * 0.11;
            textBox6.Text = inss.ToString("#,##0.00");
            bonus = sb * 0.06;
            textBox8.Text = bonus.ToString("#,##0.00");
            sl = sb - inss;
            textBox7.Text = sl.ToString("#,##0.00");
            slb = sl + bonus;
            textBox9.Text = slb.ToString("#,##0.00");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.sem_imagem;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox7.Load(openFileDialog1.FileName);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void limparToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBox7.Image = Properties.Resources.sem_imagem;
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();

            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }
    }
}
