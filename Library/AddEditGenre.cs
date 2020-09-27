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
    public partial class AddEditGenre : Form
    {
        public AddEditGenre()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            switch (this.Tag)
            {
                case "Add":
                    MainClass.AddGenre(genre_edit.Text);
                    break;
                case "Edit":
                    MainClass.EditGenre(genre_edit.Text, Convert.ToInt32(MainClass.form.genresView.CurrentRow.Cells[0].Value));
                    break;

            }
            MainClass.form.LoadGenres();
            this.Close();
        }

        private void AddEditGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            MainClass.form.Enabled = true;
        }

        private void AddEditGenre_Load(object sender, EventArgs e)
        {

        }
    }
}
