using NUnit.Framework;
using RoomLibrary;
using System;
using System.Collections.Generic;
using System.Linq;

namespace RoomLibrary.UnitTests
{
    [TestFixture]
    public class RoomInterfacesTests
    {
        private Room[] rooms;

        [SetUp]
        public void Setup()
        {
            rooms = new[]
            {
                new Room(203, 2, WindowOrientation.East) { PricePerDay = 5000 },
                new Room(101, 1, WindowOrientation.North) { PricePerDay = 2500 },
                new Room(305, 3, WindowOrientation.South) { PricePerDay = 7500 },
                new Room(102, 2, WindowOrientation.West) { PricePerDay = 3000 }
            };
        }

        [Test]
        public void CompareTo_RoomNumberSorting()
        {
            var sorted = rooms.OrderBy(r => r).ToArray();
            var expected = new[] { 101, 102, 203, 305 };

            for (int i = 0; i < expected.Length; i++)
                Assert.That(sorted[i].Number, Is.EqualTo(expected[i]));
        }

        [Test]
        public void RoomPriceDescendingComparer_SortsByPriceDescending()
        {
            var comparer = new RoomPriceDescendingComparer();
            var sorted = rooms.OrderBy(r => r, comparer).ToArray();
            var expectedPrices = new[] { 7500, 5000, 3000, 2500 };

            for (int i = 0; i < expectedPrices.Length; i++)
                Assert.That(sorted[i].PricePerDay, Is.EqualTo(expectedPrices[i]));
        }

        [Test]
        public void Hotel_ConstructorAndEnumerationTest()
        {
            var hotel = new Hotel("Гранд Отель", "ул. Центральная, 1", rooms);

            Assert.That(hotel.Name, Is.EqualTo("Гранд Отель"));
            Assert.That(hotel.Address, Is.EqualTo("ул. Центральная, 1"));
            Assert.That(hotel.Count, Is.EqualTo(rooms.Length));

            int index = 0;
            foreach (var room in hotel)
                Assert.That(room, Is.EqualTo(rooms[index++]));
        }
    }
}
