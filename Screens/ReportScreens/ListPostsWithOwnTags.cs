using System;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public class ListPostsWithOwnTags
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar os posts com suas tags (separados por vírgula)");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        public static void List()
        {
            try
            {
                var repository = new ListRepository(Database.Connection);
                var posts = repository.ListPostsWithOwnTags();

                foreach (var post in posts)
                {
                    Console.Write($"Nome: {post.Title} - Quantidade: {post.Tags.Count}");
                    Console.WriteLine();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível listar os posts");
                Console.WriteLine(ex.Message);
            }

        }

    }
}