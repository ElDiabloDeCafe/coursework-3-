using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace CourseWorkWithDB
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string userLogin = loginField.Text;
            string userPassword = passwordField.Text;

            DB db = new DB();
            
            DataTable table = new DataTable();
            
            MySqlDataAdapter adapter = new MySqlDataAdapter();

            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login` = @userLog AND `password` = @userPass", db.getCon());
            command.Parameters.Add("@userLog", MySqlDbType.VarChar).Value = userLogin;
            command.Parameters.Add("@userPass", MySqlDbType.VarChar).Value = userPassword;
       
            adapter.SelectCommand = command;
            adapter.Fill(table);
            
            if (table.Rows.Count > 0 )
            {
                this.Hide();
                Eratosthenes eratosthenes = new Eratosthenes(userLogin);
                eratosthenes.Show();
            }

            else 
                MessageBox.Show("Вы ввели неверный логин или пароль");
        }

        private void registerLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
