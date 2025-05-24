using System.Collections.Generic;

namespace RoomLibrary
{
    public class SemiLuxuryRoom : Room
    {
        public List<string> ExtraAmenities { get; set; }

        public SemiLuxuryRoom(int number, int beds, WindowOrientation orientation, List<string> extraAmenities)
            : base(number, beds, orientation)
        {
            ExtraAmenities = extraAmenities;
        }

        public override string[] GetInfo()
        {
            var baseInfo = base.GetInfo();
            string extras = $"Дополнительные удобства: {string.Join(", ", ExtraAmenities)}";

            return new string[]
            {
                baseInfo[0],
                baseInfo[1],
                extras
            };
        }
    }
}
