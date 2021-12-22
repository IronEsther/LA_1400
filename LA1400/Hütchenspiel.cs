using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LA1400
{
    public partial class Hütchenspiel : Form
    {
        public Form1 mum;
        bool right1 = false;
        bool right2 = false;
        int Einsatz = 0;
        const int position1 = 112;
        const int position2 = 337;
        const int position3 = 563;
        int curentpositionBox1 = 1;
        int curentpositionBox2 = 2;
        int curentpositionBox3 = 3;
        int test = 0;
        int Zahl = 0;
        
        public Hütchenspiel(Form1 mum)
        {
            InitializeComponent();
            this.mum = mum;
            label2.Hide();
            label4.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.instance.Coins = Form1.instance.Coins + 50;
        }

        private void movetimerevent(object sender, EventArgs e)
        {

        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                Zahl = new Random().Next(1, 3);
                if (Einsatz < Form1.instance.Coins)
                {
                    Einsatz = Convert.ToInt32(textBox1.Text);
                    label2.Show();
                    label4.Text = Convert.ToString(Einsatz);
                    label4.Show();
                    button1.Hide();
                    textBox1.Hide();
                    label1.Hide();
                }
                else
                {
                    MessageBox.Show("Gib einen Betrag ein den du wirklich hast.");
                }
                //int RandomBox1Hight = new Random().Next(0, 330);
                //int RandomBox1Lenght = new Random().Next(0, 750);
                //for(int i = 0; i < 10; i++)
                //{
                  //  int myrandom = new Random().Next(1, 3);
                    //if (myrandom == 1)
                    //{
                      //  test = 1;
                    //}
                    //else if (myrandom == 2)
                    //{
                      //  test = 2;
                    //}
                    //else if (myrandom == 3)
                    //{
                      //  test = 3;
                    //}
                //}
            }
            catch
            {
                MessageBox.Show("Dir muss ein Fehler beim Eintippen der Zahl unterlaufen sein");
            }
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {if (Zahl == 0)
            {
                MessageBox.Show("Bestätige zuerst deinen Einsatz");
            }
            else if (Zahl == 2)
            {
                MessageBox.Show("Du hast richtig getippt");
                Form1.instance.Coins = Form1.instance.Coins + (2*Einsatz);
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 1)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 3)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (Zahl == 0)
            {
                MessageBox.Show("Bestätige zuerst deinen Einsatz");
            }
            else if (Zahl == 3)
            {
                MessageBox.Show("Du hast richtig getippt");
                Form1.instance.Coins = Form1.instance.Coins + (2 * Einsatz);
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 1)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 2)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(Zahl == 0)
            {
                MessageBox.Show("Bestätige zuerst deinen Einsatz");
            }
            else if (Zahl == 1)
            {
                MessageBox.Show("Du hast richtig getippt");
                Form1.instance.Coins = Form1.instance.Coins + (2 * Einsatz);
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 2)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
            else if (Zahl == 3)
            {
                MessageBox.Show("Du hast es verschissen");
                Form1.instance.Coins = Form1.instance.Coins - Einsatz;
                this.Hide();
                mum.Show();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
