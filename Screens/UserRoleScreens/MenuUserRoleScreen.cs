using System;
using Blog.Screens.MainScreens;

namespace Blog.Screens.UserRoleScreens
{
    public class MenuUserRoleScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular um usuário a um perfil");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - vincular usuário a perfil");
            Console.WriteLine("2 - voltar ao menu principal");
            Console.WriteLine();
            Console.Write("Insira a opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkUserRoleScreen.Load();
                    break;
                case 2:
                    MenuMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}