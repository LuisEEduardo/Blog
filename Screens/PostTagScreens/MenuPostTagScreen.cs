using System;
using Blog.Screens.MainScreens;

namespace Blog.Screens.PostTagScreen
{
    public class MenuPostTagScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Vincular uma tag a um post");
            Console.WriteLine("-------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - vincular tag a post");
            Console.WriteLine("2 - voltar ao menu principal");
            Console.WriteLine();
            Console.Write("Insira a opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    LinkPostTagScreen.Load();
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