using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace LA1400
{
    public partial class HigherLower : Form
    {
        public Form1 mum;
        public HigherLower(Form1 mum)
        {
            InitializeComponent();
            this.mum = mum;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            mum.Show();
            this.Hide();
        }
    }
}
