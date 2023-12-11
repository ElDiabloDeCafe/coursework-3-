using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace CourseWorkWithDB
{
    public partial class Eratosthenes : Form
    {
        
        public string recivedData;
        public Eratosthenes(string userLogin)
        {
            InitializeComponent();

            nField.Text = "Введите число N (до 100000)";
            recivedData = userLogin;
        }

        private void loginField_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void nField_Enter(object sender, EventArgs e)
        {
            if (nField.Text == "Введите число N (до 100000)")

                nField.Text = "";
        }

        private void nField_Leave(object sender, EventArgs e)
        {
            if (nField.Text == "")

                nField.Text = "Введите число N (до 100000)";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
                string error = "Без ошибки";
           
                Stopwatch stopwatch = new Stopwatch();
                stopwatch.Start();
            try
            {
                int n = int.Parse(nField.Text);
                if(n>100000)
                {
                    MessageBox.Show("Вы ввели число больше 100'000 это может привести к слишком медленной работе программы!");
                    return;
                }
                bool[] primes = new bool[n + 1];
                for (int i = 2; i <= n; i++)
                {
                    primes[i] = true;
                }
                int sqrtN = (int)Math.Sqrt(n);
                for (int i = 2; i <= sqrtN; i++)
                {
                    if (primes[i])
                    {
                        Parallel.For(i * i, n + 1, j =>
                        {
                            if (j % i == 0)
                            {
                                primes[j] = false;
                            }
                        });
                    }
                }

                outputBox.Clear();
                outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Regular);

                for (int i = 2; i <= n; i++)
                {
                    if (primes[i])
                    {
                        outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Underline);
                        outputBox.AppendText($"{i} ");
                        outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Regular);
                    }
                    else
                    {
                        outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Strikeout);
                        outputBox.AppendText($"{i} ");
                        outputBox.SelectionFont = new Font(outputBox.Font, FontStyle.Regular);
                    }
                }
            }
            catch
            {
                error = "Была ошибка";
            }
            stopwatch.Stop();
                string workTime = stopwatch.Elapsed.ToString();
                DateTime localDate = DateTime.Now;
                string date = localDate.ToString();
                int v = int.Parse(nField.Text);
                string ammountN = v.ToString();

            DB db = new DB();
            
            DataTable table = new DataTable();

            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("INSERT INTO `logs` (`login`, `amountN`, `workTime`, `error`, `date`) VALUES (@login, @ammountN, @workTime, @error, @date)", db.getCon());

            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = recivedData;
            command.Parameters.Add("@ammountN", MySqlDbType.VarChar).Value = ammountN;
            command.Parameters.Add("@workTime", MySqlDbType.VarChar).Value = workTime;
            command.Parameters.Add("@error", MySqlDbType.VarChar).Value = error;
            command.Parameters.Add("@date", MySqlDbType.VarChar).Value = date;

            db.openCon();

            if (command.ExecuteNonQuery() == 0)

                MessageBox.Show("Произошла ошибка");

            db.closeCon();

        }

        private void closeLabel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
