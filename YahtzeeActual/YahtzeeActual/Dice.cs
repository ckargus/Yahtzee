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
        private Random rand = new Random();
        public Dice()
        {
        }

        public void roll(Label text, CheckBox check)
        {
            if (check.Checked == false)
            {
                
                text.Text =  (rand.Next() % 6 + 1).ToString();
            }

        }

    }
}
