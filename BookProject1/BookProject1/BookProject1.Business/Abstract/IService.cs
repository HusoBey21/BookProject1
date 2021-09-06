using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Business.Abstract
{
    public interface IService<TEntity>
    {
        void Add(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Update(TEntity entity);
        void Delete(int id);
    }
}
