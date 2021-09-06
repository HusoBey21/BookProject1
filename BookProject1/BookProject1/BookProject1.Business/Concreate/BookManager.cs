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
    public class BookManager : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookManager(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void Add(Book entity)
        {
            _bookRepository.Add(entity);
        }

        public void Delete(int id)
        {
            _bookRepository.Delete(id);
        }

        public List<Book> GetAll()
        {
            return  _bookRepository.GetAll();
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public Book GetByName(string Name)
        {
            return _bookRepository.GetByName(Name);
        }

        public void Update(Book entity)
        {
            _bookRepository.Update(entity);
        }
    }
}
