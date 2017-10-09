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

        //Deze twee methoden, zij hebben ook al een card en coinmachine class, beter passen we die aan
        public void RequestCash()
        {
            MessageBox.Show("Betaal contant: ");
        }

        public void RequestCard() 
        {
            MessageBox.Show("Pin: ");
        }
    }
}
