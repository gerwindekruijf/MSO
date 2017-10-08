using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        double price;
        Location destination, startLocation;
        bool isFirstClass, isRetour;

        public Ticket(double p, Location des, Location start, bool firstClass, bool retour)
        {
            price = p;
            destination = des;
            startLocation = start;
            isFirstClass = firstClass;
            isRetour = retour;          
        }
    }
}
