using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            Update();
        }

        int currentRow = -1;
        /// <summary>
        /// Обновление записей
        /// </summary>
        public void Update()
        {
            using (LibraryContext db = new LibraryContext())
            {
                dataGridView1.DataSource = db.Book.ToList();
            }
        }
        /// <summary>
        /// Добавление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            using(LibraryContext db = new LibraryContext())
            {
                Book book = new Book();
                book.name = textBox1.Text;

                db.Book.Add(book);
                db.SaveChanges();
            }
            Update();
        }
        /// <summary>
        /// изменение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            using (LibraryContext db = new LibraryContext())
            {
                Book book = db.Book.Find(dataGridView1.Rows[currentRow].Cells[0].Value);
                book.name = textBox2.Text;

                db.Book.Update(book);
                db.SaveChanges();
            }
            Update();
        }
        /// <summary>
        /// Выбор элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            currentRow = e.RowIndex;
            textBox2.Text = dataGridView1.Rows[currentRow].Cells[1].Value.ToString();
        }
        /// <summary>
        /// Удаление
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            using (LibraryContext db = new LibraryContext())
            {
                Book book = db.Book.Find(dataGridView1.Rows[currentRow].Cells[0].Value);

                db.Book.Remove(book);
                db.SaveChanges();
            }
            Update();
        }
    }
}
