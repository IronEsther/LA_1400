using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LA1400
{
    public partial class Slotmaschine : Form
    {
        public Form1 mum;
        public Slotmaschine(Form1 mum)
        {
            InitializeComponent();
            this.mum = mum;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mum.Show();
            this.Hide();
        }
    }
}
