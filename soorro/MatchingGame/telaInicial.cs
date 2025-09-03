using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatchingGame
{
    public partial class telaInicial : Form
    {

        public telaInicial()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain();
            frmMain.Show();
            this.Hide();
        }

        private void telaInicial_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(250);
            frmMain.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(120);
            frmMain.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMain frmMain = new frmMain(60);
            frmMain.Show();
            this.Hide();
        }
    }
}
