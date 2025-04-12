using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomLibrary
{
    public class Room
    {
        public readonly int Number;
        public int Beds { get; set; }
        public WindowOrientation Orientation { get; }
        public decimal PricePerDay { get; set; }
        public DateTime FreeFrom { get; set; }

        public Room(int number, int beds, WindowOrientation orientation)
        {
            Number = number;
            Beds = beds;
            Orientation = orientation;
        }

        public string[] GetInfo()
        {
            return new string[]
            {
                $"Номер: {Number}, Кроватей: {Beds}",
                $"Окна: {Orientation}, Цена: {PricePerDay} руб/сутки, Свободен с: {FreeFrom:g}"
            };
        }
    }
}