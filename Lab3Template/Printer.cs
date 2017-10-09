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
            //Zoiets? 
            string bon;
            bon = ticket.tijd.ToString() + "\n" + ticket.price.ToString() + "\n"
                + ticket.startLocation.location + "to: " + ticket.destination.location;
            Flush(); 
        }

        private void Flush()
        {

        }

    }
}
