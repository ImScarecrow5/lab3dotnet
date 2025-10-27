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
    public partial class Task7 : Form
    {
        public Task7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textBox1.Text, out int N) || N <= 0)
            {
                MessageBox.Show("Неверное значение (N > 0 и N - целое)", "Ошибка");
                return;
            }
            double sum = 0.0;
            int num_count = 0;
            for (int i = 1; i <= N; i++)
            {
                int P = N - i + 1;
                sum += Math.Pow(i, P);
            }
            label2.Text = $"Сумма ряда равна {sum}";
        }
    }
}
