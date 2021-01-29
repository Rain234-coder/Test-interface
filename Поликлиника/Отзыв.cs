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
    public partial class Отзыв : Form
    {
        public Отзыв()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Отзывы"].NewRow();
            dr[1] = textBox1.Text;
            ds.Tables["Отзывы"].Rows.Add(dr);
            da.Update(ds.Tables[0]);
            MessageBox.Show("Спасибо за ваш отзыв!");
            this.Hide();
        }
        SqlConnection cnn;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder bild;
        private void Отзыв_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Отзывы", cnn);
            ds = new DataSet();
            da.Fill(ds,"Отзывы");
            bild = new SqlCommandBuilder(da);
        }

        private void Отзыв_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }
    }
}
