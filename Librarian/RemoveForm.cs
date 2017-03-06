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
    public partial class RemoveForm : Form
    {
        public RemoveForm()
        {
            InitializeComponent();
        }

        private void btnREmove_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Text) && string.IsNullOrEmpty(tbIDbook.Text) && string.IsNullOrEmpty(tbBookName.Text) && string.IsNullOrEmpty(tbAuthore.Text))
            {
                MessageBox.Show("Write all states", "Warinng", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DbManager.RemoveBook(tbPassword.Text, int.Parse(tbIDbook.Text), tbBookName.Text, tbAuthore.Text);
                MessageBox.Show("Book removed from DB", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }
    }
}
