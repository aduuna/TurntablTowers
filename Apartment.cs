using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
   abstract class Apartment
    {
        int doorNumber, floorNumber;
        string residentName;

        protected Apartment(int doorNumber, int floorNumber, string residentName)
        {
            this.doorNumber = doorNumber;
            this.floorNumber = floorNumber;
            this.residentName = residentName;
        }

        protected Apartment(int doorNumber, int floorNumber)
        {
            this.doorNumber = doorNumber;
            this.floorNumber = floorNumber;
        }

        internal abstract void RingBell();

        public override string ToString()
        {
            string occupant = this.residentName == null ? "Not occupied" : this.residentName;
            return ""+
                "Floor: " + this.floorNumber + ", " +
                "Door: " + this.doorNumber + ", " +
                "Occupant: " + occupant +
                "\n";
        }
        
    }
}
