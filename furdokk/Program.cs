using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace StrandC
{
    public class Furdo {
        public String név { get; private set; }
        public string cím { get; private set; }
        public int ár { get; private set; }
        public int vizhofok { get; private set; }
    }
    public Furdo(string sor)
        {
            string[] adatok = sor.Split(";");
            név=adatok[0];
            cím = adatok[1];
            ár = int.Parse(adatok[2]);
            vizhofok = int.Parse(adatok[3]);

        }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        } 
    }
}
