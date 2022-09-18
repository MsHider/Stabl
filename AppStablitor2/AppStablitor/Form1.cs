using System;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace AppStablitor
{
    public partial class Form1 : Form
    {
        // Строка подключения
        public static string connectionString = "Server=DESKTOP-DIDA0LC;Database=DB_stabl;Trusted_Connection=True;TrustServerCertificate=True";
        public static int indUser;
        SqlConnection con = new SqlConnection(connectionString);

        public Form1()
        {
            InitializeComponent();
        }
        // Регистрация пользователя
        private void btReg_Click(object sender, EventArgs e)
        {
            if ((tFIO.Text.Length * tSport.Text.Length * tNewLogin.Text.Length * tNewPass.Text.Length * nAge.Value) > 0)
            {
                try 
                {
                    // Открываем подключение и проверяем существует ли такой пользователь
                    con.Open();
                    //------------------------
                    string sqlString = "SELECT * FROM users WHERE login = '" + tNewLogin.Text + "'";
                    SqlCommand comm = new SqlCommand(sqlString, con);
                    SqlDataReader reader = comm.ExecuteReader();
                    if (reader.HasRows)
                    {
                        MessageBox.Show("Данный пользователь существует!");
                        con.Close();
                        return;
                    }
                    reader.Close();
                    con.Close();
                    //------------------------
                    // Вставляем в БД новые данные
                    con.Open();
                    string sql = "INSERT INTO users(login,pass,fio,age,sport) VALUES(";
                    sql += $"'{tNewLogin.Text}','{tNewPass.Text}','{tFIO.Text}',{nAge.Value},'{tSport.Text}')";
                    SqlCommand com = new SqlCommand(sql, con);
                    com.ExecuteNonQuery();
                    //--------
                    MessageBox.Show("Пользователь зарегестрирован!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка - " + ex.ToString());
                }
                finally
                {
                    con.Close();
                }
            }
            else MessageBox.Show("Введите корректные данные!");
        }
        // Вход в панель
        private void button1_Click(object sender, EventArgs e)
        {
            // Проверка на пустоту
            if (tLogin.Text.Length * tPass.Text.Length == 0) return;

            try
            {
                // Запрос, проверяем на существования полей
                con.Open();
                string sqlString = "SELECT * FROM users WHERE login = '" + tLogin.Text + "' AND pass = '" + tPass.Text + "'";
                SqlCommand comm= new SqlCommand(sqlString, con);
                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows) 
                {
                    while (reader.Read()) 
                    {
                        indUser = (int)reader.GetValue(0);
                    }
                    reader.Close();
                    // Открываем 2 форму
                    Form fm2 = new Form2();
                    fm2.Show();
                }
                else 
                {
                    MessageBox.Show("Неправильный логин или пароль"); 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка - " + ex.ToString());
            }
            finally 
            {
                con.Close();
            }
        }
    }
}
