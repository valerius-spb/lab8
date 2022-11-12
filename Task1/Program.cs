using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Создание строковой переменной
            string path = @"C:\Users\ValriuS\Desktop\ITMO\C#\8";

            //получение файлов внутри каталога
            string[] files = Directory.GetFiles(path, "*", SearchOption.AllDirectories);

            //перборка
            foreach (string file in files)
            {
                //Вывод
                Console.WriteLine(file);
            }
            Console.ReadKey();
        }
    }
}
