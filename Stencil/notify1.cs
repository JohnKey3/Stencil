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
    public partial class notify1 : Form
    {

        Form1 fora;
        public notify1(String  message)
        {
            InitializeComponent();
            label1.Text = message;
            int hei = Form1.WinHeight;
            int wei = Form1.WinWeight;
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(wei+(951-this.Width), hei+(577-this.Height));
        }

        private void notify1_Load(object sender, EventArgs e)
        {
            timerClose.Start();
            
        }

        private void timerClose_Tick(object sender, EventArgs e)
        {
            Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
