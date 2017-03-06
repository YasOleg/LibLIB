using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Client;
using Librarian;
using DataBaseApplication;


namespace Library
{
    public partial class Main_LogForm : Form
    {
        public Main_LogForm()
        {
            InitializeComponent();
        }
        
        private void btnLogOn_Click(object sender, EventArgs e)
        {
            Client_Form frmClient = new Client_Form();
            Librarian_Form frmLib = new Librarian_Form();
            DbManager.SearchUser(tbLogin.Text, tbPassword.Text, frmLib, frmClient);
        }
    }
}
