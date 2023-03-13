using System;
using testEF.Model;

namespace testEF.Service
{
	public class BookService : IBookService
	{
        private IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        public IEnumerable<Book> GetBooks()
        {
            return _bookRepository.getBooks();
        }

        public void AddBook(Book book)
        {
            _bookRepository.AddBook(book);
        }

        public Book GetBookById(int id)
        {
            return _bookRepository.getBookById(id);
        }
        public void CreateNewBook()
        {
            List<Author> authors = new List<Author>() { new Author {Name= "Yann" }, new Author { Name = "Yatus"} };
            _bookRepository.AddBook(new Book { Title = "un jolie livre", Author = authors });

        }
    }
}

