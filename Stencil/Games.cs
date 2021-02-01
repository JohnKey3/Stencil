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
            dataGridView1.EnableHeadersVisualStyles = false; //Чтоб цвета применялись Какой-то рудмиент от Экспишки, эх вот раньше были игры на экспишки D:

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
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" )
            {

            }
            else
            {
                if ( textBox4.Text == "")
                {
                    textBox4.Text = "0";
                }
                conn.Open();
                dataGridView1.Rows.Clear();
                SqlCommand cmd5 = new SqlCommand("INSERT into Game_Inf(Name,Descr,Price,Sale) values(@Name,@Descr,@Price,@Sale)", conn);
                SqlParameter sd1 = new SqlParameter("@Name", SqlDbType.Char, 100);
                    sd1.Value = textBox1.Text;
                cmd5.Parameters.Add(sd1);
                SqlParameter sd2 = new SqlParameter("@Descr", SqlDbType.Text, 100);
                sd2.Value = textBox2.Text;
                cmd5.Parameters.Add(sd2);
                SqlParameter sd3 = new SqlParameter("@Price", SqlDbType.Int);
                sd3.Value = textBox3.Text;
                cmd5.Parameters.Add(sd3);
                SqlParameter sd4 = new SqlParameter("@Sale", SqlDbType.Int, 100);
                sd4.Value = textBox4.Text;
                cmd5.Parameters.Add(sd4);
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();
                //   SqlCommand cmd = new SqlCommand("INSERT into Game_Inf(Name,Descr,Price,Sale) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "') ", conn);

                //  cmd.ExecuteNonQuery();




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


                SqlCommand cmd51 = new SqlCommand("UPDATE Game_Inf SET Name=@NAme,Descr=@Descr,Price=@Price,Sale=@Sale where Id=@IdGame", conn);
                cmd51.Parameters.Add("@IdGame", SqlDbType.Int).Value = idgame;
                SqlParameter sd11 = new SqlParameter("@Name", SqlDbType.Char, 100);
                sd11.Value = textBox1.Text;
                cmd51.Parameters.Add(sd11);
                SqlParameter sd21 = new SqlParameter("@Descr", SqlDbType.Text, 100);
                sd21.Value = textBox2.Text;
                cmd51.Parameters.Add(sd21);
                SqlParameter sd31 = new SqlParameter("@Price", SqlDbType.Int);
                sd31.Value = textBox3.Text;
                cmd51.Parameters.Add(sd31);
                SqlParameter sd41 = new SqlParameter("@Sale", SqlDbType.Int, 100);
                sd41.Value = textBox4.Text;
                cmd51.Parameters.Add(sd41);
                cmd51.Prepare();
                cmd51.ExecuteNonQuery();



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



                //Два случая использования параметра, через присваивание и через передачу параметра

                SqlCommand cmd = new SqlCommand("Delete from Game_Inf where Id=@Game", conn);
                SqlCommand cmd1 = new SqlCommand("Delete from Order1 where Game_Id =@Game1", conn);

          
                cmd1.Parameters.Add("@Game1", SqlDbType.Int).Value = id3;

                SqlParameter sd41 = new SqlParameter("@Game", SqlDbType.Int, 100);
                sd41.Value = id3;
                cmd.Parameters.Add(sd41);

                cmd.Prepare();
                cmd.ExecuteNonQuery();
                cmd1.Prepare();
                cmd1.ExecuteNonQuery();


                dataGridView1.Rows.RemoveAt(this.dataGridView1.SelectedRows[0].Index);
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
