using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _413_Assignment4.Models
{
    public class Restaurant
    {
        public Restaurant(int ranking)
        {
            rank = ranking;
        }

        public int rank { get; }
        public string name { get; set; }
        public string? favDish { get; set; } = "It's all tasty!";
        public string address { get; set; }
        public string? phoneNum { get; set; }
        public string? website { get; set; } = "Comming soon";

        public static Restaurant[] GetRestaurants()
        {
            Restaurant r1 = new Restaurant(1)
            {
                name = "Betos",
                address = "Springville Main Street"
            };

            Restaurant r2 = new Restaurant(2)
            {
                name = "Taco Bell",
                address = "Provo Main Street"
            };

            Restaurant r3 = new Restaurant(3)
            {
                name = "Mcdonalds",
                address = "Orem Main Street"
            };

            Restaurant r4 = new Restaurant(4)
            {
                name = "Firehouse Subs",
                address = "Mapleton Main Street"
            };

            Restaurant r5 = new Restaurant(5)
            {
                name = "Model T Cafe",
                address = "Spanish Fork Main Street"
            };


            return new Restaurant[] { r1, r2, r3, r4, r5 };
        }

    }
}
