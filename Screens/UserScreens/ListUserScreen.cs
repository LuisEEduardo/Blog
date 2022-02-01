using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class ListUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Lista de usuários:");
            Console.WriteLine("-----------------");
            List();
            Console.ReadKey();
            MenuUserScreen.Load();
        }


        public static void List()
        {
            var repository = new UserRepository(Database.Connection);
            var users = repository.GetWithRoles();
            foreach (var user in users)
            {
                Console.Write($"{user.Name} - {user.Email}");
                if (user.Roles.Count == 1)
                {
                    Console.Write($" - Perfil: ");
                    foreach (var role in user.Roles)
                        Console.Write($"- {role.Name}");
                }
                else if (user.Roles.Count > 0)
                {
                    Console.Write($" - Perfis: ");
                    foreach (var role in user.Roles)
                        Console.Write($"- {role.Name}");
                }
                else
                {
                    Console.Write($" - Usuário sem perfil");
                }
                Console.WriteLine();
            }


        }
    }
}