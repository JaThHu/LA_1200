using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public static class DataManager
    {
        /// <summary>
        /// Asks the User for a csv/txt file and returns its fetched contents.
        /// </summary>
        /// <returns>Fetched Contents</returns>
        public static User[] LoadData()
        {
            string file = null;


            while (file == null || !File.Exists(file))
            {
                if (file != null)
                    Console.WriteLine("File does not exist");

                Console.Write("Enter file path: ");
                file = Console.ReadLine();
                string[] temp = file.Split('"');
                file = "";
                for (int i = 0; i < temp.Length; i++)
                {
                    file += temp[i];
                }

            }

            string[][] _users = loadData(file);
            User[] users = new User[_users.Length];

            for (int i = 0; i < _users.Length; i++)
            {
                string[] usr = _users[i];
                users[i] = new User()
                {
                    Mail = usr[0],
                    Prior1 = usr[1],
                    Prior2 = usr[1],
                    Prior3 = usr[1]
                };
            }

            return users;
        }

        static string[][] loadData(string path)
        {
            string[] data = File.ReadAllLines(path);

            string[][] users = new string[data.Length][];

            for (int i = 0; i < data.Length; i++)
            {
                users[i] = data[i].Split(';');
            }

            return users;
        }
    }


    public class User
    {
        public string Mail { get; set; }
        public string Prior1 { get; set; }
        public string Prior2 { get; set; }
        public string Prior3 { get; set; }
    }
}
