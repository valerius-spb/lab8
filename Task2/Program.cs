using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Путь создания файла
            string path = @"C:\Users\ValriuS\Desktop\ITMO\C#\8\ДЗ\Numbers.txt";

            //Случайные числа 
            Random random = new Random();

            //Создание файла (каждый запуск перезапись)
            using (StreamWriter list = new StreamWriter(path, false))
            {
                for (int i = 0; i < 10; i++)
                {
                    //числа в диапазон -10,10
                    list.WriteLine(random.Next(-10, 10));
                }
            }

            int sum = 0;
            using (StreamReader list1 = new StreamReader(path))
            {
                string[] lines = File.ReadAllLines(path);
                //Console.WriteLine(list1.ReadToEnd());
                foreach (string i in lines) 
                {
                    sum = sum + int.Parse(i);
                }
            }
            Console.WriteLine("Сумма чисел = {0}" , sum);
            Console.ReadKey();
        }
    }
}
