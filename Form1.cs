using System.Data.SQLite;
using System.Windows.Forms;

namespace Register
{
    public partial class Form1 : Form
    {
        string path = "data_table.db";
        string cs = @"URI=file:"+Application.StartupPath+"\\data_table.db";

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

            try
            {
                new System.Net.Mail.MailAddress(this.email_txt.Text);

                try
                {
                    cmd.CommandText = "INSERT INTO test(login, email, password) VALUES (@login, @email, @password)";

                    string LOGIN = login_txt.Text;
                    string EMAIL = email_txt.Text;
                    string PASSWORD = password_txt.Text;

                    cmd.Parameters.AddWithValue("@login", LOGIN);
                    cmd.Parameters.AddWithValue("@email", EMAIL);
                    cmd.Parameters.AddWithValue("@password", PASSWORD);

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


            }
            catch (ArgumentException)
            {
                //textBox is empty
            }
            catch (FormatException)
            {
                //textBox contains no valid mail address
            }

        }
    }
}