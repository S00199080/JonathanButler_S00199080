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
        [Test]

        public static void Test()
        {
            Game z = new Game();
            Assert.AreEqual(1, z.DecreasePrice(5, 5));
        }

        [Test]

        public static void Test1()
        {
            Game z = new Game();
            Assert.AreEqual(0, z.DecreasePrice(5, 5));
        }



    }
}
