using BookProject1.Data.Abstract;
using BookProject1.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Data.Concreate
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entitys.Entity.Entity
    {
        protected readonly ApplicationDbContext _context;

        private DbSet<TEntity> entities;

        public Repository(ApplicationDbContext context)
        {
            _context = context;
            entities = context.Set<TEntity>();
        }
        

        public void Add(TEntity entity)
        {
            entities.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            entities.FirstOrDefault(e => e.Id == id);
            _context.SaveChanges();
        }

        public List<TEntity> GetAll()
        {
            return entities.ToList();
        }

        public TEntity GetById(int id)
        {
            return entities.FirstOrDefault(e => e.Id == id);
        }

        public void Update(TEntity entity)
        {
            entities.Update(entity);
            _context.SaveChanges();
        }
    }
}
