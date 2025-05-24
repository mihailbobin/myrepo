using System;

namespace RoomLibrary
{
    public class Room : IComparable<Room>
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

        public virtual string[] GetInfo()
        {
            return new string[]
            {
                $"Номер: {Number}, Кроватей: {Beds}",
                $"Окна: {Orientation}, Цена: {PricePerDay} руб/сутки, Свободен с: {FreeFrom:g}"
            };
        }

        public int CompareTo(Room other) => Number.CompareTo(other.Number);
    }
}
