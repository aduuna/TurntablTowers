using System;
using System.Collections.Generic;
using System.Text;

namespace TurntablTowers
{
    class TurntablTower
    {
        const int numFloors = 12;
        const int numDoors = 6;
        Apartment[,] apartments = new Apartment[numFloors,numDoors];
        string concierge;

        public TurntablTower(SortedList<string, int> apartmentTypes, string concierge)
        {
            this.concierge = concierge;

            // apartmentTypes = {"Basic":6, "Grand": 2, "Silver":4}
            foreach (KeyValuePair<string, int> apartmentType in apartmentTypes)
            {
                
                    int floors = apartmentType.Value;
                    for ( int floor = 0; floor < floors; floor++)
                    {
                        for (int apart = 0; apart < numDoors; apart++)
                        {
                            Apartment apartment;
                        if (apartmentType.Key == "Basic")
                            {
                                apartment = new BasicApartment(apart + 1, floor + 1);
                            }
                            else if (apartmentType.Key == "Grand")
                            {
                                apartment = new GrandApartment(apart + 1, floor + 1);
                            }
                            else {
                                apartment = new SilverApartment(apart + 1, floor + 1);
                            }
                            this.apartments[floor, apart] = apartment;
                        }
                    }

            }
        }

        public void TakeTheRegister()
        {
            
                foreach(Apartment apartment in apartments)
                {
                    Console.WriteLine(apartment.ToString());
                }
        }
    }
}
