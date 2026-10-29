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
            Console.WriteLine("Hello SIT.1/1");
            Console.WriteLine("Week 2");

            List<Restaurant> restuarants = new List<Restaurant>
            {
                new Restaurant(1, "Quanjude Roast Duck", "Beijing Cuisine", 4.5),
                new Restaurant(2, "Donglaishun Hot Pot", "Hot Pot", 4.6),
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7)
            };




        }
    }

    public class Restaurant
    {
        public int id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public double rating { get; set; }
        
        public Restaurant(int id,string name,string type, double rate)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.rating = rate;
        }

    }
}
