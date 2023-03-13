using System;
namespace testEF.Model
{
	public class Book
	{
		public int Id { get; set; }
		public string Title { get; set; }
        public DateTime publishDate { get; set; } = DateTime.Now;
		public ICollection<Author> Author { get; set; }

        public override string ToString()
        {
            return "Book number(" + Id + ") : Title = " + Title + " Author = " + new Author().GetList(Author.ToList());
        }

    }
}

