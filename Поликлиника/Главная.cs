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
    public partial class Главная : Form
    {
        public Главная()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Bitmap image1 = new Bitmap("D://Интерфейсы//Поликлиника//Поликлиника//Resources//Эмблема.png");
            pictureBox1.Size = new System.Drawing.Size(100, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image1;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Пациент f = new Пациент();
            f.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Авторизация f = new Авторизация();
            f.Show();
        }
    }
}