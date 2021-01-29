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
    public partial class Запись : Form
    {
        public Запись()
        {
            InitializeComponent();
        }
        DataSet ds;

        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlConnection cnn;
        SqlCommandBuilder bild;
        private void Запись_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
            ds = new DataSet();
            da = new SqlDataAdapter();
            da2 = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Врачи", cnn);
            da2.SelectCommand = new SqlCommand("Select * from Обращения", cnn);
            bild = new SqlCommandBuilder(da2);
            da.Fill(ds, "Врачи");
            comboBox1.DataSource = ds.Tables[0];
            comboBox1.ValueMember = "Id_врача";
            comboBox1.DisplayMember = "ФИО";
            comboBox1.SelectedIndex = -1;
            da2.Fill(ds, "Обращения");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            DataRow dr = ds.Tables["Обращения"].NewRow();
            dr[1] = dateTimePicker1.Value.Date;
            dr[2] = comboBox1.SelectedValue;
            dr[3] = textBox1.Text;
            dr[4] = textBox2.Text;
            dr[5] = textBox3.Text;
            dr[6] = dateTimePicker2.Value.Date;
            ds.Tables["Обращения"].Rows.Add(dr);
            da2.Update(ds.Tables["Обращения"]);
            MessageBox.Show("Вы успешно записались к врачу");
            this.Close();
        }

        private void Запись_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }
    }
}
