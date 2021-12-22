using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LA1400
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public TextBox tb1;
        public int Coins = 50;
        bool SlotMaschiene = false;
        bool RandomNumberGuesser = false;
        bool HigherLower = false;
        public Form1()
        {
            InitializeComponent();
            instance = this;
            label4.Text = Convert.ToString(Coins);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form Hütchenspiel = new Hütchenspiel(this);
            Hütchenspiel.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form Slotmaschine = new Slotmaschine(this);
            Slotmaschine.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form Random_Number_Guesser = new lblQuestion(this);
            Random_Number_Guesser.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form Higher_Lower = new HigherLower(this);
            Higher_Lower.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Coins);
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            label1.Visible = false;
            label2.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            button9.Visible = true;
            label8.Visible = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label4.Text = Convert.ToString(Coins);
            button2.Visible = true;
            button3.Visible = SlotMaschiene;
            button4.Visible = RandomNumberGuesser;
            button5.Visible = HigherLower;
            button10.Visible = false;
            button11.Visible = false;
            button12.Visible = false;
            label1.Visible = true;
            label2.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            button9.Visible = false;
            label8.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if(Coins >= 1000 && SlotMaschiene == false)
            {
                Coins = Coins - 1000;
                SlotMaschiene = true;
                MessageBox.Show("Kauf war erfolgreich");
                label4.Text = Convert.ToString(Coins);
                button10.Text = "Verkauft";
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (Coins >= 500 && RandomNumberGuesser == false)
            {
                Coins = Coins - 500;
                RandomNumberGuesser = true;
                MessageBox.Show("Kauf war erfolgreich");
                label4.Text = Convert.ToString(Coins);
                button12.Text = "Verkauft";
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (Coins >= 200 && HigherLower == false)
            {
                Coins = Coins - 200;
                HigherLower = true;
                MessageBox.Show("Kauf war erfolgreich");
                label4.Text = Convert.ToString(Coins);
                button11.Text = "Verkauft";
            }
        }
    }
}
