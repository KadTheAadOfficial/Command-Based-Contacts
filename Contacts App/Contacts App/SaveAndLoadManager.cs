using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Contacts_App
{
    class SaveAndLoadManager
    {
        public static void Save (string email, string phone, string name)
        {
            string path = "path" + name + ".contactsapp";
            string data = name + ":" + "\nEmail: " + email + "\nPhone: " + phone;
            File.WriteAllText(path, data);
            return;
        }
        public static string Load (string name)
        {
            string path = "path" + name + ".contactsapp";
            string data = File.ReadAllText(path);
            return data;
        }
        public static void Delete (string name)
        {
            string path = "path" + name + ".contactsapp";
            Console.Write("Are you sure? (Y/n): ");
            if (Console.ReadLine() == "n")
            {
                return;
            } else
            {
                File.Delete(path);
                Console.WriteLine("File Deleted!");
                return;
            }
        }
        public static void Input (string path)
        {
            Console.WriteLine(File.ReadAllText(path));
            return;
        }
    }
}