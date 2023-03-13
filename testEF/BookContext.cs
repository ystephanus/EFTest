using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using testEF.Model;

namespace testEF
{
	public class BookContext : DbContext
	{
		public DbSet<Book> Books { get; set; }
		public BookContext() : base()
		{
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			string connextionString = "server=localhost;port=3306;database=test;user=root;password=test";
			optionsBuilder.UseMySql(connextionString, ServerVersion.AutoDetect(connextionString));
        }
    }
}

