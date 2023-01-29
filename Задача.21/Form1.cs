using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Задача._21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a=0, b=0, c=0, d=0, x1=0, x2=0, n=0, symm_chet = 0, symm_nchet = 0, x, fx, R=0, R1, xr1=0, xr2 = 0;
            int i;
            //Выводим сообщение об ошибке, если не соблюдены условия
            if (coef_a.Text == "a" || coef_b.Text == "b" || coef_c.Text == "c" || coef_d.Text == "d" || bord_right.Text == "x1" || bord_left.Text == "x2" || num_part.Text == "n") MessageBox.Show("Введите корректные значения.");
            else if ((coef_a.Text == "0" && coef_b.Text == "0" && coef_c.Text == "0") || num_part.Text == "0") MessageBox.Show("Введите корректные значения.");
            else if (bord_right.Text == bord_left.Text) MessageBox.Show("Введите корректные значения.");
            else
            {
                //Инициализируем переменные
                a = Convert.ToDouble(coef_a.Text);
                b = Convert.ToDouble(coef_b.Text);
                c = Convert.ToDouble(coef_c.Text);
                d = Convert.ToDouble(coef_d.Text);
                x1 = Convert.ToDouble(bord_right.Text);
                x2 = Convert.ToDouble(bord_left.Text);
                n = Convert.ToDouble(num_part.Text);

                //Создаём поле и оси координат
                Bitmap bmp = new Bitmap(460, 320);
                Graphics gr = Graphics.FromImage(bmp);
                Pen myPen = new Pen(Color.Black);
                Pen myPen1 = new Pen(Color.Black, 5);
                gr.DrawLine(myPen, 0, pictureBox1.Size.Height / 2, pictureBox1.Size.Width, pictureBox1.Size.Height / 2);
                gr.DrawLine(myPen, pictureBox1.Size.Width / 2, 0, pictureBox1.Size.Width / 2, pictureBox1.Size.Height);

                x = x2;

                //Задаём начальные точки графического отображения метода Симпсона
                xr2 = x * 10 + pictureBox1.Size.Width / 2;
                R1 = -((x1 - x2) * (a * (Math.Pow(x1, 3) + Math.Pow(x2, 3)) + b * (Math.Pow(x1, 2) + Math.Pow(x2, 2)) + c * (x1 + x2) + 2 * d + 4 * symm_nchet + 2 * symm_chet) / (6 * n)) / 10 + pictureBox1.Size.Height / 2;

                for (i = 1; i <= 2 * n; i++)
                {
                    x += (x1 - x2) / (2 * n);
                    fx = a * Math.Pow(x, 3) + b + Math.Pow(x, 2) + c * x + d;
                    if (i % 2 == 1) symm_nchet += fx;
                    else symm_chet += fx;

                    //Реализуем графическое отображение метода Симпсона
                    R = -((x1 - x2) * (a * (Math.Pow(x1, 3) + Math.Pow(x2, 3)) + b * (Math.Pow(x1, 2) + Math.Pow(x2, 2)) + c * (x1 + x2) + 2 * d + 4 * symm_nchet + 2 * symm_chet) / (6 * n)) / 10 + pictureBox1.Size.Height / 2;
                    xr1 = xr2;
                    xr2 = x * 10 + pictureBox1.Size.Width / 2;
                    gr.DrawLine(myPen, (float)xr1, (float)R1, (float)xr2, (float)R);

                    //Реализуем графическое отображение площадей разбиения
                    if (i == 1) gr.DrawLine(myPen, (float)xr1, pictureBox1.Size.Height / 2, (float)xr1, (float)R1);
                    else if (i % 2 == 0) gr.DrawLine(myPen, (float)xr2, pictureBox1.Size.Height / 2, (float)xr2, (float)R);

                    R1 = R;
                }

                //Считаем ответ по формуле
                R = (x1 - x2) * (a * (Math.Pow(x1, 3) + Math.Pow(x2, 3)) + b * (Math.Pow(x1, 2) + Math.Pow(x2, 2)) + c * (x1 + x2) + 2 * d + 4 * symm_nchet + 2 * symm_chet) / (6 * n);

                //Выводим ответ и график
                answer.Text = R.ToString();
                pictureBox1.Image = bmp;
            }
        }

        //Убираем изначальные текстовые обозначения при клике на textbox
        private void coef_a_Click(object sender, EventArgs e)
        {
            string a = coef_a.Text;
            if (a == "a") coef_a.Clear();
        }

        private void coef_b_Click(object sender, EventArgs e)
        {
            string b = coef_b.Text;
            if (b == "b") coef_b.Clear();
        }

        private void coef_c_Click(object sender, EventArgs e)
        {
            string c = coef_c.Text;
            if (c == "c") coef_c.Clear();
        }

        private void coef_d_Click(object sender, EventArgs e)
        {
            string d = coef_d.Text;
            if (d == "d") coef_d.Clear();
        }

        private void bord_right_Click(object sender, EventArgs e)
        {
            string x1 = bord_right.Text;
            if (x1 == "x1") bord_right.Clear();
        }

        private void bord_left_Click(object sender, EventArgs e)
        {
            string x2 = bord_left.Text;
            if (x2 == "x2") bord_left.Clear();
        }

        private void num_part_Click(object sender, EventArgs e)
        {
            string n = num_part.Text;
            if (n == "n") num_part.Clear();
        }


        //Запрещаем вводить символы с клавиатуры кроме цифр
        private void coef_a_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    if (!(Char.IsDigit(e.KeyChar)) && (e.KeyChar != 45) && (e.KeyChar != (char)Keys.Back)) e.Handled = true;
                }
            }
        }

        private void num_part_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)))
            {
                if (e.KeyChar != (char)Keys.Back)
                {
                    e.Handled = true;
                }
            }
        }
    }
}
