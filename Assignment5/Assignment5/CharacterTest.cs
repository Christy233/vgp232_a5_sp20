using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Assignment5
{
    [TestFixture]
    class CharacterTest
    {
        Character character;
        [SetUp]
        public void Setup()
        {
            character = new Character("Apple", RaceCatagory.Human, 100);

        }

        [Test]
        public void TestDamageCharater()
        {
            character.TakeDamage(1);
            int expected = 99;
            int actual = character.HealthPoints;
            Assert.AreEqual(expected, actual);
        }
        [TestCase(1, 99)]
        [TestCase(10, 90)]
        [TestCase(100, 0)]
        public void TestDamageCharater(int damage,int expected)
        {
            character.TakeDamage(damage);
            int actual = character.HealthPoints;
            Assert.AreEqual(expected, actual);
        }

    }
}
