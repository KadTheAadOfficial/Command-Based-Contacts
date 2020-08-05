using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Contacts
{
    class SaveAndLoadManager
    {
        public static void Save (string email, string phone, string name)
        {
            string path = "path" + name + ".clcontacts";
            string data = name + ":" + "\nEmail: " + email + "\nPhone: " + phone;
            File.WriteAllText(path, data);
            return;
        }
        public static string Load (string name)
        {
            string path = "path" + name + ".clcontacts";
            string data = File.ReadAllText(path);
            return data;
        }
        public static void Delete (string name)
        {
            string path = "path" + name + ".clcontacts";
            Console.Write("Are you sure? (Y/n): ");
            if (Console.ReadLine() == "Y")
            {
                File.Delete(path);
                Console.WriteLine("File Deleted");
                return;
            } else if (Console.ReadLine() == "n")
            {
                return;
            }
        }
        public static void Input (string path)
        {
            string data = File.ReadAllText(path);
            Console.WriteLine(data);
            return;
        }
    }
}
