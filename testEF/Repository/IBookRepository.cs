using System;
using testEF.Model;

namespace testEF
{
	public interface IBookRepository
	{
        public IEnumerable<Book> getBooks();
        public void AddBook(Book book);
        public Book getBookById(int id);
    }
}

