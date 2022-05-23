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
    public partial class Form1 : Form
    {
        int n1, n2, n3, n4, n5, n6;
        Car car = new Car();
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Αρχικοποίηση Καταστάσεων Φαναριών
            GreenLight.Visible = true;
            OrangeLight.Visible = false;
            RedLight.Visible = false;
            GrLight.Visible = false;
            OrLight.Visible = false;
            ReLight.Visible = true;
        }
        //Απλό change
        private void butChange_Click(object sender, EventArgs e)
        {   
            //κυρίως πάνε στην επόμενη κατάσταση 
            if (GreenLight.Visible == true && ReLight.Visible==true)  //Εφόσον το 1ο είναι πράσινο,το 2ο θα είναι κόκκινο...Το 1ο άρα θα γίνει 
            {                                                        //πορτοκαλί και το 2ο θα παραμείνει κόκκινο 
                GreenLight.Visible = false;
                OrangeLight.Visible = true;
                RedLight.Visible = false;
                GrLight.Visible = false;
                OrLight.Visible = false;
                ReLight.Visible = true;

            }
            else if (OrangeLight.Visible == true && ReLight.Visible==true) //1ο:πορτοκαλί άρα 2ο:κόκκινο,άρα 1ο θα γίνει κόκκινο κ 2ο θα γίνει πράσινο
            {
                GreenLight.Visible = false;
                OrangeLight.Visible = false;
                RedLight.Visible = true;
                GrLight.Visible = true;
                OrLight.Visible = false;
                ReLight.Visible = false;
            }

            else if (RedLight.Visible == true && GrLight.Visible==true) //endiameso stadio,diladi pairnw ta true ths proigoumenis katastasis ,afinw to ena 
            {                                                           //fanari idio kai to allo t kanw apo prasino portokali,για να γίνει τελικά κόκκινο 
                GreenLight.Visible = false;                             //στην επόμενη κατάσταση 
                OrangeLight.Visible = false;
                RedLight.Visible = true;
                GrLight.Visible = false;
                OrLight.Visible = true;
                ReLight.Visible = false;
             }
            else if (RedLight.Visible == true && OrLight.Visible == true) // αλλάζω κανονικα το 1ο απο κόκκινο σε πρ και το 2ο από πορτ. σε κόκκινο 
            {
                GreenLight.Visible = true;
                OrangeLight.Visible = false;
                RedLight.Visible = false;
                GrLight.Visible = false;
                OrLight.Visible = false;
                ReLight.Visible = true;
            }
            
        }
         
        

            //timer για το auto mode (με βάση τους χρόνους που βάζει ο χρήστης στο text box)
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //οι καταστάσεις και οι συνθήκες είναι ίδιες με το Change
            if (GreenLight.Visible == true && ReLight.Visible == true)
            {
                //για το 1ο φανάρι 
                timer1.Interval = (int.Parse(textBoxOrange.Text.ToString())) * 1000; //βάζω το text box της κατάστασης που είναι true, παρακάτω:
                GreenLight.Visible = false;                                              //= κατάστασης που αλλάζει
                OrangeLight.Visible = true;
                RedLight.Visible = false;
                //για το 2ο φανάρι
                timer1.Interval = (int.Parse(textBoxGr.Text.ToString())) * 1000;
                GrLight.Visible = false;
                OrLight.Visible = false;
                ReLight.Visible = true;
            }
            else if (OrangeLight.Visible == true && ReLight.Visible == true)
            {
                timer1.Interval = (int.Parse(textBoxRed.Text.ToString())) * 1000;
                GreenLight.Visible = false;
                OrangeLight.Visible = false;
                RedLight.Visible = true;

                timer1.Interval = (int.Parse(textBoxGr.Text.ToString())) * 1000;
                GrLight.Visible = true;
                OrLight.Visible = false;
                ReLight.Visible = false;
            }
            else if (RedLight.Visible == true && GrLight.Visible == true)
            {
                timer1.Interval = (int.Parse(textBoxGreen.Text.ToString()) * 1000);   
                GreenLight.Visible = false;                            
                OrangeLight.Visible = false;
                RedLight.Visible = true;
                
                timer1.Interval = (int.Parse(txtBoxOr.Text.ToString())) * 1000;
                GrLight.Visible = false;
                OrLight.Visible = true;
                ReLight.Visible = false;
            }
            else if (RedLight.Visible == true && OrLight.Visible == true) 
            {
                timer1.Interval = (int.Parse(textBoxGreen.Text.ToString())) * 1000;
                GreenLight.Visible = true;
                OrangeLight.Visible = false;
                RedLight.Visible = false;

                timer1.Interval = (int.Parse(txtBoxRe.Text.ToString()) * 1000);
                GrLight.Visible = false;
                OrLight.Visible = false;
                ReLight.Visible = true;
            }
        }


        private void btnStartAutoMode_Click_1(object sender, EventArgs e)
        {
            n1 = Int32.Parse(textBoxGreen.Text);
            n2 = Int32.Parse(textBoxRed.Text);
            n3 = Int32.Parse(textBoxOrange.Text);
            n4 = Int32.Parse(textBoxGr.Text);
            n5 = Int32.Parse(txtBoxOr.Text);
            n6 = Int32.Parse(txtBoxRe.Text);
            if (n1 > 0 && n2 > 0 && n3 > 0 && n4 > 0 && n5 > 0 && n6 > 0)
            {
                if ((n1 + n3) == n6 && (n4 + n5) == n2)
                {
                    timer1.Enabled = true;
                    timerCar.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Green plus Orange times must be equal to the other's traffic light Red time.");
                }
            }
            else
            {
                MessageBox.Show("All numbers must be greater than 0.");
            }
        }

        

        private void btnStopAutoMode_Click_1(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timerCar.Enabled = false;
        }


        private void timerCar_Tick(object sender, EventArgs e)
        {
            if (GreenLight.Visible==true)
            {
                hor_car.Location = new Point(hor_car.Location.X - 10, hor_car.Location.Y);
            }
            else if (OrangeLight.Visible == true)
            {
                hor_car.Location = new Point(hor_car.Location.X - 5, hor_car.Location.Y);

            }
            if (hor_car.Location.X == pictureBox5.Location.X)
            {
                MessageBox.Show("ghuughghj");
                if (RedLight.Visible == true || OrangeLight.Visible == true)
                {
                    //hor_car.Location = new Point(hor_car.Location.X , hor_car.Location.Y);
                }
                else if (GreenLight.Visible == true)
                {
                    hor_car.Location = new Point(hor_car.Location.X - 10, hor_car.Location.Y);
                }
            }
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formarxiki f = new Formarxiki();
            f.Show();
            this.Hide();
        }

        private void previousLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Formbasic f = new Formbasic();
            f.Show();
            this.Hide();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
