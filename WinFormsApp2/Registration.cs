using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp2.context;
using WinFormsApp2.models;

namespace WinFormsApp2
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (LibraryContext db = new LibraryContext())
            {
                User user = new User();
                user.name = textBox3.Text;
                user.login = textBox2.Text;
                user.password = textBox1.Text;
                db.User.Add(user);
                db.SaveChanges();
            }
        }
    }
}
