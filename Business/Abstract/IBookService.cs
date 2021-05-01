using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBookService
    {
        List<Book> getAll();
        Book getById(int id);
        List<Book> getByAuthorId(int id);
        void Add(Book book);
        void Delete(Book book);
        void Update(Book book);
    }
}
