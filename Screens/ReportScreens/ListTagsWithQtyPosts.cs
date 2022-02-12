using System;
using Blog.Repositories;

namespace Blog.Screens.ReportScreens
{
    public class ListTagsWithQtyPosts
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar tags com quantidade de posts");
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
                var tags = repository.ListTagsWithQtyPosts();

                foreach (var tag in tags)
                {
                    Console.Write($"Nome: {tag} "); // - Quantidade: {tag.Posts.Count}
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível listar as tags");
                Console.WriteLine(ex.Message);
            }
        }

    }
}