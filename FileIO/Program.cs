using System;
using System.IO;
class ReadFile
{
    public static void Main()
    {
        try
        {
            string path = @"c:\temp2\temp.txt";
            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
                Console.ReadLine();
            }
        }
        catch (Exception)
        {
            Console.WriteLine("File not found");
        }

    }
}