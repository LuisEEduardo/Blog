using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserRoleScreens
{
    public class LinkUserRoleScreen
    {

        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular usuário a um perfil");
            Console.WriteLine("----------------------------");
            Console.Write("Id do usuário: ");
            int userId = int.Parse(Console.ReadLine());
            Console.Write("Id do perfil: ");
            int roleId = int.Parse(Console.ReadLine());
            Link(new UserRole
            {
                UserId = userId,
                RoleId = roleId
            });
            Console.ReadKey();
            MenuUserRoleScreen.Load();
        }

        public static void Link(UserRole userRole)
        {
            try
            {
                var repository = new Repository<UserRole>(Database.Connection);
                repository.Create(userRole);
                Console.WriteLine("Usuário vinculado com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível vincular o usuário com sucesso!");
                Console.WriteLine(ex.Message);
            }
        }
    }
}