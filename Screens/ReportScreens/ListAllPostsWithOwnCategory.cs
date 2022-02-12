using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public class ListListAllPostsWithOwnCategory
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar todos os posts com sua categoria");
            Console.WriteLine("---------------------------------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        public static void List()
        {
            var repository = new PostRepository(Database.Connection);
            var posts = repository.GetAll();
            foreach (var post in posts)
            {
                Console.Write($"{post.Title} - ");
                var repo = new Repository<Category>(Database.Connection);
                var category = repo.Get(post.CategoryId);
                Console.Write($"{category.Name}");
                Console.WriteLine();
            }
        }

    }
}