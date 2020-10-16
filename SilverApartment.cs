using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class SilverApartment : Apartment
    {
        public SilverApartment(int doorNumber, int floorNumber, string residentName) : base(doorNumber, floorNumber, residentName)
        {
        }

        public SilverApartment(int doorNumber, int floorNumber) : base(doorNumber, floorNumber)
        {
        }

        internal override void RingBell()
        {
            double rand = new Random().NextDouble();
            if (rand < 0.8)
            {
                Console.WriteLine("Hello");
            }
            else
            {
                throw new NobodyHomeException("Nobody is home");
            }
        }
    }
}
