using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrandC
{
    public class Furdo
    {
        public string név { get; private set; }
        public string cím { get; private set; }
        public int ár { get; private set; }
        public int vizhofok { get; private set; }
        public Furdo(string sor)
        {
            string[] adatok = sor.Split(";");
            név = adatok[0];
            cím = adatok[1];
            ár = int.Parse(adatok[2]);
            vizhofok = int.Parse(adatok[3]);

        }
        public string IRSZ()
        {
            return cím.Split(" ")[0];
        }
        public string telepules()
        {
            return cím.Split(" ")[1].Split(" ")[0];
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                List<Furdo> list = new List<Furdo>();
                string[] sorok = File.ReadAllLines("strandadatok.txt").Skip(1).ToArray();
                foreach (string s in sorok)
                {
                    list.Add(new Furdo(s));
                }
                Console.WriteLine($"7. feladat: Strandok száma: {list.Count}");
            }
        }
    }
}
