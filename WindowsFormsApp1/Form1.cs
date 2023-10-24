using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private SQLiteConnection connection;

        public Form1()
        {
            InitializeComponent();
            // Инициализация подключения к базе данных
            connection = new SQLiteConnection("Data Source=C:\\Users\\user\\Desktop\\bakery\\VV1.db;");
            connection.Open();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Проверка введенных данных в базе данных
            string query = "SELECT * FROM Users WHERE Login = @username AND Password = @password";
            using (SQLiteCommand command = new SQLiteCommand(query, connection))
            {
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);

                using (SQLiteDataAdapter adapter = new SQLiteDataAdapter(command))
                {
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    if (dataTable.Rows.Count > 0)
                    {
                        // Если запись найдена, открыть Form2
                        Form2 form2 = new Form2();
                        form2.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Неверные учетные данные. Пожалуйста, попробуйте снова.");
                    }
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Закрытие подключения к базе данных при закрытии формы
            if (connection != null && connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            string username = textBoxUsername.Text;
            string password = textBoxPassword.Text;

            // Добавление новой записи в базу данных
            string insertQuery = "INSERT INTO Users (Login, Password) VALUES (@username, @password)";
            using (SQLiteCommand insertCommand = new SQLiteCommand(insertQuery, connection))
            {
                insertCommand.Parameters.AddWithValue("@username", username);
                insertCommand.Parameters.AddWithValue("@password", password);

                int rowsAffected = insertCommand.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Регистрация прошла успешно.");
                }
                else
                {
                    MessageBox.Show("Не удалось зарегистрироваться. Пожалуйста, попробуйте снова.");
                }
            }
        }
    }
}