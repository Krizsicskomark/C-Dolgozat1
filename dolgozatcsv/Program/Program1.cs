using Library.Data;
using Library.Models;
using System;

namespace Program
{
    public class Program1
    {
        static void KiIr(IEnumerable<object> adatok)
        {
            foreach (var item in adatok)
                Console.WriteLine(item.ToString());
            Console.WriteLine();
        }

        static void Main(string[] args)
        {

            AdatContext db = new AdatContext();

            if (!db.Adatok.Any())
            {
                var sorok = File.ReadAllLines(@"c:\Users\Diak\KM\dolgozat\1.csv").Skip(1);
                foreach (var line in sorok)
                {
                    db.Adatok.Add(new Adatok(line));
                    db.SaveChanges();
                }
            }

            KiIr(db.Adatok);
        }
    }
}
