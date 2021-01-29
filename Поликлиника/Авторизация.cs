using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поликлиника
{
    public partial class Авторизация : Form
    {
        public Авторизация()
        {
            InitializeComponent();
        }
        SqlConnection cnn;
        private void Button1_Click(object sender, EventArgs e)
        {
            string CommandText = "SELECT Count(*) FROM  Пользователи WHERE Логин = '" + textBox1.Text + "' AND Пароль = '" + textBox2.Text + "'";

            SqlCommand myCommand = new SqlCommand(CommandText, cnn);
            cnn.Open();
            myCommand.ExecuteNonQuery();
            cnn.Close();
            SqlDataAdapter da = new SqlDataAdapter(myCommand);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                SqlDataAdapter da2 = new SqlDataAdapter();
                SqlDataAdapter da3 = new SqlDataAdapter();
                DataSet ds = new DataSet();
                da2.SelectCommand = new SqlCommand("Select [ФИО пациента], Обращения.[Дата рождения], Обращения.[Номер телефона],Обращения.Адрес, Дата from Врачи,Пользователи, Обращения where Врачи.Id_врача=Обращения.Id_врача and Пользователи.Id_пользователя=Врачи.Id_пользователя and Логин=@Log", cnn);
                da3.SelectCommand = new SqlCommand("Select * from Врачи,Пользователи where Пользователи.Id_пользователя=Врачи.Id_пользователя and Логин=@Log", cnn);
                if (textBox1.Text == "Petrova11")
                {
                    this.Hide();
                    Врач f = new Врач();
                    da2.SelectCommand.Parameters.Add("@Log", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    da3.SelectCommand.Parameters.Add("@Log", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    da2.Fill(ds, "Обращения");
                    da3.Fill(ds, "Врачи");
                    DataView dv = new DataView(ds.Tables["Обращения"]);
                    f.dataGridView3.ReadOnly = false;
                    f.button1.Visible = true;
                    f.dataGridView1.DataSource = dv;
                    f.comboBox1.DataSource = ds.Tables["Врачи"];
                    f.comboBox1.ValueMember = "Id_врача";
                    f.comboBox1.DisplayMember = "ФИО";
                    f.Show();

                }
                else
                {
                    this.Hide();
                    Врач f2 = new Врач();
                    da2.SelectCommand.Parameters.Add("@Log", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    da3.SelectCommand.Parameters.Add("@Log", SqlDbType.VarChar, 50).Value = textBox1.Text;
                    da2.Fill(ds, "Обращения");
                    da3.Fill(ds, "Врачи");
                    DataView dv2 = new DataView(ds.Tables["Обращения"]);
                    f2.tabControl1.TabPages[4].Parent = null;
                    f2.dataGridView1.DataSource = dv2;
                    f2.comboBox1.DataSource = ds.Tables["Врачи"];
                    f2.comboBox1.ValueMember = "Id_врача";
                    f2.comboBox1.DisplayMember = "ФИО";
                    f2.Show();

                }
            }
            else
                MessageBox.Show("Неверный логин или пароль");
        }

        private void Авторизация_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
        }
    }
}
