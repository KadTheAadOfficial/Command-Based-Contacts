using System;

namespace Command_Contacts
{
    class Program
    {
        static void Main(string[] args)
        {
            Program();
            void Program()
            {
                Console.Title = "Contacts";
                string function;
                function = Console.ReadLine();

                if (function == "new") {
                    Console.Write("Full Name: ");
                    string fullName;
                    fullName = Console.ReadLine();

                    Console.Write("Email: ");
                    string Email;
                    Email = Console.ReadLine();

                    Console.Write("Phone: ");
                    string Phone;
                    Phone = Console.ReadLine();

                    SaveAndLoadManager.Save(Email, Phone, fullName);

                    Console.WriteLine("Saved!");

                    Program();
                } else if (function == "load")
                {
                    Console.Write("Full Name: ");
                    string fullNameLoad;
                    fullNameLoad = Console.ReadLine();
                    Console.WriteLine(SaveAndLoadManager.Load(fullNameLoad));
                    Program();
                } else if (function == "delete")
                {
                    Console.Write("Name: ");
                    string Name;
                    Name = Console.ReadLine();
                    SaveAndLoadManager.Delete(Name);
                    Program();
                }
                Program();
            }
        }
    }
}
