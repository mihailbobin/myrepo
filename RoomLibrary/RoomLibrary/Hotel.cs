using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace RoomLibrary
{
    public class Hotel : IEnumerable<Room>
    {
        public string Name { get; set; }
        public string Address { get; set; }

        private List<Room> rooms;

        public int Count => rooms.Count;

        public Hotel(string name, string address, IEnumerable<Room> roomCollection)
        {
            Name = name;
            Address = address;
            rooms = new List<Room>();

            foreach (var room in roomCollection)
            {
                if (!rooms.Contains(room))
                    rooms.Add(room);
            }
        }

        public IEnumerator<Room> GetEnumerator() => rooms.GetEnumerator();

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
