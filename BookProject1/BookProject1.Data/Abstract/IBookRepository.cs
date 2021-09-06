using BookProject1.Entitys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Data.Abstract
{
    public interface IBookRepository : IRepository<Book> 
    {
        Book GetByName(string Name);
    }
}
