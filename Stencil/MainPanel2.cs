using System;
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
    public partial class MainPanel2 : Form
    {
        public MainPanel2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.FromArgb(0, 146, 249);
            pictureBox2.Visible = true;
            label5.Text = "Это мем";

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            label5.ForeColor = System.Drawing.Color.Red;
        }
    }
}
