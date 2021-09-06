using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Entitys.Entity
{
    public class Book : Entity
    {
       
        public string Name { get; set; }
        public int PageCount { get; set; }
        public Author Author { get; set; }
    }
}
