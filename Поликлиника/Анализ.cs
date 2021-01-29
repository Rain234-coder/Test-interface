using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поликлиника
{
    public partial class Анализ : Form
    {
        public Анализ()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = textBox8.Text;
            label26.Text = textBox9.Text;
            label29.Text = textBox10.Text;
            label32.Text = textBox11.Text;
            label35.Text = textBox12.Text;
            label38.Text = textBox13.Text;
            label41.Text = textBox14.Text;
            label44.Text = textBox15.Text;
            label7.Visible = true;
            if (label1.Text != "")
            {
                textBox8.Visible = false;
                if (Convert.ToInt32(label1.Text) >= Convert.ToInt32(label3.Text) && Convert.ToInt32(label1.Text) <= Convert.ToInt32(label2.Text))
                {
                    label1.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label1.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label1.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label26.Text != "")
            {

                textBox9.Visible = false;
                if (Convert.ToInt32(label26.Text) >= Convert.ToInt32(label27.Text) && Convert.ToInt32(label26.Text) <= Convert.ToInt32(label28.Text))
                {
                    label26.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label26.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label26.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label29.Text != "")
            {

                textBox10.Visible = false;
                if (Convert.ToInt32(label29.Text) >= Convert.ToInt32(label30.Text) && Convert.ToInt32(label29.Text) <= Convert.ToInt32(label31.Text))
                {
                    label29.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label29.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label29.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label32.Text != "")
            {

                textBox11.Visible = false;
                if (Convert.ToSingle(label32.Text) >= Convert.ToSingle(label33.Text) && Convert.ToSingle(label32.Text) <= Convert.ToSingle(label34.Text))
                {
                    label32.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label32.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label32.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label35.Text != "")
            {

                textBox12.Visible = false;
                if (Convert.ToSingle(label35.Text) >= Convert.ToSingle(label36.Text) && Convert.ToSingle(label35.Text) <= Convert.ToSingle(label37.Text))
                {
                    label35.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label35.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label35.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label38.Text != "")
            {

                textBox13.Visible = false;
                if (Convert.ToInt32(label38.Text) >= Convert.ToInt32(label39.Text) && Convert.ToInt32(label38.Text) <= Convert.ToInt32(label40.Text))
                {
                    label38.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label38.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label38.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label41.Text != "")
            {

                textBox14.Visible = false;
                if (Convert.ToSingle(label41.Text) >= Convert.ToSingle(label42.Text) && Convert.ToSingle(label41.Text) <= Convert.ToSingle(label43.Text))
                {
                    label41.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label41.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label41.ForeColor = System.Drawing.Color.Red;
                }
            }
            if (label44.Text != "")
            {

                textBox15.Visible = false;
                if (Convert.ToSingle(label44.Text) >= Convert.ToSingle(label45.Text) && Convert.ToSingle(label44.Text) <= Convert.ToSingle(label46.Text))
                {
                    label44.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label44.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label44.ForeColor = System.Drawing.Color.Red;
                }
            }



        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Visible = true;
            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox11.Visible = true;
            textBox12.Visible = true;
            textBox13.Visible = true;
            textBox14.Visible = true;
            textBox15.Visible = true;
            label1.Text = "";
            label26.Text = "";
            label29.Text = "";
            label32.Text = "";
            label35.Text = "";
            label38.Text = "";
            label41.Text = "";
            label44.Text = "";
            label7.Visible = false;
        }

        private void Анализ_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }

        private void Анализ_Load(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }
    }
}
