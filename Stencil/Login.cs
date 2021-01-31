using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Server;


namespace Stencil
{
    public partial class Login : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=8Practos;Integrated Security=True");
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static string Value1 = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="" || textBox2.Text=="")
            {
                
            }

            else
            {
                conn.Open();
                string query2 = "Select * From Users WHERE username ='"+textBox1.Text+"' and password='"+textBox2.Text+"'";

               
                SqlCommand command2 = new SqlCommand(query2, conn);
                SqlDataReader reader2 = command2.ExecuteReader();

                if (reader2.Read() == true)
                {
                    Value1 = textBox1.Text;
                    new splashscreen().Show();
                    this.Hide();
                    conn.Close();
                }
                else
                {
                    conn.Close();
                    MessageBox.Show("Не правильный логин или пароль");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox1.Focus();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = '\0';
            }
            else
            {
                textBox2.PasswordChar = '*';
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }


        Point lastPoint;
        private void Login_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }

        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void label3_Click(object sender, EventArgs e)
        {
            new Form1().Show();
            this.Hide();
        }
    }
}
