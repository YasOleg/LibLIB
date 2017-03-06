using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseApplication
{
    class BookContext : DbContext
    {
        public BookContext() : base("DBConnection")
        {

        }
        public virtual DbSet<Book> BookСollection { get; set; }
    }
}
