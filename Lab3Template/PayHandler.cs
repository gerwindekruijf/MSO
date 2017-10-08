using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab3
{
    class PayHandler
    {
        Scanner scanner;
        Transactie transactie = new Transactie();
        //Pricecalc calculator; 

        public PayHandler()
        {

        }

        //Deze twee parameters om uit te rekenen
        public void GiveBackCash()
        {
            //Laat geld eruit rollen
        }

        public void RequestPayment()
        {
            scanner.RequestCash();
        }

        public void HandlePayment()
        {
            //if(bedrag > ticket.prijs)
                //GiveBackCash();
        }

    }
}
