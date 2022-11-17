using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;
using System.IO;

namespace WorkshopManager
{
    class Program
    {
        static int length = 1000;
        static string[] email = new string[length];
        static string[] prio1 = new string[length];
        static string[] prio2 = new string[length];
        static string[] prio3 = new string[length];

        static List<string> swimming = new List<string>();
        static List<string> dancing = new List<string>();
        static List<string> programming = new List<string>();

        static void readFile()
        {
            string path = @"C:\Users\janic\OneDrive\Desktop\bötterflei.txt";
            string text = File.ReadAllText(path);

            string[] lines = text.Split("\r\n");
            int words = lines.Length;

        }

        static void classificating()
        {
            for (int i = 0; i < prio1.Length; i++)
            {
                if (prio1[i] == "Schwimmen")
                {
                    if (swimming.Count > 19)
                    {
                        swimming.Add(email[i]);
                    }
                    else
                    {
                        if (prio2[i] == "Tanzen")
                        {
                            if (dancing.Count > 19)
                            {
                                dancing.Add(email[i]);
                            }
                            else
                            {
                                if (prio3[i] == "Programmieren")
                                {
                                    programming.Add(email[i]);
                                }
                            }
                        }
                    }
                }

                for (int p = 0; p < 1000; p++)
                {
                    if (prio1[p] == "Programmieren")
                    {
                        if (programming.Count > 19)
                        {
                            programming.Add(email[p]);
                        }
                        else
                        {
                            if (prio2[p] == "Schwimmen")
                            {
                                if (swimming.Count > 19)
                                {
                                    swimming.Add(email[p]);
                                }
                                else
                                {
                                    if (prio3[p] == "Tanzen")
                                    {
                                        dancing.Add(email[p]);
                                    }
                                }
                            }
                        }
                    }

                    for (int q = 0; q < 1000; q++)
                    {
                        if (prio1[q] == "Tanzen")
                        {
                            if (dancing.Count > 19)
                            {
                                dancing.Add(email[q]);
                            }
                            else
                            {
                                if (prio2[q] == "Programmieren")
                                {
                                    if (programming.Count > 19)
                                    {
                                        programming.Add(email[q]);
                                    }
                                    else
                                    {
                                        if (prio3[q] == "Schwimmen")
                                        {
                                            swimming.Add(email[q]);
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        static void printing()
        {
            string pathClassificating = @"C:\Users\janic\OneDrive\Desktop\test.txt";
            string toWrite = "";

            foreach (string item in swimming)
            {
                toWrite += item;

            }


            foreach (string item in programming)
            {
                toWrite += item;            
             }

            
            foreach (string item in dancing)
            {
                toWrite += item;
            }
            File.WriteAllText(pathClassificating, toWrite);
        }




        static void Main(string[] args)
        {
            readFile();

            classificating();

            printing();

        }

    }
}
