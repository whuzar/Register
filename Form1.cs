using System.Data.SQLite;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.Text;

namespace Register
{
    public partial class Form1 : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:" + Application.StartupPath + "\\data_table.db";

        SQLiteConnection con;
        SQLiteCommand cmd;
        SQLiteDataReader dr;

        public Form1()
        {
            InitializeComponent();
        }

        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection(@"Data Source=" + path))
                {

                    sqlite.Open();
                    string sql = "create table test(login varchar(30), email varchar(30), password varchar(30))";
                    SQLiteCommand command = new SQLiteCommand(sql, sqlite);
                    command.ExecuteNonQuery();
                }
            }
            else
            {
                Console.WriteLine("Database cannot create");
                return;
            }
        }

        private Boolean checklogin(string LOGIN)
        {

            con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);

            cmd.CommandText = "SELECT COUNT(login) FROM test WHERE login = @login";

            cmd.Parameters.AddWithValue("@login", LOGIN);

            Int32 count = Convert.ToInt32(cmd.ExecuteScalar());
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }

            cmd.ExecuteNonQuery();

        }

        private static string GetHash(HashAlgorithm hashAlgorithm, string input)
        {
            byte[] data = hashAlgorithm.ComputeHash(Encoding.UTF8.GetBytes(input));

            var sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private static bool VerifyHash(HashAlgorithm hashAlgorithm, string input, string hash)
        {
            // Hash the input.
            var hashOfInput = GetHash(hashAlgorithm, input);

            // Create a StringComparer an compare the hashes.
            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            return comparer.Compare(hashOfInput, hash) == 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Create_db();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            con = new SQLiteConnection(cs);
            con.Open();
            cmd = new SQLiteCommand(con);

            if (checklogin(login_txt.Text))
            {
                try
                {
                    new System.Net.Mail.MailAddress(this.email_txt.Text);

                    try
                    {
                        cmd.CommandText = "INSERT INTO test(login, email, password) VALUES (@login, @email, @password)";

                        string LOGIN = login_txt.Text;
                        string EMAIL = email_txt.Text;
                        string PASSWORD = password_txt.Text;

                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            string hash = GetHash(sha256Hash, PASSWORD);

                            cmd.Parameters.AddWithValue("@password", hash);

                        }

                        cmd.Parameters.AddWithValue("@login", LOGIN);
                        cmd.Parameters.AddWithValue("@email", EMAIL);

                        string[] row = new string[] { LOGIN, EMAIL, PASSWORD };

                        cmd.ExecuteNonQuery();
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("cannot insert data");
                    }

                    login_txt.Text = "";
                    email_txt.Text = "";
                    password_txt.Text = "";
                    label8.Text = "Zarejestrowano";

                }
                catch (ArgumentException)
                {
                    label8.Text = "Braki w rejestracji";
                }
                catch (FormatException)
                {
                    label8.Text = "Niepoprawny E-mail";
                }

            }
            else
            {
                label8.Text = "Taki login ju? istnieje";
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!checklogin(loginto_txt.Text))
            {
                con = new SQLiteConnection(cs);
                con.Open();
                cmd = new SQLiteCommand(con);

                string LOGIN = loginto_txt.Text;
                string PASSWORD = passwd_into.Text;

                cmd.CommandText = "SELECT password FROM test WHERE login = @login";

                cmd.Parameters.AddWithValue("@password", PASSWORD);
                cmd.Parameters.AddWithValue("@login", LOGIN);

                string psw = Convert.ToString(cmd.ExecuteScalar());

                using (SHA256 sha256Hash = SHA256.Create())
                {
                    if (VerifyHash(sha256Hash, PASSWORD, psw))
                    {
                        label9.Text = "Zalogowano";
                        loginto_txt.Text = "";
                        passwd_into.Text = "";
                    }
                    else
                    {
                        label9.Text = "Nie poprawne has?o";
                    }
                }

                cmd.ExecuteNonQuery();

            }
            else
            {
                label9.Text = "Nie poprawny login";
            }
        }
    }
}