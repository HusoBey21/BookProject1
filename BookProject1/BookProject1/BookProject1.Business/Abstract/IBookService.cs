using BookProject1.Entitys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Business.Abstract
{
    public interface IBookService : IService<Book>
    {
        Book GetByName(string Name);
    }
}
