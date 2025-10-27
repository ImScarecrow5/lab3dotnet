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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int it = Convert.ToInt32(textBox1.Text);
                int a = 0;

                int ch = it / 10 % 10;

                int count = 0;
                while (it != 0)
                {
                    a = it % 10;
                    it /= 10;
                    if (a > ch) ++count;
                }

                MessageBox.Show($"Ответ: {count}");
            }
            catch
            {
                MessageBox.Show($"Неверный формат данных!");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
