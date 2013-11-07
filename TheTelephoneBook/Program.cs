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
        public static int indexMem = 0;
        static void Main(string[] args)
        {
            Menu();

        }
        public static void NewRecord()
        {
            Console.WriteLine("                           New Record Creator                           ");
            Console.WriteLine("Please press enter to create a new record and press escape when finished");
            Console.Write(new string('-', Console.WindowWidth));

            int i = 0;
            ConsoleKeyInfo ck;
            ck = Console.ReadKey();
            while (ck.Key != ConsoleKey.Escape)
            {

                Console.Write("Please enter the full name: ");
                nameArray[i] = Console.ReadLine();
                Console.Write("Please enter the Phone number: ");
                phoneNumberArray[i] = Console.ReadLine();
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
            Wrong:
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
                default:
                    goto Wrong;
                    
            }
        }
        public static void ListRecords()
        {
            Console.WriteLine("List of Contacts");
            Console.Write(new string('-', Console.WindowWidth));
            for (int i = 0; i < nameArray.Count(); i++)
            {
                if (nameArray[i] != null)
                {
                    Console.WriteLine((i + 1) + " " + nameArray[i] + " | " + phoneNumberArray[i]);
                }


            }
            Console.ReadLine();
            Menu();
        }
        public static void DeleteRecord()
        {
            Console.WriteLine("List of Contacts");
            Console.Write(new string('-', Console.WindowWidth));
            for (int i = 0; i < nameArray.Count(); i++)
            {
                if (nameArray[i] != null)
                {
                    Console.WriteLine((i + 1) + " " + nameArray[i] + " | " + phoneNumberArray[i]);
                }


            }
            int recordSelect;
            Console.Write("Please select a record to delete: ");
            recordSelect = int.Parse(Console.ReadLine());
            nameArray[recordSelect - 1] = null;
            phoneNumberArray[recordSelect - 1] = null;
            MoveRecord();
            Console.WriteLine("Record " + recordSelect.ToString() + " has been Deleted");
            Console.ReadLine();
            Menu();
        }
        public static void MoveRecord()
        {
            int j = nameArray.Count() - 1;
            for (int i = 0; i < j; i++)
            {
                string tempName;
                string tempNum;
                if (nameArray[i] == null)
                {
                    tempName = nameArray[i + 1];
                    tempNum = phoneNumberArray[i + 1];
                    nameArray[i] = tempName;
                    phoneNumberArray[i] = tempNum;
                    nameArray[i + 1] = null;
                    phoneNumberArray[i + 1] = null;
                    i++;
                }
            }
        }

    }

}
