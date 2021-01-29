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
    public partial class Расписание : Form
    {
        public Расписание()
        {
            InitializeComponent();
        }

        private void Расписание_Load(object sender, EventArgs e)
        {
           SqlConnection cnn = new SqlConnection(ConfigurationManager.ConnectionStrings["Поликлиника"].ConnectionString);
           DataSet ds = new DataSet();
           SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand("Select * from Расписание", cnn);
            da.Fill(ds, "Расписание");
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void Расписание_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }
    }
}
