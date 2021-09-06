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
    public class AuthorRepository : Repository<Author>,IAuthorRepository
    {
        public AuthorRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
