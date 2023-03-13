using System;
using testEF.Model;
using Microsoft.EntityFrameworkCore;

namespace testEF
{
	public class BookRepository : IBookRepository
	{

		BookContext _context;
		public BookRepository(BookContext context)
		{
			this._context = context;
		}

		public IEnumerable<Book> getBooks()
		{
			return _context.Books.Include(x => x.Author).ToList<Book>();
		}

		public void AddBook(Book book)
		{

			_context.Books.Add(book);
			try
			{
				_context.SaveChanges();
			}
			catch (DbUpdateException e)
			{
				Console.WriteLine(e);
			}
			Console.WriteLine("new book added");
		}
		public Book getBookById(int id)
		{
			return _context.Books.Find(id);
		}
	}
}

