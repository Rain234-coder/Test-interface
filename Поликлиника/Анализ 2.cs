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
    public partial class Анализ_2 : Form
    {
        public Анализ_2()
        {
            InitializeComponent();
        }

        private void Анализ_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = textBox8.Text;
            label26.Text = textBox9.Text;
            label29.Text = textBox10.Text;
            label32.Text = textBox11.Text;
            label35.Text = textBox12.Text;
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
                if (Convert.ToSingle(label26.Text) >= Convert.ToSingle(label27.Text) && Convert.ToSingle(label26.Text) <= Convert.ToSingle(label28.Text))
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
                if (Convert.ToInt32(label32.Text) >= Convert.ToInt32(label33.Text) && Convert.ToInt32(label32.Text) <= Convert.ToInt32(label34.Text))
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
                if (Convert.ToInt32(label35.Text) >= Convert.ToInt32(label36.Text) && Convert.ToInt32(label35.Text) <= Convert.ToInt32(label37.Text))
                {
                    label35.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular);
                }
                else
                {
                    label35.Font = new Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
                    label35.ForeColor = System.Drawing.Color.Red;
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
            label1.Text = "";
            label26.Text = "";
            label29.Text = "";
            label32.Text = "";
            label35.Text = "";
            label7.Visible = false;
        }

    }
    }

