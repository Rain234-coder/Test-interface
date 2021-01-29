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
    public partial class Аптека : Form
    {
        public Аптека()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataView dv;

        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlDataAdapter da3;
        SqlConnection cnn;
        SqlCommandBuilder bild;
        SqlCommandBuilder bild2;
        private void Аптека_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }

        private void Аптека_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
            ds = new DataSet();
            da = new SqlDataAdapter();
            da2 = new SqlDataAdapter();
            da3 = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Аптека", cnn);
            da2.SelectCommand = new SqlCommand("Select * from Лекарства", cnn);
            da3.SelectCommand = new SqlCommand("Select * from Аптека_лекарства", cnn);
            bild = new SqlCommandBuilder(da);
            bild2 = new SqlCommandBuilder(da3);
            da.Fill(ds, "Аптека");
            da2.Fill(ds, "Лекарства");
            da3.Fill(ds, "Аптека_лекарства");
            comboBox1.DataSource = ds.Tables["Лекарства"];
            comboBox1.ValueMember = "Id_лекарства";
            comboBox1.DisplayMember = "Название";
            comboBox1.SelectedIndex = -1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Аптека"].NewRow();
            dr[1] = textBox1.Text;
            dr[2] = textBox2.Text;
            dr[3] = textBox3.Text;
            dr[4] = textBox4.Text;
            dr[5] = textBox5.Text;
            ds.Tables["Аптека"].Rows.Add(dr);
            da.Update(ds.Tables["Аптека"]);
            ds.Clear();
            da.Fill(ds, "Аптека");
            da2.Fill(ds, "Лекарства");
            da3.Fill(ds, "Аптека_лекарства");
            string sqlSel = "Select top 1 * from Аптека order by Id_заказа desc";
            SqlDataReader sdr = null;
            SqlCommand cmdSel = new SqlCommand(sqlSel, cnn);
            cnn.Open();
            sdr = cmdSel.ExecuteReader();
            while (sdr.Read())
            {
                label6.Text = sdr["Id_заказа"].ToString();
            }
            cmdSel.Dispose();
            cmdSel = null;
            cnn.Close();
            while (listBox1.Items.Count>0)
            {
                DataRow dr2 = ds.Tables["Аптека_лекарства"].NewRow();
                dr2[0] = label6.Text;
                dr2[1] = listBox1.Items[0];
                ds.Tables["Аптека_лекарства"].Rows.Add(dr2);
                da3.Update(ds.Tables["Аптека_лекарства"]);
                ds.Clear();
                da.Fill(ds, "Аптека");
                da2.Fill(ds, "Лекарства");
                da3.Fill(ds, "Аптека_лекарства");
                listBox1.Items.Remove(listBox1.Items[0]);
                listBox2.Items.Remove(listBox2.Items[0]);
                listBox3.Items.Remove(listBox3.Items[0]);
            }
            MessageBox.Show("Заказ принят, мы свяжемся с Вами в ближайшее время");
            textBox1.Text="";
            textBox2.Text="";
            textBox3.Text="";
            textBox4.Text="";
            textBox5.Text="";
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.SelectedValue);
            comboBox1.ValueMember = "Название";
            listBox2.Items.Add(comboBox1.SelectedValue);
            comboBox1.ValueMember = "Цена";
            listBox3.Items.Add(comboBox1.SelectedValue);
            comboBox1.ValueMember = "Id_лекарства";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
        }
    }
}
