using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laba3net
{
    public partial class Task4 : Form
    {
        public Task4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (!double.TryParse(textBox1.Text, out double eps) || eps <= 0 || eps > 1)
            {
                MessageBox.Show("Введена неверная точность", "Ошибка");
                return;
            }
            double sum = 0.0;
            double num = 1.0;
            int n = 1;
            int num_count = 0;

            while (num >= eps)
            {
                sum += num;
                num_count++;
                n = n * (n+1);
                num = num / Math.Sqrt(n);
            }
            label2.Text = $"Сумма ряда равна {sum}";
            label3.Text = $"Количество слагаемых - {num_count}";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
