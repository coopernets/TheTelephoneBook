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
            Menu();

        }
        public static void NewRecord()
        {
            Console.WriteLine("                           New Record Creator                           ");
            Console.WriteLine("Please press enter to create a new record and press escape when finished");
            Console.Write(new string('-', Console.WindowWidth));
            int indexMem = 0;
            int i = 0;
            ConsoleKeyInfo ck;
            ck = Console.ReadKey();
            while (ck.Key != ConsoleKey.Escape)
            {
                Console.Write("Please enter the full name: ");
                string nameTemp = Console.ReadLine();
                Console.Write("Please enter the Phone number: ");
                string phoneTemp = Console.ReadLine();
                nameArray[i] = nameTemp;
                phoneNumberArray[i] = phoneTemp;
                indexMem = i;
                i++;
                ck = Console.ReadKey();
            }


            Menu();





        }
        public static void Menu()
        {
            int menuSelect;
            Console.Clear();
            Console.WriteLine("Welcome to The Phone Book");
            Console.Write(new string('-', Console.WindowWidth));
            Console.WriteLine("1. Create New Record");
            Console.WriteLine("2. Delete Record");
            Console.WriteLine("3. List Records");
            Console.WriteLine("4. Exit the Phone Book");
            Console.WriteLine("");
            Console.Write("Please select a menu Option: ");
            menuSelect = int.Parse(Console.ReadLine());
            switch (menuSelect)
            {
                case 1:
                    Console.Clear();
                    NewRecord();
                    break;
                case 2:
                    Console.Clear();
                    DeleteRecord();
                    break;
                case 3:
                    Console.Clear();
                    ListRecords();
                    break;
                case 4:
                    Environment.Exit(0);
                    break;
            }
        }
        public static void ListRecords()
        {
            for (int i = 0; i < nameArray.Count(); i++)
            {
                if (nameArray[i] != null)
                {
                    Console.WriteLine(nameArray[i] + " | " + phoneNumberArray[i]);
                }


            }
            Console.ReadLine();
            Menu();
        }
        public static void DeleteRecord()
        {

        }

    }

}
