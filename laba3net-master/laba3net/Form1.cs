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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double it = Convert.ToDouble(textBox1.Text);

                double count = 0;

                for (double i = 1; i <= 8; i += it)
                {
                    count += i * i - 7 * i + 1;
                }

                MessageBox.Show($"Ответ: {count}");
            }
            catch
            {
                MessageBox.Show($"Неверный формат данных!");
            }
        }
    }
}
