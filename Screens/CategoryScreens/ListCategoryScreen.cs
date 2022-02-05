using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.CategoryScreens
{
    public class ListCategoryScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("-------------------");
            List();
            Console.ReadKey();
            MenuCategoryScreen.Load();
        }

        public static void List()
        {
            try
            {
                var repository = new Repository<Category>(Database.Connection);
                var categories = repository.GetAll();
                foreach (var category in categories)
                {
                    Console.WriteLine(category.Name);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível listar as cetegorias!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}