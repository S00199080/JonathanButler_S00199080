using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JonathanButler_S00199080;
using NUnit.Framework;

namespace JonathanButler_S00199080
{
    [TestFixture]
    class DecreasePriceTest
    {
        //This is my test that returns the incorrect result
        [Test]
        public static void Test()
        {
            Game z = new Game();
            Assert.AreEqual(1, z.DecreasePrice(5, 5));
        }

        //This is my test that returns the correct result
        [Test]
        public static void Test1()
        {
            Game z = new Game();
            Assert.AreEqual(0, z.DecreasePrice(5, 5)); //if the game is worth 5 and it is decreased by 5, it should return 0
        }



    }
}
