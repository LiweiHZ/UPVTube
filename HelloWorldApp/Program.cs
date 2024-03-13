using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace HelloWorldApp
{
    internal class Program
    {
        static List<String> nationalities;
        static void initList()
        {
            nationalities = new List<String>()
            {
                "mongo",
                "dongo",
                "pongo",    
                "longo",
                "fongo"
            };
        }
        static void Main(string[] args)
        {
            initList();
            nationalities.Sort();
            foreach (String s in nationalities) {
                Console.WriteLine(s);
            }
        }
    }
}
