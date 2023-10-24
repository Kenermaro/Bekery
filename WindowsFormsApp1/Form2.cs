using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label2.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label6.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Получите числа из label2 и label3, прибавьте их и установите результат в label2
            if (int.TryParse(label9.Text, out int num1) && int.TryParse(label3.Text, out int num2))
            {
                int result = num1 + num2;
                label3.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите корректные числа в метки (label2 и label3).");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Если запись найдена, открыть Form2
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }
}
