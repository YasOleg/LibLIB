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

namespace Client
{
    public partial class Client_Form : Form
    {
        public Client_Form()
        {
            InitializeComponent();
            DbManager.LoadDB(dgvBorHistory);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
             DbManager.LoadDB(dgvBorHistory);
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            DbManager.BorrowBook(tbNameBook.Text, dgvBorrowedTable);
            DbManager.LoadDB(dgvBorHistory);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            DbManager.returnBook(tbNameBook.Text);
            DbManager.LoadDB(dgvBorHistory);
           
        }
    }
}
