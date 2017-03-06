using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataBaseApplication;

namespace Librarian
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbName.Text) && string.IsNullOrEmpty(tbAuthor.Text) && string.IsNullOrEmpty(tbAge.Text) && string.IsNullOrEmpty(tbGenre.Text))
            {
                MessageBox.Show("Write all states", "Warinng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DbManager.AddBook(tbName.Text, tbAuthor.Text, int.Parse(tbAge.Text), tbGenre.Text);
                MessageBox.Show("New book is aded to DB", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
