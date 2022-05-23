using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex_ergasia
{
    public partial class Formarxiki : Form
    {
        public Formarxiki()
        {
            InitializeComponent();
        }

        private void Formarxiki_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formbasic formbasic = new Formbasic();
            formbasic.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Form1 f1 = new Form1();
            f1.Show();
            this.Hide();

        }

        private void Formarxiki_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
