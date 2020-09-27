using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Library
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public void LoadGenres()
        {
            genresView.Rows.Clear();
            string query = "SELECT * from [genres]";
            SqlCommand loadData = new SqlCommand(query, MainClass.connection);
            loadData.CommandType = CommandType.Text;
            SqlDataReader reader = loadData.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[2]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                genresView.Rows.Add(s);
            if(data.Count > 0)
            LoadBooks(Convert.ToInt32(genresView.CurrentRow.Cells[0].Value));
        }
        public void LoadBooks()
        {
            LoadBooks(Convert.ToInt32(genresView.CurrentRow.Cells[0].Value));
        }
        public void LoadBooks(int id)
        {
            booksView.Rows.Clear();
            string query = String.Format("SELECT * from [books] Where id_genre={0}", id);
            SqlCommand loadData = new SqlCommand(query, MainClass.connection);
            loadData.CommandType = CommandType.Text;
            SqlDataReader reader = loadData.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[3]);
                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            foreach (string[] s in data)
                booksView.Rows.Add(s);

        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            MainClass.form = this;
            MainClass.OpenConnection();
            LoadGenres();
        }

        private void addGenreBtn_Click(object sender, EventArgs e)
        {
            AddEditGenre addEdit = new AddEditGenre();
            addEdit.Tag = "Add";
            addEdit.Show();

            MainClass.form.Enabled = false;
        }

        private void editGenre_Click(object sender, EventArgs e)
        {
            AddEditGenre addEdit = new AddEditGenre();
            addEdit.Tag = "Edit";
            addEdit.Show();
            addEdit.genre_edit.Text = genresView.CurrentRow.Cells[1].Value.ToString();
            MainClass.form.Enabled = false;
        }

        private void genresView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadBooks();
        }

        private void addBookBtn_Click(object sender, EventArgs e)
        {
            AddEditBook addEdit = new AddEditBook();
            addEdit.Tag = "Add";
            addEdit.Show();

            MainClass.form.Enabled = false;
        }

        private void editBookBtn_Click(object sender, EventArgs e)
        {
            AddEditBook addEdit = new AddEditBook();
            addEdit.Tag = "Edit";
            addEdit.Show();
            addEdit.bookEdit.Text = booksView.CurrentRow.Cells[1].Value.ToString();
            MainClass.form.Enabled = false;
        }

        private void delGenre_Click(object sender, EventArgs e)
        {
            SqlCommand delGenre = new SqlCommand();
            delGenre.Connection = MainClass.connection;
            delGenre.CommandType = CommandType.Text;

            string sqlComm = String.Format("delete from [genres] where id_genre={0}", Convert.ToInt32(genresView.CurrentRow.Cells[0].Value));
            delGenre.CommandText = sqlComm;
            delGenre.ExecuteNonQuery();
            LoadGenres();
        }

        private void delBookBtn_Click(object sender, EventArgs e)
        {
            SqlCommand delBook = new SqlCommand();
            delBook.Connection = MainClass.connection;
            delBook.CommandType = CommandType.Text;

            string sqlComm = String.Format("delete from [books] where id_book={0}", Convert.ToInt32(booksView.CurrentRow.Cells[0].Value));
            delBook.CommandText = sqlComm;
            delBook.ExecuteNonQuery();
            LoadGenres();
        }
    }
}
