using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.PostTagScreen
{
    public class LinkPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular tag a um post");
            Console.WriteLine("----------------------------");
            Console.Write("Id do post: ");
            int postId = int.Parse(Console.ReadLine());
            Console.Write("Id da tag: ");
            int tagId = int.Parse(Console.ReadLine());
            Link(new PostTag
            {
                PostId = postId,
                TagId = tagId
            });
            Console.ReadKey();
            MenuPostTagScreen.Load();
        }

        public static void Link(PostTag postTag)
        {
            try
            {
                var repository = new Repository<PostTag>(Database.Connection);
                repository.Create(postTag);
                Console.WriteLine("Tag vinculada ao post com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível vincular a tag com o post!");
                Console.WriteLine(ex.Message);
            }
        }

    }
}