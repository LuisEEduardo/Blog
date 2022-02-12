using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public class ListPostsWithCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar os posts de uma categoria");
            Console.WriteLine("--------------------------------");
            Console.Write("Id da categoria: ");
            int id = int.Parse(Console.ReadLine());
            List(id);
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        public static void List(int categoryId)
        {
            var repository = new Repository<Category>(Database.Connection);
            var category = repository.Get(categoryId);
            Console.Write($"{category.Name} - ");
            var repo = new ListRepository(Database.Connection);
            var postsName = repo.SelectAllPostsEvenCategory(categoryId);
            foreach (var name in postsName)
            {
                Console.Write($"{name}");
                Console.WriteLine();
            }
        }

    }
}