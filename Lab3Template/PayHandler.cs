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
        IKEAMyntAtare2000 coinmachine;
        ICard card;
        UIInfo UI; 

        //Pricecalc calculator; 

        public PayHandler()
        {
        }

        //Deze twee parameters om uit te rekenen
        public void GiveBackCash(double wisselgeld)
        {
            //Geef geld terug
        }

        public void RequestPayment()
        {
            scanner.RequestMoney();
        }

        public void HandlePayment(Ticket ticket)
        {
            RequestPayment();
            if ((double)UI.Payment > ticket.price)
                GiveBackCash((double)UI.Payment - ticket.price);
        }

    }
}
