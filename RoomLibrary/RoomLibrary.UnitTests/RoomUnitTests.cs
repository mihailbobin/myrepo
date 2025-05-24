using NUnit.Framework;
using System;

namespace RoomLibrary.UnitTests
{
    [TestFixture]
    public class RoomUnitTests
    {
        [Test]
        public void ConstructorTest()
        {
            var room = CreateTestRoom();

            Assert.That(room.Number, Is.EqualTo(101));
            Assert.That(room.Beds, Is.EqualTo(2));
            Assert.That(room.Orientation, Is.EqualTo(WindowOrientation.South));
        }

        [Test]
        public void GetInfoTest()
        {
            var room = CreateTestRoom();
            var info = room.GetInfo();

            Assert.That(info.Length, Is.EqualTo(2));
            Assert.That(info[0], Is.EqualTo("Номер: 101, Кроватей: 2"));
            Assert.That(info[1], Is.EqualTo(
                $"Окна: South, Цена: 3500 руб/сутки, Свободен с: {room.FreeFrom:g}"));
        }

        private Room CreateTestRoom()
        {
            var room = new Room(101, 2, WindowOrientation.South)
            {
                PricePerDay = 3500,
                FreeFrom = new DateTime(2025, 5, 1, 12, 0, 0)
            };
            return room;
        }
    }
}