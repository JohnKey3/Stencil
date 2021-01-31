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
    public partial class Games : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=8Practos;Integrated Security=True");
        public Games()
        {
            InitializeComponent();
        }

        private void Games_Load(object sender, EventArgs e)
        {
            dataGridView1.EnableHeadersVisualStyles = false; //Чтоб цвета применялись

            dataGridView1.Rows.Clear();
            conn.Open();
            string query = "SELECT * FROM Game_Inf ";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "")
            {

            }
            else
            {
                conn.Open();

                dataGridView1.Rows.Clear();
                SqlCommand cmd = new SqlCommand("INSERT into Game_Inf(Name,Descr,Price,Sale) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", conn);

                cmd.ExecuteNonQuery();
                string query = "SELECT * FROM Game_Inf ";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader reader = command.ExecuteReader();
                List<string[]> data = new List<string[]>();
                while (reader.Read())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = reader[0].ToString();
                    data[data.Count - 1][1] = reader[1].ToString();
                    data[data.Count - 1][2] = reader[2].ToString();
                    data[data.Count - 1][3] = reader[3].ToString();
                    data[data.Count - 1][4] = reader[4].ToString();
                    data[data.Count - 1][5] = reader[5].ToString();
                }
                reader.Close();
                conn.Close();
                foreach (string[] s in data)
                    dataGridView1.Rows.Add(s);
            }
            
            
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            conn.Open();
            string query = "SELECT * FROM Game_Inf ";
            SqlCommand command = new SqlCommand(query, conn);
            SqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[7]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            conn.Close();
            foreach (string[] s in data)
                dataGridView1.Rows.Add(s);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                conn.Open();
                int idgame = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd43 = new SqlCommand("UPDATE Game_Inf SET Name='" + textBox1.Text + "',Descr='" + textBox2.Text + "',Price='" + textBox3.Text + "',Sale='" + textBox4.Text + "' where Id='" + idgame + "'", conn);
                cmd43.ExecuteNonQuery();

                dataGridView1.Rows.Clear();
                string query = "SELECT * FROM Game_Inf ";
                SqlCommand command = new SqlCommand(query, conn);
                SqlDataReader readern = command.ExecuteReader();
                List<string[]> datan = new List<string[]>();
                while (readern.Read())
                {
                    datan.Add(new string[7]);
                    datan[datan.Count - 1][0] = readern[0].ToString();
                    datan[datan.Count - 1][1] = readern[1].ToString();
                    datan[datan.Count - 1][2] = readern[2].ToString();
                    datan[datan.Count - 1][3] = readern[3].ToString();
                    datan[datan.Count - 1][4] = readern[4].ToString();
                    datan[datan.Count - 1][5] = readern[5].ToString();
                }
                readern.Close();
                conn.Close();
                foreach (string[] s in datan)
                    dataGridView1.Rows.Add(s);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
          

            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                conn.Open();
              int  id3 = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand("Delete from Game_Inf where Id='" + id3 + "'", conn);
                SqlCommand cmd1 = new SqlCommand("Delete from Order1 where Game_Id = '" + id3 + "'", conn);
                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
                cmd.ExecuteNonQuery();
                cmd1.ExecuteNonQuery();
                conn.Close();
            }



        }

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                textBox1.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[1].Value);
                textBox2.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[2].Value);
                textBox3.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[3].Value);
                textBox4.Text = Convert.ToString(dataGridView1.SelectedRows[0].Cells[4].Value);
            }
            catch
            {
                MessageBox.Show("Выбери корретную строку");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
