using System;

namespace Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Contacts";
            if (args.Length == 0)
            {
                Program();
            } else
            {
                SaveAndLoadManager.Input(args[0]);
                Program();
            }
            void Program()
            {
                string function;
                function = Console.ReadLine();

                if (function == "new")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();

                    Console.Write("Email: ");
                    string email = Console.ReadLine();

                    Console.Write("Phone: ");
                    string phone = Console.ReadLine();

                    SaveAndLoadManager.Save(email, phone, name);

                    Console.WriteLine("Saved!");

                    Program();
                } else if (function == "load")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.WriteLine(SaveAndLoadManager.Load(name));
                    Program();
                } else if (function == "delete")
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    SaveAndLoadManager.Delete(name);
                    Program();
                }
                Program();
            }
        }
    }
}
