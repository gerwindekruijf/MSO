using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class Printer
    {
        public Printer()
        {
        }

        private void Print(Ticket ticket)
        {
            string s = "no";
            string t = "no";
            if (ticket.isFirstClass)
                s = "yes";

            if (ticket.isRetour)
                t = "yes";

            string papier;
            papier = ticket.current.station + "to: " + ticket.destination.station
                + ticket.tijd.ToString() + "\n" + ticket.price.ToString() + "\n"
                + "First Class: " + s + "\n" + "Retour: " + t;  
            
            Flush(); 
        }

        private void Flush()
        {
            
        }

    }
}
