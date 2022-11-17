// See https://aka.ms/new-console-template for more information
using crime;
using System.ComponentModel;
using System.IO;
public class Program
{
    static void Main(string[] args)
    {
        List<Crime> crimes = new List<Crime>();
        
        using (var reader = new StreamReader("crime.csv"))
        {
            //List<string> listA = new List<string>();
            //List<string> listB = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                Crime c1 = new Crime();

                for (int i = 0; i < 12; i++)
                {
                    c1 = new Crime(values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9], values[10], values[11]);
                }

                crimes.Add(c1);
                //year.Add(values[1]);
            }
        }

        for (int i = 0; i < crimes.Count; i++)
        {
            Console.WriteLine(crimes[i]);
        }
        Console.WriteLine("halo");
    }
}