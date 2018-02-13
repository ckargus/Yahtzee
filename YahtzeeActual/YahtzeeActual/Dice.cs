using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeActual
{
    public class Dice
    {
        public Dice()
        {
        }

        public void roll(TextBox text, CheckBox check)
        {
            if (check.Checked == false)
            {
                Random rand = new Random();
                text.Text =  rand.Next().ToString();
            }

        }

    }
}
