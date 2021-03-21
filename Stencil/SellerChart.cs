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

namespace Stencil
{
    public partial class SellerChart : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=DESKTOP-1B8H9A7\\JIJA;Initial Catalog=8Practos;Integrated Security=True");
        public SellerChart()
        {
            InitializeComponent();
        }

        private void SellerChart_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();

            

        //    chart1.ChartAreas.Series["Количество проданных игр"].AxisX.LabelStyle.Fon  = new System.Drawing.Font("Trebuchet MS", 2.25F, System.Drawing.FontStyle.Bold);


            conn.Open();
            /*
             Суть в чем
            Я вытаскиваю количество работников, это будет для цикла фор
            Потом по гридВию я вытаскиваю нужное количество благодарю фору Это заполнилась Х

            Потом я тащу колиечство записей по имени и заношу в в строку Это заполнилась Y
             
             */
            SqlCommand command21 = new SqlCommand("Select count(Name_Saler) from SAler", conn);
            command21.Prepare();
            var go1 = (Int32)command21.ExecuteScalar();

            //забираю имена и вставляю их в список
            List<string> test2 = new List<string>();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from SAler", conn);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                test2.Add(dr["Name_Saler"].ToString());
            }


            List<int> num5 = new List<int>();

           for (int i = 0; i < go1; i++)
            {
                SqlCommand takeCount = new SqlCommand("Select Count(Name_Saler) from Dtag where Name_Saler ='"+test2[i]+"'", conn);
                var count = (Int32)takeCount.ExecuteScalar();
                num5.Add(count);

            }




            //    this.chart1.Series["Количество проданных игр"].Points.AddXY("Рожок",4);

            for (int i = 0; i < go1; i++)
            {
                this.chart1.Series["Количество проданных игр"].Points.AddXY(test2[i], num5[i]);//hmm
            }

            conn.Close();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
