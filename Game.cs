using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JonathanButler_S00199080
{
    class Game
    {
        public string Name { get; set; }
        public double Score { get; set; }
        public string Description { get; set; }
        public string Platform { get; set; }
        public double Price { get; set; }
        public string Game_Image { get; set; }

        public double DecreasePrice(double discount, double price)
        {
            Price = price;

            Price = price - discount;
            return Price;
        }

        public class GameData : DbContext
        {
            public GameData() : base("GameData") { }

            public DbSet<Game> Games { get; set; }
        }

    }
}
