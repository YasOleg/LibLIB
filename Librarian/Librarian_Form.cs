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
    public partial class Librarian_Form : Form
    {
        public Librarian_Form()
        {
            InitializeComponent();
            DbManager.LoadDB(DataBooks);
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm formAdd = new AddBookForm();
            formAdd.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RemoveForm formDell = new RemoveForm();
            formDell.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DbManager.LoadDB(DataBooks);
        }

        private void btnFindInfo_Click(object sender, EventArgs e)
        {
            DbManager.SearchBook(tbSerchTxt, DataBooks);
        }
    }
}
