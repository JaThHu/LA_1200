using System.Collections.Generic;
using System;



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
            string[] email = new string[words];
            string[] prio1 = new string[words];
            string[] prio2 = new string[words];
            string[] prio3 = new string[words];

            for (int Linie = 0; Linie < lines.Length; Linie++)
            {
                string[] items = lines[Linie].Split(';');
                email[Linie] = items[0];
                prio1[Linie] = items[1];
                prio2[Linie] = items[2];
                prio3[Linie] = items[3];

            }
            Console.WriteLine(email[1]);




            



            List<int> schwimmen = new List<int>();
            List<int> tanzen = new List<int>();
            List<int> programmieren = new List<int>();




            string x = "null";


            for (int i = 0; i < 20; i++)
            {
                do
                {
                    if (x == "schwimmen")
                    {
                        schwimmen.Add(i);
                    }
                    
                } while (schwimmen.Count == 19);



                for (int n = 0; n < 20; n++)
                {
                    do
                    {
                        if (x == "tanzen")
                        {
                            tanzen.Add(n);
                        } 
                    } while (tanzen.Count == 19);



                    for (int m = 0; m < 20; m++)
                    {
                        do
                        {
                            if (x == "programmieren")
                            {
                                programmieren.Add(m);
                            }
                        } while (programmieren.Count == 19);
                    }
                }
            }
        }
    }    
}
