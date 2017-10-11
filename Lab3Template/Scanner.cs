using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lab3
{
    class Scanner
    {
        Scanner scanner;
        IKEAMyntAtare2000 coinmachine;
        ICard card;

        //Deze twee methoden, zij hebben ook al een card en coinmachine class, beter passen we die aan
        public void RequestMoney()
        {
            if (1 == 1 /* klant klikt */ )
                coinmachine.starta();
            else
                card.Connect();
        }

        /*
        public void RequestCard() 
        {
            MessageBox.Show("Pin: ");
        }
        */ 
    }
}
