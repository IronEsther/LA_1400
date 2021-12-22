using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LA1400
{
    public partial class lblQuestion : Form
    {
        Random randomNumber = new Random();
        int number = 0;
        int guesses = 0;
        public Form1 mum;
        public lblQuestion(Form1 mum)
        {
            InitializeComponent();
            this.mum = mum;
            loadQuestions();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mum.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void loadQuestions()
        {

            number = randomNumber.Next(0, 101);
            label1.Text = "I am thinking of a number between: 0 and 100.";
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            guesses = 0;
            lblGuessed.Text = "You guessed " + guesses + " times.";
            txtEnterNumber.Text = "";
            loadQuestions();
        }

        private void btnClick_Click(object sender, EventArgs e)
        {

            guesses += 1;

            try
            {
                int guessed = Convert.ToInt32(txtEnterNumber.Text);

                if (guessed == number)
                {
                    MessageBox.Show("Nice, you guessed the secret number. If you want to try another, just click 'Next'");
                    txtEnterNumber.Text = "";
                    guesses = guesses - 1;
                }
                else if (guessed > number && guessed > 0 && guessed <= 100)
                {
                    MessageBox.Show("You're thinking too high.");
                }
                else if (guessed < number && guessed <= 100 && guessed > 0)
                {
                    MessageBox.Show("You're thinking too low.");
                }
                else
                {
                    MessageBox.Show("Please enter a valide number.");
                }
            }
            catch
            {
                MessageBox.Show("Please enter a number");
            }

            lblGuessed.Text = "You guessed " + guesses + " times.";

            if (guesses == 10)
            {
                MessageBox.Show("I'm sorry, but you took too long to guess the number. It was " + number + ". Please give another try to guess the new number.");
                txtEnterNumber.Text = "";
                guesses = 0;
                lblGuessed.Text = "You guessed " + guesses + " times.";
                loadQuestions();
            }
        }
    }
}
