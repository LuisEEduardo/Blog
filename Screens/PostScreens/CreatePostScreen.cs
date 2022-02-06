using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostScreens
{
    public class CreatePostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar posts");
            Console.WriteLine("-------------");
            Console.Write("Title: ");
            var title = Console.ReadLine();
            Console.Write("Summary: ");
            var summary = Console.ReadLine();
            Console.Write("Body: ");
            var body = Console.ReadLine();
            Console.Write("Slug: ");
            var slug = Console.ReadLine();
            Console.Write("Author Id: ");
            var authorId = int.Parse(Console.ReadLine());
            Console.Write("Category Id: ");
            var categoryId = int.Parse(Console.ReadLine());
            Create(new Post
            {
                Title = title,
                Summary = summary,
                Body = body,
                Slug = slug,
                CreateDate = DateTime.Now,
                LastUpdateDate = DateTime.Now,
                AuthorId = authorId,
                CategoryId = categoryId
            });
            Console.ReadKey();
            MenuPostScreen.Load();
        }

        public static void Create(Post post)
        {
            try
            {
                var repository = new Repository<Post>(Database.Connection);
                repository.Create(post);
                Console.WriteLine("Post criado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível criar o post!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}