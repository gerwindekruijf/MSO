using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Printer
    {
        string papier;
        public Printer()
        {
        }

        //Print Handler erbij 
        private void Print(Ticket ticket)
        {
            string s = "no";
            string t = "no";
            if (ticket.isFirstClass)
                s = "yes";

            if (ticket.isRetour)
                t = "yes";

            papier = ticket.current.station + "to: " + ticket.destination.station
                + ticket.tijd.ToString() + "\n" + ticket.price.ToString() + "\n"
                + "First Class: " + s + "\n" + "Retour: " + t;

            MessageBox.Show(papier);
            Flush();

        }

        private void Flush()
        {
            //Flush inkt man broer
            papier = "";
        }

    }
}
