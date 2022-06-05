using System;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Linq;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            string year = Console.ReadLine();
            string line = "";
            string s = "";
            while((line=Console.ReadLine()) != null && line != "")
            {
                s += line;
            }

            var xdoc = XDocument.Parse(s);

            
            var q = xdoc.Descendants("Customer");

            foreach(var x in q)
            {
                x?.Descendants("Order").Select(x => x);

                Console.WriteLine(x.Descendants("CompanyName"));
            }
            

        }
    }
}
