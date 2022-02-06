using System;
using Blog.Screens.MainScreens;

namespace Blog.Screens.PostScreens
{
    public class MenuPostScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Gestão de posts");
            Console.WriteLine("-------------------");
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine();
            Console.WriteLine("1 - Listar posts");
            Console.WriteLine("2 - Cadastrar post");
            Console.WriteLine("3 - Atualizar post");
            Console.WriteLine("4 - Excluir post");
            Console.WriteLine("5 - Voltar ao menu principal");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Insira a opção: ");
            var option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    ListPostScreen.Load();
                    break;
                case 2: 
                    CreatePostScreen.Load();
                    break;
                case 3:
                    UpdatePostScreen.Load(); 
                    break;
                case 4:
                    DeletePostScreen.Load();
                    break;
                case 5:
                    MenuMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}