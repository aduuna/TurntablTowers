using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class GrandApartment : Apartment
    {
        public GrandApartment(int doorNumber, int floorNumber, string residentName) : base(doorNumber, floorNumber, residentName)
        {
        }

        public GrandApartment(int doorNumber, int floorNumber) : base(doorNumber, floorNumber)
        {
        }

        internal override void RingBell()
        {

            Console.WriteLine("Hello");
        }
    }

}
