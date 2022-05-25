using WinFormsApp2.context;
using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (LibraryContext db = new LibraryContext())
            {
                User[] users = db.User.ToArray();
                foreach(User u in users)
                {
                    if (u.login == textBox2.Text && u.password == textBox1.Text)
                    {
                        MainMenu form = new MainMenu();
                        form.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неверно");
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registration form = new Registration();
            form.Show();
        }
    }
}