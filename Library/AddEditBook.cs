using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library
{
    public partial class AddEditBook : Form
    {
        public AddEditBook()
        {
            InitializeComponent();
        }

        private void AddEditBook_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass.form.Enabled = true;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "Add":
                    MainClass.AddBook(bookEdit.Text,Convert.ToInt32(MainClass.form.genresView.CurrentRow.Cells[0].Value));
                    break;
                case "Edit":
                    MainClass.EditBook(bookEdit.Text, Convert.ToInt32(MainClass.form.booksView.CurrentRow.Cells[0].Value));
                    break;

            }
            MainClass.form.LoadBooks();
            this.Close();
        }
    }
}
