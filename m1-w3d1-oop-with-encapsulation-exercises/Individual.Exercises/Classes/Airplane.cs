using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Individual.Exercises.Classes
{
    public class Airplane
    {
        public Airplane(string planeNumber, int totalFirstClassSeats, int totalCoachSeats)
        {
            PlaneNumber = planeNumber;
            TotalFirstClassSeats = totalFirstClassSeats;
            TotalCoachSeats = totalCoachSeats;
        }

        public string PlaneNumber
        {
            get;
        }

        public int BookedFirstClassSeats
        {
            get;
            private set;
        }

        public int AvailableFirstClassSeats
        {
            get
            {
                int result = TotalFirstClassSeats - BookedFirstClassSeats;
                return result;
            }
        }

        public int TotalFirstClassSeats
        {
            get;
        }

        public int BookedCoachSeats
        {
            get;
            private set;
        }

        public int AvailableCoachSeats
        {
            get
            {
                int result = TotalCoachSeats - BookedCoachSeats;
                return result;
            }
        }

        public int TotalCoachSeats
        {
            get;
        }

        public bool ReserveSeats(bool forFirstClass, int totalNumberOfSeats)
        {
            if (forFirstClass)
            {
                if (totalNumberOfSeats > TotalFirstClassSeats)
                {
                    return false;
                }
                else
                {
                    BookedFirstClassSeats += totalNumberOfSeats;
                }
            }
            else
            {
                if (totalNumberOfSeats > TotalCoachSeats)
                {
                    return false;
                }
                else
                {
                    BookedCoachSeats += totalNumberOfSeats;
                }

            }
            return true;
        }
    }
}
