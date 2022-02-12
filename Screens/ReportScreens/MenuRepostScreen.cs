using System;
using Blog.Screens.MainScreens;

namespace Blog.Screens.ReportScreens
{
    public class MenuReportScreen
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine("Reports");
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine();
            Console.WriteLine("1 - Listar categorias com quantidade de posts");
            Console.WriteLine("2 - Listar tags com quantidade de posts");
            Console.WriteLine("3 - Listar os posts de uma categoria");
            Console.WriteLine("4 - Listar todos os posts com sua categoria");
            Console.WriteLine("5 - Listar os posts com suas tags (separados por vírgula)");
            Console.WriteLine("6 - Voltar ao menu principal");
            Console.WriteLine();
            Console.Write("Insira a opção: ");
            short option = short.Parse(Console.ReadLine());

            switch (option)
            {
                case 1: 
                    ListCategoryWithQtdPosts.Load();
                    break;
                case 2: 
                    ListTagsWithQtyPosts.Load();
                    break;
                case 3: 
                    ListPostsWithCategory.Load();
                    break;
                case 4:
                    ListListAllPostsWithOwnCategory.Load();
                    break;
                case 5: 
                    ListPostsWithOwnTags.Load();
                    break;
                case 6:
                    MenuMainScreen.Load();
                    break;
                default:
                    Load();
                    break;
            }
        }
    }
}