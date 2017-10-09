using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        public double price;
        public Location destination, startLocation;
        public bool isFirstClass, isRetour;
        public DateTime tijd; //Tijd is zeker belangrijk

        public Ticket(double p, Location des, Location start, bool firstClass, bool retour, DateTime t)
        {
            price = p;
            destination = des;
            startLocation = start;
            isFirstClass = firstClass;
            isRetour = retour;
            tijd = t;          
        }
    }
}
