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
    public partial class Itog : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=8Practos;Integrated Security=True");
        public Itog()
        {
            InitializeComponent();
        }

        private void notify1(String message)
        {
            notify1 dialog = new notify1(message);
            dialog.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *  From Game_Inf", conn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox2.Items.Add(dr["Name"].ToString());
            }


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *  From SAler", conn);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                listBox3.Items.Add(dr1["Name_Saler"].ToString());
            }
            conn.Open();
            string query1 = "SELECT * FROM Order1 ";
            SqlCommand command1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[3]);
                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();
            }
            reader1.Close();
            foreach (string[] s in data1)
                dataGridView2.Rows.Add(s);


           
           
                conn.Close();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string Game = "";
            string Saler = "";
           
            if (listBox2.SelectedItem == null)
            {
                return;
            }
            else 
            { 
               Game = listBox2.SelectedItem.ToString();
            }

            
            if (listBox3.SelectedItem == null)
            {
                return;
            }
            else
            {
                 Saler = listBox3.SelectedItem.ToString();
            }




            conn.Open();




            SqlCommand command = new SqlCommand("Select Id From Game_Inf where Name=@name", conn);
            command.Parameters.Add("@name", SqlDbType.Char,100).Value = Game;
            command.Prepare();
            int go =(Int32) command.ExecuteScalar();

            SqlCommand command21 = new SqlCommand("Select Id from SAler where Name_Saler=@Saler", conn);
            command21.Parameters.Add("@Saler", SqlDbType.Char,100).Value=Saler;
            command21.Prepare();
            var go1 =(Int32) command21.ExecuteScalar();

            SqlCommand gg = new SqlCommand("INSERT into Order1(Game_Id,Saler_Id) values(@gmid,@sid)", conn);
            gg.Parameters.Add("@gmid", SqlDbType.Char, 100).Value = go;
            gg.Parameters.Add("@sid", SqlDbType.Char, 100).Value = go1;
            gg.ExecuteNonQuery();




            dataGridView2.Rows.Clear();
            string query1 = "SELECT * FROM Order1 ";
            SqlCommand command1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[3]);
                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();
            }



            reader1.Close();



            //procedure

          

            SqlCommand jh = new SqlCommand("Count1", conn);
            jh.CommandType = CommandType.StoredProcedure;
            string str = Convert.ToString(jh.ExecuteScalar());  //tut procedure
            label3.Text = "Всего строк= " + str;




            //
            conn.Close();
            foreach (string[] s in data1)
                dataGridView2.Rows.Add(s);

            notify1("Успешно добавлено");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void Itog_Load(object sender, EventArgs e)
        {
            


            dataGridView2.EnableHeadersVisualStyles = false;

            dataGridView2.Rows.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select *  From Game_Inf", conn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                listBox2.Items.Add(dr["Name"].ToString());
            }


            DataTable dt1 = new DataTable();
            SqlDataAdapter da1 = new SqlDataAdapter("Select *  From SAler", conn);
            da1.Fill(dt1);
            foreach (DataRow dr1 in dt1.Rows)
            {
                listBox3.Items.Add(dr1["Name_Saler"].ToString());
            }
            conn.Open();
            string query1 = "SELECT * FROM Order1 ";
            SqlCommand command1 = new SqlCommand(query1, conn);
            SqlDataReader reader1 = command1.ExecuteReader();
            List<string[]> data1 = new List<string[]>();
            while (reader1.Read())
            {
                data1.Add(new string[3]);
                data1[data1.Count - 1][0] = reader1[0].ToString();
                data1[data1.Count - 1][1] = reader1[1].ToString();
                data1[data1.Count - 1][2] = reader1[2].ToString();
            }
            reader1.Close();

            //procedure

            SqlCommand jh = new SqlCommand("Count1", conn);
            jh.CommandType = CommandType.StoredProcedure;
            string str = Convert.ToString(jh.ExecuteScalar());  //tut procedure
            label3.Text = "Всего строк= " + str;


            conn.Close();
            foreach (string[] s in data1)
                dataGridView2.Rows.Add(s);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView2.SelectedRows)
            {
                conn.Open();
                int idOrder = Convert.ToInt32(dataGridView2.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd2 = new SqlCommand("Delete from Order1 where Order_Id=@idord", conn);
                cmd2.Parameters.Add("@idord", SqlDbType.Int, 100).Value = idOrder;
                cmd2.Prepare();
                cmd2.ExecuteNonQuery();
                

                //proc

                SqlCommand jh = new SqlCommand("Count1", conn);
                jh.CommandType = CommandType.StoredProcedure;
                string str = Convert.ToString(jh.ExecuteScalar());  //tut procedure
                label3.Text = "Всего строк= " + str;
                //


                conn.Close();
                dataGridView2.Rows.RemoveAt(this.dataGridView2.SelectedRows[0].Index);
                notify1("Успешно удалено");
            }
        }
    }
}
