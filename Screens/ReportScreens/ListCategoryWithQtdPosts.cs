using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public class ListCategoryWithQtdPosts
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar categorias com quantidade de posts");
            Console.WriteLine("-----------------------------------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Category>(Database.Connection);
            var categories = repository.GetAll();
            foreach (var category in categories)
            {
                Console.Write($"{category.Name} - Quantidade: ");
                var repo = new ListRepository(Database.Connection);
                int quantity = repo.CountQtyPostByCategory(category.Id);
                Console.Write(quantity); 
                Console.WriteLine();
            }
        }

    }
}