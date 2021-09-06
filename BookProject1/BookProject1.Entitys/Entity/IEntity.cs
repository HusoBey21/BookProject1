using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Entitys.Entity
{
    public interface IEntity
    {
         int Id { get; set; }
    }

    public class Entity : IEntity
    {
        public int Id { get ; set ; }
    }
}
