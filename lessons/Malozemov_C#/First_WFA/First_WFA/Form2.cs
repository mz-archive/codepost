using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace First_WFA
{
    public partial class Form2 : Form
    {
        int time = 5;

        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            time--;
            label2.Text = time.ToString();
            if (time == 0) 
            {
                Close();
            }
        }
    }
}
