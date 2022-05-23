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
    public partial class Formbasic : Form
    {
        int n1, n2, n3; //μεταβλητες για τον έλεγχο στα text box 
        TLights tlight = new TLights();  //instance of class TLights

        public Formbasic()
        {
            InitializeComponent();
        }

        private void Formbasic_Load(object sender, EventArgs e)
        {
            Green.Visible = true;
            Orange.Visible = false;
            Red.Visible = false;

        }
        //change
        private void butChange_Click(object sender, EventArgs e)
        {
            if (Green.Visible == true)
            {
                Green.Visible = false;
                Orange.Visible = true;
                Red.Visible = false;
                tlight.orange++;
            }
            else if (Orange.Visible == true)
            {

                Green.Visible = false;
                Orange.Visible = false;
                Red.Visible = true;
                tlight.red++;
            }
            else if (Red.Visible == true)
            {

                Green.Visible = true;
                Orange.Visible = false;
                Red.Visible = false;
                tlight.green++;
            }
            label4.Text = tlight.red.ToString();
            label5.Text = tlight.orange.ToString();
            label6.Text = tlight.green.ToString();
        }
        //η λειτουργία του auto mode
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Green.Visible == true)
            {
                timer1.Interval = (int.Parse(textBoxOrange.Text.ToString())) * 1000; //βάζω το text box της επόμενης κατάστασης σύμφωνα με τις boolean παρακάτω:
                Green.Visible = false;
                Orange.Visible = true;
                Red.Visible = false;
            }
            else if (Orange.Visible == true)
            {
                timer1.Interval = (int.Parse(textBoxRed.Text.ToString())) * 1000;
                Green.Visible = false;
                Orange.Visible = false;
                Red.Visible = true;
            }
            else if (Red.Visible == true)
            {
                timer1.Interval = (int.Parse(textBoxGreen.Text.ToString())) * 1000;
                Green.Visible = true;
                Orange.Visible = false;
                Red.Visible = false;
            }

        }

        private void btnStartAutoMode_Click(object sender, EventArgs e)
        {
            n1 = Int32.Parse(textBoxGreen.Text);
            n2 = Int32.Parse(textBoxRed.Text);
            n3 = Int32.Parse(textBoxOrange.Text);
            if (n1 > 0 && n2 > 0 && n3 > 0)
            {
                timer1.Enabled = true;
            }
            else
            {
                MessageBox.Show("All numbers must be greater than 0.");
            }
        }

        private void btnStopAutoMode_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;

        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formarxiki f = new Formarxiki();
            f.Show();
            this.Hide();
        }

        private void nextLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void Formbasic_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}