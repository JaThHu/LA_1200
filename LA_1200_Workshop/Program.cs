using System.Collections.Generic;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Reflection.Metadata;

namespace LA_1200_Workshop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\janic\OneDrive\Desktop\bötterflei.txt";

            string text = File.ReadAllText(path);

            string[] lines = text.Split("\r\n");
            int words = lines.Length;
            string[] email = new string[1000];
            string[] prio1 = new string[1000];
            string[] prio2 = new string[1000];
            string[] prio3 = new string[1000];

            




            



            List<string> schwimmen = new List<string>();
            List<string> tanzen = new List<string>();
            List<string> programmieren = new List<string>();







            for (int i = 0; ; i++)
            {
                if (prio1[i] == "Schwimmen")
                {
                    if (schwimmen.Count > 19)
                    {
                        schwimmen.Add(email[i]);
                    }
                    else
                    {
                        if (prio2[i] == "Tanzen")
                        {
                            if (tanzen.Count > 19)
                            {
                                tanzen.Add(email[i]);
                            }
                            else
                            {
                                if (prio3[i] == "Programmieren")
                                {
                                    programmieren.Add(email[i]);
                                }
                            }
                        }
                    }
                }

                for (int p = 0; ; p++)
                {
                    if (prio1[p] == "Programmieren")
                    {
                        if (programmieren.Count > 19)
                        {
                            programmieren.Add(email[p]);
                        }
                        else
                        {
                            if (prio2[p] == "Schwimmen")
                            {
                                if (schwimmen.Count > 19)
                                {
                                    schwimmen.Add(email[p]);
                                }
                                else
                                {
                                    if (prio3[p] == "Tanzen")
                                    {
                                        tanzen.Add(email[p]);
                                    }
                                }
                            }
                        }
                    }

                    for (int q = 0; ; q++)
                    {
                        if (prio1[q] == "Tanzen")
                        {
                            if (tanzen.Count > 19)
                            {
                                tanzen.Add(email[q]);
                            }
                            else
                            {
                                if (prio2[q] == "Programmieren")
                                {
                                    if (programmieren.Count > 19)
                                    {
                                        programmieren.Add(email[q]);
                                    }
                                    else
                                    {
                                        if (prio3[q] == "Schwimmen")
                                        {
                                            schwimmen.Add(email[q]);
                                        }
                                    }
                                }
                            }
                        }
                        string pathEinteilung = @"C:\Users\janic\OneDrive\Desktop\test.txt";
                        
                        int v = 0;
                        foreach(string items in schwimmen)
                        {
                            File.WriteAllText(pathEinteilung, schwimmen[v]);
                            v++;
                        }

                        int l = 0;
                        foreach (string items in programmieren)
                        {
                            File.WriteAllText(pathEinteilung, programmieren[l]);
                            l++;
                        }

                        int a = 0;
                        foreach (string items in tanzen)
                        {
                            File.WriteAllText(pathEinteilung, tanzen[a]);
                            a++;
                        }

                        

                    }
                    
                }
            }
        }
    }    
}
