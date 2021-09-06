using BookProject1.Business.Abstract;
using BookProject1.Data.Abstract;
using BookProject1.Entitys.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookProject1.Business.Concreate
{
    public class AuthorManager : IAuthorService
    {

        private readonly IAuthorRepository _authorRepository;

        public AuthorManager(IAuthorRepository authorRepository)
        {
            _authorRepository = authorRepository;
        }

        public void Add(Author entity)
        {
            _authorRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _authorRepository.Delete(id);
        }

        public List<Author> GetAll()
        {
            return _authorRepository.GetAll();
        }

        public Author GetById(int id)
        {
            return _authorRepository.GetById(id);
        }

        public void Update(Author entity)
        {
            _authorRepository.Update(entity);
        }
    }
}
