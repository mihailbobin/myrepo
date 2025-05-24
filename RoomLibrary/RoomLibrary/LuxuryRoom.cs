using System.Collections.Generic;

namespace RoomLibrary
{
    public class LuxuryRoom : SemiLuxuryRoom
    {
        public int NumberOfRooms { get; set; }
        public int MinRentalDays { get; set; }

        public LuxuryRoom(int number, int beds, WindowOrientation orientation, List<string> extraAmenities,
            int numberOfRooms, int minRentalDays)
            : base(number, beds, orientation, extraAmenities)
        {
            NumberOfRooms = numberOfRooms;
            MinRentalDays = minRentalDays;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                baseInfo[2],
                $"Количество комнат: {NumberOfRooms}, Мин. срок сдачи: {MinRentalDays} дней"
            };
        }
    }
}
