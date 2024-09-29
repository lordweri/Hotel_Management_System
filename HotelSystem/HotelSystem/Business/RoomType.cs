using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelSystem;

namespace HotelSystem
{
    public class RoomType
    {
        public bool IsEnSuite { get; private set; }
        public bool IsCoupleSharingOneBed { get; private set; }
        public bool IsTwoPeopleSeparateBeds { get; private set; }
        public bool IsFamilyRoom { get; private set; }

        public RoomType(bool isEnSuite, bool isCoupleSharingOneBed, bool isTwoPeopleSeparateBeds, bool isFamilyRoom)
        {
            IsEnSuite = isEnSuite;
            IsCoupleSharingOneBed = isCoupleSharingOneBed;
            IsTwoPeopleSeparateBeds = isTwoPeopleSeparateBeds;
            IsFamilyRoom = isFamilyRoom;
        }

        public string GetRoomTypeDescription()
        {
            if (IsFamilyRoom)
                return "Family room (parents with children)";
            if (IsCoupleSharingOneBed)
                return "Couple sharing one bed";
            if (IsTwoPeopleSeparateBeds)
                return "Two people in separate beds";
            if (IsEnSuite)
                return "En-suite";
            return "Unknown room configuration";
        }
    }
}