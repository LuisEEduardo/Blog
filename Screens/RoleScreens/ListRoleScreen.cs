using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.RoleScreens
{
    public class ListRoleScreen
    {
        public static void Load()
        {
            Console.Clear(); 
            Console.WriteLine();
            Console.WriteLine("Lista de categorias");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuRoleScreen.Load();
        }   

        public static void List()
        {
            try
            {
                var repository = new Repository<Role>(Database.Connection);
                var roles = repository.GetAll();
                foreach (var role in roles)
                {
                    Console.WriteLine($"{role.Name} - {role.Slug}");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível listar as categorias");
                Console.WriteLine(ex.Message);
            }
        }
    }
}