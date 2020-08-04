using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Command_Contacts
{
    class SaveAndLoadManager
    {
        public static void Save (string email, string phone, string fullName)
        {
            string path = "C:/Users/wissamadib/Documents/" + fullName + ".contacts";
            string data = fullName + ":" + "\nEmail: " + email + "\nPhone: " + phone;
            File.WriteAllText(path, data);
        }
        public static string Load (string fullName)
        {
            string path = "C:/Users/wissamadib/Documents/" + fullName + ".contacts";
            string data = File.ReadAllText(path);
            return data;
        }
        public static void Delete (string fullName)
        {
            string path = "C:/Users/wissamadib/Documents/" + fullName + ".contacts";
            Console.Write("Are you sure? (Y/n): ");
            if (Console.ReadLine() == "Y")
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
                return;

            } else 
            {
                return;
            }
        }
    }
}
