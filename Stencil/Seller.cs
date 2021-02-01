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
    public partial class Seller : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=8Practos;Integrated Security=True");
        public Seller()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" || textBox6.Text=="")
            {

            }
            else { 
            conn.Open();

            SqlCommand cmd = new SqlCommand("INSERT into Saler(Name_Saler,Mail) values (@name,@mail)", conn);
            SqlParameter idParam = new SqlParameter("@name", SqlDbType.Text, 100);
            SqlParameter descParam = new SqlParameter("@mail", SqlDbType.Char, 100);
            idParam.Value = textBox5.Text;
            descParam.Value = textBox6.Text;
            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(descParam);
            cmd.Prepare();
            cmd.ExecuteNonQuery();

            dataGridView3.Rows.Clear();
            string query2 = "SELECT * FROM SAler ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<string[]> data2 = new List<string[]>();
            while (reader2.Read())
            {
                data2.Add(new string[3]);

                data2[data2.Count - 1][0] = reader2[0].ToString();
                data2[data2.Count - 1][1] = reader2[1].ToString();
                data2[data2.Count - 1][2] = reader2[2].ToString();

            }
            reader2.Close();
            conn.Close();
            foreach (string[] s in data2)
                dataGridView3.Rows.Add(s);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            int idSaler = 0;
            try { 
             idSaler = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);
            }
            catch
            {
            }


       //ready for use
            SqlCommand cmd = new SqlCommand("UPDATE Saler SET Name_Saler=@name,Mail=@mail where Id=@idi", conn);
            SqlParameter idParam = new SqlParameter("@name", SqlDbType.Char, 100);
            SqlParameter descParam = new SqlParameter("@mail", SqlDbType.Char, 100);
            cmd.Parameters.Add("@idi", SqlDbType.Int).Value = idSaler;     //  idid.Value = idSaler;
            idParam.Value = textBox5.Text;
            descParam.Value = textBox6.Text;
            cmd.Parameters.Add(idParam);
            cmd.Parameters.Add(descParam);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            ///




            dataGridView3.Rows.Clear();



            string query2 = "SELECT * FROM SAler ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<string[]> data2 = new List<string[]>();
            while (reader2.Read())
            {
                data2.Add(new string[3]);
                data2[data2.Count - 1][0] = reader2[0].ToString();
                data2[data2.Count - 1][1] = reader2[1].ToString();
                data2[data2.Count - 1][2] = reader2[2].ToString();

            }
            reader2.Close();
            conn.Close();
            foreach (string[] s in data2)
                dataGridView3.Rows.Add(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView3.SelectedRows)
            {
                conn.Open();
 int idSaler = Convert.ToInt32(dataGridView3.SelectedRows[0].Cells[0].Value);




                // SqlCommand cmd = new SqlCommand("UPDATE Saler SET Name_Saler=@name,Mail=@mail where Id=@idi", conn);
                // .    SqlParameter idParam = new SqlParameter("@name", SqlDbType.Char, 100);
                //    SqlParameter descParam = new SqlParameter("@mail", SqlDbType.Char, 100);
                SqlCommand cmd6 = new SqlCommand("Delete from Order1 where Saler_Id = @idSaler", conn);
                cmd6.Parameters.Add("@idSaler", SqlDbType.Int).Value = idSaler;     //  это присваивание сразу и add пармаметр то есть вместо   idParam.Value = textBox5.Text; и   cmd.Parameters.Add(idParam);
                cmd6.Prepare();
                cmd6.ExecuteNonQuery();  

                SqlCommand cmd5 = new SqlCommand("Delete from Saler where Id=@idSaler", conn);
                cmd5.Parameters.Add("@idSaler", SqlDbType.Int).Value = idSaler;
                cmd5.Prepare();
                cmd5.ExecuteNonQuery();


                //RABOTAET



                //   SqlCommand cmd5 = new SqlCommand("Delete from Saler where Id='" + idSaler + "'", conn);
                //  SqlCommand cmd6 = new SqlCommand("Delete from Order1 where Saler_Id = '" + idSaler + "'", conn);
                dataGridView3.Rows.RemoveAt(this.dataGridView3.SelectedRows[0].Index);
              //  cmd6.ExecuteNonQuery();
              //  cmd5.ExecuteNonQuery();
                conn.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //change color of head
          //  dataGridView3.ColumnHeadersDefaultCellStyle.BackColor = Color.Red;
          //  dataGridView3.EnableHeadersVisualStyles = false;



            conn.Open();
            dataGridView3.Rows.Clear();
            string query2 = "SELECT * FROM SAler ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<string[]> data2 = new List<string[]>();
            while (reader2.Read())
            {
                data2.Add(new string[3]);
                data2[data2.Count - 1][0] = reader2[0].ToString();
                data2[data2.Count - 1][1] = reader2[1].ToString();
                data2[data2.Count - 1][2] = reader2[2].ToString();

            }
            reader2.Close();
            conn.Close();
            foreach (string[] s in data2)
                dataGridView3.Rows.Add(s);
        }

        private void Seller_Load(object sender, EventArgs e)
        {


            dataGridView3.EnableHeadersVisualStyles = false;

            conn.Open();

            //Proverka polzovatelya
            string das = Login.Value1;
            string zapros = "Select status From Users Where username='" + das + "'";




            //procedure
        //    SqlCommand jh = new SqlCommand(zapros, conn);  //делаем установку с командой и путем
       //     string str = Convert.ToString(jh.ExecuteScalar());//извлекаем результат
       //     MessageBox.Show(str);//выводми

            //


            //
            dataGridView3.Rows.Clear();
            string query2 = "SELECT * FROM SAler ";
            SqlCommand command2 = new SqlCommand(query2, conn);
            SqlDataReader reader2 = command2.ExecuteReader();
            List<string[]> data2 = new List<string[]>();
            while (reader2.Read())
            {
                data2.Add(new string[3]);
                data2[data2.Count - 1][0] = reader2[0].ToString();
                data2[data2.Count - 1][1] = reader2[1].ToString();
                data2[data2.Count - 1][2] = reader2[2].ToString();

            }
            reader2.Close();
            conn.Close();
            foreach (string[] s in data2)
                dataGridView3.Rows.Add(s);


            

        }

        private void dataGridView3_Click(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = Convert.ToString(dataGridView3.SelectedRows[0].Cells[1].Value);
                textBox6.Text = Convert.ToString(dataGridView3.SelectedRows[0].Cells[2].Value);
            }
            catch
            {
            }
        }
    }
}
