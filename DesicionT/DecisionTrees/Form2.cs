using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
namespace DecisionTrees
{
    public partial class Form1 : Form
    {
        public int[,] dataArray1 = new int[14, 7];
        public string[,] dataArray = new string[14, 7];
        public static Form1 S = null;
        public Form1()
        {
            InitializeComponent();
            S = this;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(GetConnectString()))
            {
                string serverAdress, Id, passWord;
                SqlConnection con = new SqlConnection();
                SqlCommand cmd = conn.CreateCommand();
               //serverAdress = textBox1.Text;
                Id = textBox2.Text;
                passWord = textBox3.Text;
                try
                {
                    con.ConnectionString = "server=.;database=决策树实验数据库;uid=sa;pwd=1";
                    //con.ConnectionString = "server=" + serverAdress + ";database=决策树实验数据库;uid=" + Id + ";pwd=" + passWord;
                    con.Open();
                    MessageBox.Show("数据库连接成功");
                    cmd.Connection = con;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("数据库连接失败,失败原因：" + ex.Message);
                }
                cmd.CommandText = "SELECT * FROM 天气决策树";
                //从数据库中读取数据流存入reader中  
                SqlDataReader reader = cmd.ExecuteReader();
                //从reader中读取下一行数据,如果没有数据,reader.Read()返回flase  
                int i = 0;
                while (reader.Read())
                {
                    dataArray1[i, 5] = reader.GetInt32(0);
                    for (int j = 0; j < 5; j++)
                    {
                        dataArray1[i, j] = reader.GetInt32(j + 1);
                        //MessageBox.Show(Convert.ToString(dataArray1[i, j]));
                    }
                    i++;
                }
            }
            for (int i = 0; i < 14; i++)
            {
                if (dataArray1[i, 0] == 1) dataArray[i, 0] = "Sunny";
                else if (dataArray1[i, 0] == 2) dataArray[i, 0] = "overcast";
                else if (dataArray1[i, 0] == 3) dataArray[i, 0] = "rain";

                if (dataArray1[i, 1] == 1) dataArray[i, 1] = "hot";
                else if (dataArray1[i, 1] == 2) dataArray[i, 1] = "mild";
                else if (dataArray1[i, 1] == 3) dataArray[i, 1] = "cool";

                if (dataArray1[i, 2] == 1) dataArray[i, 2] = "high";
                else if (dataArray1[i, 1] == 2) dataArray[i, 2] = "normal";

                if (dataArray1[i, 3] == 1) dataArray[i, 3] = "TRUE";
                else if (dataArray1[i, 3] == 2) dataArray[i, 3] = "FALSE";

                if (dataArray1[i, 4] == 1) dataArray[i, 4] = "Yes";
                else if (dataArray1[i, 4] == 2) dataArray[i, 4] = "No";
            }
            DecisionTreeForm Form2 = new DecisionTreeForm();
            Form2.Show();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        static string GetConnectString()
        {
            return "Data Source=(local);Initial Catalog=db1;Integrated Security=SSPI;";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void Form1_Load_3(object sender, EventArgs e)
        {

        }
    }
}
