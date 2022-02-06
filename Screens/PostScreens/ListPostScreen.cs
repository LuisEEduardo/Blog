using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public class ListPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar posts");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void List()
        {
            var repository = new Repository<Post>(Database.Connection);
            var posts = repository.GetAll();
            foreach (var post in posts)
            {
                Console.WriteLine(post.Title);
            }
        }
    }
}