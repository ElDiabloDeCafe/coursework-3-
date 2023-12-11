using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseWorkWithDB
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();

            loginField.Text = "Введите имя";
            passwordField.Text = "Введите пароль";
            confirmField.Text = "Подтвердите пароль";
            emailField.Text = "Введите почту";
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите имя")
            
                loginField.Text = "";
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            
                loginField.Text = "Введите имя";
        }

        private void emailField_Enter(object sender, EventArgs e)
        {
            if (emailField.Text == "Введите почту")

                emailField.Text = "";
        }

        private void emailField_Leave(object sender, EventArgs e)
        {
            if (emailField.Text == "")

                emailField.Text = "Введите почту";
        }

        private void passwordField_Enter(object sender, EventArgs e)
        {
            if (passwordField.Text == "Введите пароль")

                passwordField.Text = "";
        }

        private void passwordField_Leave(object sender, EventArgs e)
        {
            if (passwordField.Text == "")

                passwordField.Text = "Введите пароль";
        }

        private void confirmField_Enter(object sender, EventArgs e)
        {
            if (confirmField.Text == "Подтвердите пароль")

                confirmField.Text = "";
        }

        private void confirmField_Leave(object sender, EventArgs e)
        {
            if (confirmField.Text == "")

                confirmField.Text = "Подтвердите пароль"; 
        }
       
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (loginCheck())
                return;

            if (loginField.Text == "Введите имя")
            {
                MessageBox.Show("Вы заполнили не все поля!");
                return;
            }
            if (passwordField.Text == "Введите пароль")
            {
                MessageBox.Show("Вы заполнили не все поля!");
                return;
            }
            if (emailField.Text == "Введите почту")
            {
                MessageBox.Show("Вы заполнили не все поля!");
                return;
            }
            if (emailField.Text == "Подтвердите пароль")
            {
                MessageBox.Show("Вы заполнили не все поля!");
                return;
            }
            if (passwordField.Text != confirmField.Text)
            {
                MessageBox.Show("Пароли должны совпадать!");
                return;
            }


            string userLogin = loginField.Text;
            string userPassword = passwordField.Text;
            string userEmail = emailField.Text;

            DB db = new DB();
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `password`, `email`) VALUES (@login, @password, @email)", db.getCon());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@password", MySqlDbType.VarChar).Value = userPassword;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = userEmail;

            db.openCon();

            if (command.ExecuteNonQuery() == 1)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
            else
                MessageBox.Show("Произошла ошибка");

            db.closeCon();
        }

         public Boolean loginCheck()
        {
            DB db = new DB();

            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLog", db.getCon());
            command.Parameters.Add("@userLog", MySqlDbType.VarChar).Value = loginField.Text;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Данный логин уже занят");
                return true;
            }

            else
                return false;

        }

        private void loginLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
            
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
    
}
