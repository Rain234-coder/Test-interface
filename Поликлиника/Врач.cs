using Microsoft.SqlServer.Server;
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
    public partial class Врач : Form
    {
        public Врач()
        {
            InitializeComponent();
        }
        DataSet ds;
        DataView dv;

        SqlDataAdapter da;
        SqlDataAdapter da2;
        SqlDataAdapter da4;
        SqlConnection cnn;
        SqlCommandBuilder bild;
        private void Врач_Load(object sender, EventArgs e)
        {
            cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
            ds = new DataSet();
            da = new SqlDataAdapter();
            da2 = new SqlDataAdapter();
            da4 = new SqlDataAdapter();
            da2.SelectCommand = new SqlCommand("Select * from Осмотры where Id_врача=@Id", cnn);
            da2.DeleteCommand = new SqlCommand("Delete from Осмотры where Id_осмотра=@Id", cnn);
            da4.SelectCommand = new SqlCommand("Select * from Отзывы", cnn);
            da4.Fill(ds, "Отзывы");
            da.SelectCommand = new SqlCommand("select * from Расписание", cnn);
            da.UpdateCommand = new SqlCommand("UPDATE Расписание Set Понедельник=@Pn, Вторник=@Vt, Среда=@Sr, Четверг=@Ch, Пятница=@Pt where ФИО,должность=@all", cnn);

            bild = new SqlCommandBuilder(da2);
            da2.SelectCommand.Parameters.AddWithValue("@Id", comboBox1.SelectedValue);
            da2.DeleteCommand.Parameters.Add("@Id", SqlDbType.Int, 20, "Id_осмотра");
            da.UpdateCommand.Parameters.Add("@Pn", SqlDbType.VarChar, 20, "Понедельник");
            da.UpdateCommand.Parameters.Add("@Vt", SqlDbType.VarChar, 20, "Вторник");
            da.UpdateCommand.Parameters.Add("@Sr", SqlDbType.VarChar, 20, "Среда");
            da.UpdateCommand.Parameters.Add("@Ch", SqlDbType.VarChar, 20, "Четверг");
            da.UpdateCommand.Parameters.Add("@Pt", SqlDbType.VarChar, 20, "Пятница");
            da.UpdateCommand.Parameters.Add("@all", SqlDbType.VarChar, 100, "ФИО,должность");
            da.Fill(ds, "Расписание");
            da2.Fill(ds, "Осмотры");

            dv = new DataView(ds.Tables["Расписание"]);
            dataGridView3.DataSource = dv;
            dataGridView3.Columns[0].HeaderText = "ФИО, должность";
            dataGridView2.DataSource = ds.Tables["Отзывы"];
            dataGridView4.DataSource = ds.Tables["Осмотры"];
            dataGridView4.Columns[1].Visible = false;
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataGridView2.Columns[1].Width = 120;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            da.Update(ds, "Расписание");
            ds.Clear();
            da.Fill(ds, "Расписание");
            da2.Fill(ds, "Осмотры");
            da4.Fill(ds, "Отзывы");
            dv = new DataView(ds.Tables["Расписание"]);
            dataGridView3.DataSource = dv;
            dataGridView4.DataSource = ds.Tables["Осмотры"];
            dataGridView4.Columns[1].Visible = false;
            dataGridView2.DataSource = ds.Tables["Отзывы"];
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            DataRow dr = ds.Tables["Осмотры"].NewRow();
            dr[1] = comboBox1.SelectedValue;
            dr[2] = dateTimePicker1.Value.Date;
            dr[3] = textBox1.Text;
            dr[4] = textBox2.Text;
            dr[5] = textBox3.Text;
            dr[6] = dateTimePicker2.Value.Date;
            dr[7] = textBox5.Text;
            dr[8] = textBox6.Text;
            dr[9] = textBox4.Text;
            dr[10] = textBox7.Text;
            ds.Tables["Осмотры"].Rows.Add(dr);
            da2.Update(ds.Tables["Осмотры"]);
            MessageBox.Show("Данные сохранены");
            ds.Clear();
            da.Fill(ds, "Расписание");
            da2.Fill(ds, "Осмотры");
            da4.Fill(ds, "Отзывы");
            dv = new DataView(ds.Tables["Расписание"]);
            dataGridView3.DataSource = dv;
            dataGridView4.DataSource = ds.Tables["Осмотры"];
            dataGridView4.Columns[1].Visible = false;
            dataGridView2.DataSource = ds.Tables["Отзывы"];
        }

        private void Врач_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tabControl1.TabCount == 1)
            {
                Пациент f = new Пациент();
                f.Show();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            da2.Update(ds, "Осмотры");
            ds.Clear();
            da.Fill(ds, "Расписание");
            da2.Fill(ds, "Осмотры");
            da4.Fill(ds, "Отзывы");
            dv = new DataView(ds.Tables["Расписание"]);
            dataGridView3.DataSource = dv;
            dataGridView4.DataSource = ds.Tables["Осмотры"];
            dataGridView4.Columns[1].Visible = false;
            dataGridView2.DataSource = ds.Tables["Отзывы"];
        }

        private void dataGridView4_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
        }



    }
}
