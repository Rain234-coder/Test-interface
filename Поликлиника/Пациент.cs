using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Поликлиника
{
    public partial class Пациент : Form
    {
        public Пациент()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Расписание f = new Расписание();
            f.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Запись f = new Запись();
            f.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Отзыв f = new Отзыв();
            f.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Анализ f = new Анализ();
            f.Show();
            this.Hide();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://onedio.ru/news/test-kotoryj-povedaet-naskolko-zdorovyj-obraz-zhizni-vy-vedyote-35800");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Анализ_2 f = new Анализ_2();
            f.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Аптека f = new Аптека();
            f.Show();
            this.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {

        }
    }
}
