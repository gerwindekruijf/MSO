using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
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

            Console.Write(papier);
            Flush();

        }

        private void Flush()
        { 
        }

    }
}
