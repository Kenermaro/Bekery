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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Отобразите MessageBox с сформированным сообщением
            MessageBox.Show("Доставка ожидается в " + textBox1.Text + " по адресу " + textBox2.Text + " Номер телефона для связи " + textBox3.Text, "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
