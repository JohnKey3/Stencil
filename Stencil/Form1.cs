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
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;



namespace Stencil
{

   
    public partial class Form1 : Form
    {
        Login log;

        public static string constr=Login.warpd;
           
        SqlConnection conn = new SqlConnection(constr);

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
             btnPanel.BackColor = Color.FromArgb(46, 51, 73);   //24; 30; 54


            lblTitle.Text = "Ознакомительная часть";
            this.PanelFormLoader.Controls.Clear();
            MainPanel2 Glavnayapanel = new MainPanel2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Glavnayapanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Glavnayapanel);
            Glavnayapanel.Show();
        }

        public static int WinHeight = 0;
        public static int WinWeight = 0;

       
        private void Form1_Load(object sender, EventArgs e)
        {
            panel3.Hide();
            int height = this.Top;
            int weight = this.Left;
            WinHeight = height;
            WinWeight = weight;

            conn.Open();
            string das = Login.Value1;
            label3.Text = "User: " + das;

            SqlCommand cmd = new SqlCommand("Select status from users where username=@name", conn);
            SqlParameter sd41 = new SqlParameter("@name", SqlDbType.Char, 100);
            sd41.Value = das;
            cmd.Parameters.Add(sd41);
            cmd.Prepare();
            string status = Convert.ToString(cmd.ExecuteScalar());
            label1.Text = "Status: " + status;
            switch (status)
            {
                case "Nobody":
                    btnGAmes.Visible = false;
                    btnSaller.Visible = false;
                    btnItog.Visible = false;
                    button1.Visible = false;

                    break;
                    
                case "Mmerch":
                    btnSaller.Visible = false;
                    button1.Visible = false;
                    break;

                default:
                    break;
            }
            conn.Close();

           
        }

        private void btnPanel_Click(object sender, EventArgs e)
        {
           
            PanelNavigatiom.Height = btnPanel.Height;
            PanelNavigatiom.Top = btnPanel.Top;
            PanelNavigatiom.Left = btnPanel.Left;

            

            lblTitle.Text = "Ознакомительная часть";
            this.PanelFormLoader.Controls.Clear();
            MainPanel2 Glavnayapanel = new MainPanel2() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true } ;
            Glavnayapanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Glavnayapanel);
            Glavnayapanel.Show();

           

            btnPanel.BackColor = Color.FromArgb(46, 51, 73);
            btnGAmes.BackColor = Color.FromArgb(24, 30, 54);
            btnItog.BackColor = Color.FromArgb(24, 30, 54);
            btnSaller.BackColor = Color.FromArgb(24, 30, 54);

            button1.BackColor = Color.FromArgb(24, 30, 54);
            PanelNavigatiom.Show();
            panel3.Hide();
        }

        private void btnGAmes_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnGAmes.Height;
            PanelNavigatiom.Top = btnGAmes.Top;
            lblTitle.Text = "Таблица игр";
            this.PanelFormLoader.Controls.Clear();
            Games Gamespanel = new Games() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Gamespanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Gamespanel);
            Gamespanel.Show();


            btnPanel.BackColor = Color.FromArgb(24, 30, 54);
            btnGAmes.BackColor = Color.FromArgb(46, 51, 73);
            btnItog.BackColor = Color.FromArgb(24, 30, 54);
            btnSaller.BackColor = Color.FromArgb(24, 30, 54);

            button1.BackColor = Color.FromArgb(24, 30, 54);

            int height = this.Top;
            int weight = this.Left;
            WinHeight = height;
            WinWeight = weight;
            PanelNavigatiom.Show();
            panel3.Hide();
        }

        private void btnSaller_Click(object sender, EventArgs e)
        {

            PanelNavigatiom.Height = btnSaller.Height;
            PanelNavigatiom.Top = btnSaller.Top;
            lblTitle.Text = "Таблица продавцов";
            this.PanelFormLoader.Controls.Clear();
            Seller Sallerpanel = new Seller() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Sallerpanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Sallerpanel);
            Sallerpanel.Show();



            btnPanel.BackColor = Color.FromArgb(24, 30, 54);
            btnGAmes.BackColor = Color.FromArgb(24, 30, 54);
            btnItog.BackColor = Color.FromArgb(24, 30, 54);
            btnSaller.BackColor = Color.FromArgb(46, 51, 73);

            button1.BackColor = Color.FromArgb(24, 30, 54);
            panel3.Hide();
            PanelNavigatiom.Show();
        }

        private void btnItog_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnItog.Height;
            PanelNavigatiom.Top = btnItog.Top;

            lblTitle.Text = "Таблица учетной";
            this.PanelFormLoader.Controls.Clear();
            Itog Itogpanel = new Itog() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Itogpanel.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Itogpanel);
            Itogpanel.Show();

            btnPanel.BackColor = Color.FromArgb(24, 30, 54);
            btnGAmes.BackColor = Color.FromArgb(24, 30, 54);
            btnItog.BackColor = Color.FromArgb(46, 51, 73);
            btnSaller.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(24, 30, 54);

            PanelNavigatiom.Show();
            panel3.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Height = btnExit.Height;
            PanelNavigatiom.Top = btnExit.Top;
            btnExit.BackColor = Color.FromArgb(46, 51, 73);
            System.Windows.Forms.Application.ExitThread();
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


        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }



        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            int height = this.Top;
            int weight = this.Left;
            WinHeight = height;
            WinWeight = weight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelNavigatiom.Hide();
            panel3.Show();
            panel3.Height = button1.Height;
            panel3.Top = button1.Top;

            lblTitle.Text = "График продаж";
            this.PanelFormLoader.Controls.Clear();
            SellerChart Graph = new SellerChart() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            Graph.FormBorderStyle = FormBorderStyle.None;
            this.PanelFormLoader.Controls.Add(Graph);
            Graph.Show();

            btnPanel.BackColor = Color.FromArgb(24, 30, 54);
            btnGAmes.BackColor = Color.FromArgb(24, 30, 54);
            btnItog.BackColor = Color.FromArgb(24, 30, 54);
            btnSaller.BackColor = Color.FromArgb(24, 30, 54);
            button1.BackColor = Color.FromArgb(46, 51, 73);

        }

       
        

        private void button1_Leave(object sender, EventArgs e)
        {
            button1.BackColor = Color.FromArgb(24, 30, 54);
        }
    }
}
