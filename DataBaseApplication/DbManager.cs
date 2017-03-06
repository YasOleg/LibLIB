using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Windows.Forms;



namespace DataBaseApplication
{
    public class DbManager
    {
        static BindingList<Book> BorrowList = new BindingList<Book>();

        public static void AddUser()
        {
            Console.Write("Write name: ");
            string name = Console.ReadLine();

            Console.Write("Write password: ");
            string passw = Console.ReadLine();

            Console.Write("Write true if you admin: ");
            string admin = Console.ReadLine();

            using (UserContext db = new UserContext())
            {
                if (admin == "true")
                {
                    db.UserSet.Add(new Users { LoginName = name, Password = passw, IsAdmin = true });
                }
                else
                {
                    db.UserSet.Add(new Users { LoginName = name, Password = passw, IsAdmin = false });
                }

                db.SaveChanges();
                Console.WriteLine("New USER Saved...");
            }
            Console.ReadLine();
        }

        public static void AddBook(string bookname, string author, int bookage, string bookgenre)
        {
            using (BookContext bks = new BookContext())
            {
                bks.BookСollection.Add(new Book { BookName = bookname, Author = author, BookAge = bookage, Genre = bookgenre });
                bks.SaveChanges();
            }
        }
        
        public static void LoadDB(DataGridView dgv)
        {
            using (BookContext bk = new BookContext())
            {
                BindingList<Book> collection = new BindingList<Book>(bk.BookСollection.ToList());
                dgv.DataSource = collection;
            }
        }

        public static void RemoveBook(string password, int id, string bookname, string authore)
        {
            using (UserContext db = new UserContext())
            {
                var rez = db.UserSet;
                foreach (var item in rez)
                {
                    if (password == item.Password)
                    {
                        Remove(id, bookname, authore);
                    }
                    else
                    {
                        MessageBox.Show("You can't delete book!!! Write your Password to Del...", "INFO",
                            MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
            }
        }
        
        public static void Remove(int id, string bookname, string authore)
        {
            using (BookContext bks = new BookContext())
            {
                var collection = bks.BookСollection;
                foreach (var book in collection)
                {
                    if (book.Id == id && book.BookName == bookname && book.Author == authore)
                    {
                        bks.BookСollection.Remove(book);
                    }
                }
                bks.SaveChanges();
            }
        }
        
        public static void HistoryOfBorrow(DataGridView dgv, string name)
        {
            ArrayList arr = new ArrayList();
            using (UserContext user = new UserContext())
            {
                var users = user.UserSet;
                using (BookContext bk = new BookContext())
                {
                    foreach (var item in users)
                    {
                        if (item.Equals(name))
                        {
                            arr.Add(item.LoginName);
                        }
                    }
                }
            }

        }

        public static void BorrowBook(string nameBorr, DataGridView dgv)
        {
            using (BookContext bk = new BookContext())
            {
                var collection = bk.BookСollection.ToList();
                foreach (var book in collection)
                {
                    if (nameBorr == book.BookName)
                    {
                        BorrowList.Add(book);
                        bk.BookСollection.Remove(book);
                        
                    }
                }
                bk.SaveChanges();
                dgv.DataSource = BorrowList;
            }
         }
        public static void returnBook(string nameBorr)
        {
            using (BookContext bk = new BookContext())
            {
                for(int i = 0; i < BorrowList.Count; i++)
                {
                    if (BorrowList.Count != 0)
                    {
                        if (nameBorr == BorrowList[i].BookName)
                        {
                            bk.BookСollection.Add(BorrowList[i]);
                            BorrowList.Remove(BorrowList[i]);
                            bk.SaveChanges();
                        }
                    }
                    else break;
                }
             }
        }

        public static void SearchBook(TextBox txt, DataGridView dgv)
        {
            using (BookContext db = new BookContext())
            {
                var rez = db.BookСollection.ToList();
                List<Book> SerchList = new List<Book>();

                foreach (var item in rez)
                {
                    if (txt.Text == item.BookName)
                    {
                        SerchList.Add(item);
                    }
                    if (txt.Text == item.Author)
                    {
                        SerchList.Add(item);
                    }
                    if (txt.Text == item.Genre)
                    {
                        SerchList.Add(item);
                    }
                    if (txt.Text == item.BookAge.ToString())
                    {
                        SerchList.Add(item);
                    }
                }
                dgv.DataSource = SerchList;
            }
        }
        
        public static void SearchUser(string name, string password, Form frmLib, Form frmClient)
        {
            using (UserContext db = new UserContext())
            {
                var rez = db.UserSet;
                foreach (var item in rez)
                {
                    if (name == item.LoginName && password == item.Password)
                    {
                        if (item.IsAdmin == true)
                        {
                            frmLib.Show();
                        }
                        else
                        {
                            frmClient.Show();
                        }
                    }
                }
            }
        }
    }
}
