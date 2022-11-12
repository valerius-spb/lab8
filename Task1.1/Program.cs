using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\ValriuS\Desktop\ITMO\C#\8");
            Console.WriteLine("==========Список каталогов==========");
            foreach (var item in dir.GetDirectories())
            {
                Console.WriteLine(item.Name);
                Console.WriteLine("==Список подкаталогов==");
                foreach (var it in item.GetDirectories())
                    Console.WriteLine(it.Name);
                Console.WriteLine();
            }
            Console.WriteLine("==========Список файлов==========");
            foreach (var item in dir.GetFiles())
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
    }
}
