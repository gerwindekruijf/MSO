using System;
using System.Windows.Forms;

namespace Lab3
{
	public class IKEAMyntAtare2000
	{
        double geld;
        PayHandler pay;

		public void starta()
		{
			MessageBox.Show ("Välkommen till IKEA Mynt Ätare 2000");
		}

		public void stoppa()
		{
			MessageBox.Show ("Hejdå!");
		}

		public void betala(int pris)
		{
			MessageBox.Show (pris + " cent");
            if(geld != 0)
            {
                MessageBox.Show("You have paid");
                if (geld > pris)
                    pay.GiveBackCash(geld - pris);
            }
		}

        public double Money
        {
            get { return geld; }
        }
       
	}
}

