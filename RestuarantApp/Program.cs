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
                new Restaurant(3, "Din Tai Fung", "Taiwanese Cuisine", 4.7),
                new Restaurant(4, "KFC", "Thailand", 5.0),
                new Restaurant(5, "Teenoi", "Chonburi", 3.1),

            };

            Console.WriteLine("\n===== Restaurant List =====");

            foreach (Restaurant r in restuarants)
            {
                Console.WriteLine($"ID: {r.id} | Name: {r.name} | Type: {r.type} | Rating: {r.rating}");
            }

            // แสดงจำนวนร้านทั้งหมด
            Console.WriteLine($"\nTotal Restaurants: {restuarants.Count}");

            // คำนวณคะแนนเฉลี่ยของทุกร้าน
            double averageRating = restuarants.Average(r => r.rating);

            Console.WriteLine($"Average Rating: {averageRating:F2}");



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
