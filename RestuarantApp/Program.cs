using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestuarantApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Restuarant> restuarants = new List<Restuarant>();




        }
    }

    public class Restuarant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double rating { get; set; }
        

    }
}
