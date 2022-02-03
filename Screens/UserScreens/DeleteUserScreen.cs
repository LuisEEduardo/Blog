using System;
using Blog.Models;
using Blog.Repositories;

namespace Blog.Screens.UserScreens
{
    public class DeleteUserScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Excluir usuário");
            Console.WriteLine("------------");
            Console.Write("Id: ");
            var id = int.Parse(Console.ReadLine());
            Delete(id); 
            Console.ReadKey(); 
            MenuUserScreen.Load();
        }

        public static void Delete(int id)
        {
            try
            {
                var repository = new Repository<User>(Database.Connection);
                repository.Delete(id);
                Console.WriteLine("Usuário(a) excluído com sucesso!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Não foi possível excluir o(a) usuário(a)");
                Console.WriteLine(ex.Message);
            }
        }
    }
}