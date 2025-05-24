using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace RoomLibrary.UnitTests
{
    [TestFixture]
    public class RoomExtensionsUnitTests
    {
        [Test]
        public void SemiLuxuryRoom_GetInfo_Test()
        {
            var room = new SemiLuxuryRoom(102, 2, WindowOrientation.East, new List<string> { "Мини-бар", "Балкон" })
            {
                PricePerDay = 4500,
                FreeFrom = new DateTime(2025, 6, 1)
            };

            var info = room.GetInfo();

            Assert.That(info.Length, Is.EqualTo(3));
            Assert.That(info[2], Is.EqualTo("Дополнительные удобства: Мини-бар, Балкон"));
        }

        [Test]
        public void LuxuryRoom_GetInfo_Test()
        {
            var room = new LuxuryRoom(201, 3, WindowOrientation.West, new List<string> { "Джакузи", "Сауна" },
                2, 5)
            {
                PricePerDay = 7500,
                FreeFrom = new DateTime(2025, 7, 10)
            };

            var info = room.GetInfo();

            Assert.That(info.Length, Is.EqualTo(4));
            Assert.That(info[2], Is.EqualTo("Дополнительные удобства: Джакузи, Сауна"));
            Assert.That(info[3], Is.EqualTo("Количество комнат: 2, Мин. срок сдачи: 5 дней"));
        }
    }
}
