using System;

namespace Blog.Screens.ReportScreens
{
    public class ListPostsWithOwnTags
    {
        public static void Load()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listar os posts com suas tags (separados por vírgula)");
            Console.WriteLine("--------------");
            List();
            Console.ReadKey();
            MenuReportScreen.Load();
        }

        public static void List()
        {
            
        }

    }
}