using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Stencil
{
    public partial class Form1 : Form
    {


        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]

        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
                 int nHeightEllipse

          );
        public Form1()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
            PanelNavigatiom.Height = btnPanel.Height;
            PanelNavigatiom.Top = btnPanel.Top;
            PanelNavigatiom.Left = btnPanel.Left;
            btnPanel.BackColor = Color.FromArgb(46, 51, 73);


            lblTitle.Text = "Ознакомительная часть";
            this.PanelFormLoader.Controls.Clear();
            MainPanel2 Glavnayapanel = new MainPanel2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Glavnayapanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Glavnayapanel);
            Glavnayapanel.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnPanel.Height;
            PanelNavigatiom.Top = btnPanel.Top;
            PanelNavigatiom.Left = btnPanel.Left;
            btnPanel.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Ознакомительная часть";
            this.PanelFormLoader.Controls.Clear();
            MainPanel2 Glavnayapanel = new MainPanel2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            Glavnayapanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Glavnayapanel);
            Glavnayapanel.Show();


        }

        private void btnGAmes_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnGAmes.Height;
            PanelNavigatiom.Top = btnGAmes.Top;
            btnGAmes.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Таблица игр";
            this.PanelFormLoader.Controls.Clear();
            Games Gamespanel = new Games() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Gamespanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Gamespanel);
            Gamespanel.Show();

        }

        private void btnSaller_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnSaller.Height;
            PanelNavigatiom.Top = btnSaller.Top;
            btnSaller.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Таблица продовцов";
            this.PanelFormLoader.Controls.Clear();
            Seller Sallerpanel = new Seller() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Sallerpanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Sallerpanel);
            Sallerpanel.Show();

        }

        private void btnItog_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnItog.Height;
            PanelNavigatiom.Top = btnItog.Top;
            btnItog.BackColor = Color.FromArgb(46, 51, 73);

            lblTitle.Text = "Таблица учетной";
            this.PanelFormLoader.Controls.Clear();
            Itog Itogpanel = new Itog() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Itogpanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Itogpanel);
            Itogpanel.Show();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnExit.Height;
            PanelNavigatiom.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
            this.Close();
        }

        private void btnPanel_Leave(object sender, EventArgs e)
        {
            btnPanel.BackColor = Color.FromArgb(24,30,54);
        }

        private void btnGAmes_Leave(object sender, EventArgs e)
        {
            btnGAmes.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnSaller_Leave(object sender, EventArgs e)
        {
            btnSaller.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnItog_Leave(object sender, EventArgs e)
        {
            btnItog.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void btnExit_Leave_1(object sender, EventArgs e)
        {
            btnExit.BackColor = Color.FromArgb(24, 30, 54);
        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }
    }
}
