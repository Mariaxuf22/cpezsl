using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cpezsl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Вберите специальную службу из списка");
            Console.WriteLine("1. МЧС");
            Console.WriteLine("2. Полиция");
            Console.WriteLine("3. Скорая помощь");
            Console.WriteLine("4. Аварийная газовая служба");
            Console.WriteLine("5. Выход");
            var keyInfo = Console.ReadKey(true);
            switch(keyInfo.KeyChar)
            {
                case '1':
                    Console.WriteLine("Вы выбрали МЧС");
                    break;
                case '2':
                    Console.WriteLine("Вы выбрали полицию");
                    break;
                case '3':
                    Console.WriteLine("Вы выбрали скорую помощь");
                    break;
                case '4':
                    Console.WriteLine("Вы выбрали аварийную газовую службу");
                break;
                case '5':
                    Console.WriteLine("Вы точно хотите выйти из меню?");
                    if (keyInfo.KeyChar == 'y')
                        Console.Clear();

                    break;

            }
            
        }

    }
}
