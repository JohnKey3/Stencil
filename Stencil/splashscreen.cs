﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stencil
{
    public partial class splashscreen : Form
    {
        public splashscreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            progressBar1.Increment(4);
           

            if (progressBar1.Value >= 100)
            {
                timer1.Enabled = false;
                Form1 forn2 = new Form1();
                forn2.Show();
                this.Hide();
                    
                    
            }

        }
    }
}
