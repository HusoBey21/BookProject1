using BookProject1.Entitys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Data.Abstract
{
    public interface IRepository<TEntity> where TEntity : Entity
    {
        void Add(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
