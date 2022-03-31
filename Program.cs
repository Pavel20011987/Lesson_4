using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_4
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFullName("Петров", "Валерий", "Валерьевич");
            GetFullName("Сидоров", "Владимир", "Иванович");
            GetFullName("Саврасов", "Петр", "Евгеньевич");// Вызов метода в методе Main
        }
        static void GetFullName(string lastName, string firstName, string patronymic)// Метод GetFullName с аргументами и выводящая в консоль значения аргументов
        {
            Console.WriteLine($"{lastName} {firstName} {patronymic}");
        }
    }
}
