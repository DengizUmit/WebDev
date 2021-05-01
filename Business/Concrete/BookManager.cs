using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BookManager : IBookService
    {
        private IBookDal _bookDal;

        public BookManager(IBookDal bookDal)
        {
            _bookDal = bookDal;
        }

        public void Add(Book book)
        {
            // İş Kodları
            if (_bookDal.Get(filter:b => b.Name == book.Name && b.AuthorId == book.AuthorId) == null)
            {
                _bookDal.Add(book);
            }
            else
            {
                throw new Exception(message: "Girmek istediğiniz kitap adı zaten var!");
            }
        }

        public void Delete(Book book)
        {
            // İş Kodları
            _bookDal.Delete(book);
        }

        public List<Book> getAll()
        {
            // İş Kodları
            return _bookDal.GetList().ToList();
        }

        public List<Book> getByAuthorId(int id)
        {
            // İş Kodları
            return _bookDal.GetList(filter:b => b.AuthorId == id).ToList();
        }

        public Book getById(int id)
        {
            // İş Kodları
            return _bookDal.Get(b => b.Id == id);
        }

        public void Update(Book book)
        {
            // İş Kodları
            _bookDal.Update(book);
        }
    }
}
