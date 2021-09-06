using BookProject1.Data.Abstract;
using BookProject1.Data.Context;
using BookProject1.Entitys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Data.Concreate
{
    public class BookRepository : Repository<Book>,IBookRepository
    {
        public BookRepository(ApplicationDbContext context) : base(context)
        {

        }

        public Book GetByName(string Name)
        {
            return _context.Books.FirstOrDefault(b => b.Name == Name);
        }
    }
}
