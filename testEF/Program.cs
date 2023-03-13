// See https://aka.ms/new-console-template for more information
// docker run -it -e MYSQL_ROOT_PASSWORD=test -p 3306:3306 mysql:8
using testEF;
using testEF.Model;
using testEF.Service;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;


public class Program
{

    public static void Main(string[] args)
    {
        IHost host = CreateHostBuilder(args).Build();
        host.RunAsync();
        Console.WriteLine("1. Voir tous les livres disponibles\n2. Chercher un libre en particuler (par son id);\n3. Créer un nouveau livre; \n");
        string key = "";
        do
        {
            Console.WriteLine("Que souhaitez-vous faire ?");
            key = Console.ReadLine();
            IBookService bookService = host.Services.CreateScope().ServiceProvider.GetRequiredService<IBookService>();

            switch (key)
            {
                case "1":
                    bookService.GetBooks().ToList().ForEach(book => Console.WriteLine(book));
                    break;
                case "2":
                    break;
                case "3":
                    bookService.CreateNewBook();
                    break;
            }

        } while (key != "q");
    }
    public static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args).ConfigureServices(service =>
        {
            service.AddScoped<IBookRepository, BookRepository>();
            service.AddScoped<IBookService, BookService>();
            service.AddDbContext<BookContext>(ServiceLifetime.Scoped);
        });
    }
}

      

