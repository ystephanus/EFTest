using System;
namespace testEF.Model
{
	public class Author
	{
		public int Id { get; set; }
		public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public string GetList(List<Author> authors)
        {
             return "[" + string.Join(", ", authors)+"]";
        }
    }

	
}

