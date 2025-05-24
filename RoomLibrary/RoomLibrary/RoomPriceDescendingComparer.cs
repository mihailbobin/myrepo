using System.Collections.Generic;

namespace RoomLibrary
{
    public class RoomPriceDescendingComparer : IComparer<Room>
    {
        public int Compare(Room x, Room y)
        {
            if (x == null || y == null) return 0;
            return y.PricePerDay.CompareTo(x.PricePerDay); 
        }
    }
}
