using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheTelephoneBook
{
    class Program
    {
        public static string[] nameArray = new string[20];
        public static string[] phoneNumberArray = new string[20];
        static void Main(string[] args)
        {
            int menuSelect;

            Console.WriteLine("Welcome to The Phone Book");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("1. Create New Record");
            Console.WriteLine("2. Delete Record");
            Console.WriteLine("3. List Records");
            Console.WriteLine("4. Exit the Phone Book");
            Console.WriteLine("");
            Console.WriteLine("Please select a menu Option: ");
            menuSelect = int.Parse(Console.ReadLine());
            switch (menuSelect)
            {
                case 1:
                    Console.Clear();
                    NewRecord();
                    break;
                case 2:
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case 3:
                    Console.Clear();
                    Console.ReadLine();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }

        }
        static void NewRecord()
        {
            Console.WriteLine("        New Record Creator        ");
            Console.Write(new string('-', Console.WindowWidth));
            int indexMem = 0;
            for (int i = indexMem; i < 20; i++)
            {
                Console.Write("Please enter the full name: ");
                string nameTemp = Console.ReadLine();
                Console.Write("Please enter the Phone number: ");
                string phoneTemp = Console.ReadLine();
                nameArray[i] = nameTemp;
                phoneNumberArray[i] = phoneTemp;
                indexMem = i;
            }
            Console.ReadLine();

        }
    }

}
