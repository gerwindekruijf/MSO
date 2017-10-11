using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Ticket
    {
        public double price;
        public Trainstation destination, current;
        public bool isFirstClass, isRetour;
        public DateTime tijd; //Tijd is zeker belangrijk

        public Ticket(double p, Trainstation des, Trainstation start, bool firstClass, bool retour, DateTime t)
        {
            price = p;
            destination = des;
            current = start;
            isFirstClass = firstClass;
            isRetour = retour;
            tijd = t;          
        }
    }
}
