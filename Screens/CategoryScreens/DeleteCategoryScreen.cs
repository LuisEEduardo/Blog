using System;
using Blog.Models;
using Blog.Repositories;
using Blog.Screens.MainScreens;

namespace Blog.Screens.CategoryScreens
{
    public class DeleteCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Exluir categoria");
            Console.WriteLine("---------------");
            Console.Write("Id: ");
            int id = int.Parse(Console.ReadLine());
            Delete(id);
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Categoria excluída com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir a categoria!");
                Console.WriteLine(ex.Message);
            }
        }

    }
}