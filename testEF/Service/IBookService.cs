using System;
using testEF.Model;

namespace testEF.Service
{
	public interface  IBookService
	{
		IEnumerable<Book> GetBooks();
		void AddBook(Book book);
		Book GetBookById(int id);
		void CreateNewBook();

    }
}

