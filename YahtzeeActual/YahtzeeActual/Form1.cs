using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeActual
{
    public partial class Form1 : Form
    {
        List<int> DiceList;
        int IntTotal = 0;
        int IntSum = 0;
        int IntBonus = 35;

        public Form1()
        {
            InitializeComponent();
        }

        private void Dice1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RollButton_Click(object sender, EventArgs e)
        {
            Dice temp = new Dice();
            Check checker = new Check();


            temp.roll(Dice1, DiceHold1);
            temp.roll(Dice2, DiceHold2);
            temp.roll(Dice3, DiceHold3);
            temp.roll(Dice4, DiceHold4);
            temp.roll(Dice5, DiceHold5);

             DiceList = new List<int>();
            DiceList.Add(Int32.Parse(Dice1.Text));
            DiceList.Add(Int32.Parse(Dice2.Text));
            DiceList.Add(Int32.Parse(Dice3.Text));
            DiceList.Add(Int32.Parse(Dice4.Text));
            DiceList.Add(Int32.Parse(Dice5.Text));

            checker.CountElements(DiceList);
            if (TOKButton.Enabled == true) {checker.ThreeOfAKind(DiceList,TOK); }
            if(FOK.Enabled == true) {checker.FourOfAKind(DiceList, FOK); }
            if (OnesButton.Enabled == true) { checker.Basic(1, DiceList, Ones); }
            if (TwosButton.Enabled == true) { checker.Basic(2, DiceList, Twos); }
            if (ThreesButton.Enabled == true) { checker.Basic(3, DiceList, Threes); }
            if (FoursButton.Enabled == true) { checker.Basic(4, DiceList, Fours); }
            if (FivesButton.Enabled == true) { checker.Basic(5, DiceList, Fives); }
            if (SixesButton.Enabled == true) { checker.Basic(6, DiceList, Sixes); }
            if (FullButton.Enabled == true) { checker.FullHouse(Full); }
            if (LargeButton.Enabled == true) { checker.LargeStright(Large); }
            if (SmallButton.Enabled == true) { checker.SmallStright(Small); }
            if (YahtzeeButton.Enabled == true) { checker.Yathzee(Yahtzee); }
            if (ChanceButton.Enabled == true) { checker.Chance(DiceList, Chance); }


        }

        private void OnesButton_Click(object sender, EventArgs e)
        {
            OnesButton.Enabled = false;
            IntTotal += Int32.Parse(Ones.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Ones.Text);
            Sum.Text = IntSum.ToString();

            if (IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }
        }

        private void TwosButton_Click(object sender, EventArgs e)
        {
            TwosButton.Enabled = false;
            IntTotal += Int32.Parse(Twos.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Twos.Text);
            Sum.Text = IntSum.ToString();

            if (IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }
        }

        private void ThreesButton_Click(object sender, EventArgs e)
        {
            ThreesButton.Enabled = false;
            IntTotal += Int32.Parse(Threes.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Threes.Text);
            Sum.Text = IntSum.ToString();

            if (IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }
        }

        private void FoursButton_Click(object sender, EventArgs e)
        {
            FoursButton.Enabled = false;
            IntTotal += Int32.Parse(Fours.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Fours.Text);
            Sum.Text = IntSum.ToString();
            if (IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }

        }

        private void FivesButton_Click(object sender, EventArgs e)
        {
            FivesButton.Enabled = false;
            IntTotal += Int32.Parse(Fives.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Fives.Text);
            Sum.Text = IntSum.ToString();

            if (IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }
        }

        private void SixesButton_Click(object sender, EventArgs e)
        {
            SixesButton.Enabled = false;
            IntTotal += Int32.Parse(Sixes.Text);
            Total.Text = IntTotal.ToString();
            IntSum += Int32.Parse(Sixes.Text);
            Sum.Text = IntSum.ToString();

            if( IntSum > 63)
            {
                Bonus.Text = IntBonus.ToString();
                IntTotal += IntBonus;
            }


        }

        private void TOKButton_Click(object sender, EventArgs e)
        {
            TOKButton.Enabled = false;
            IntTotal += Int32.Parse(TOK.Text);
            Total.Text = IntTotal.ToString();
        }

        private void FOKButton_Click(object sender, EventArgs e)
        {
            FOKButton.Enabled = false;
            IntTotal += Int32.Parse(FOK.Text);
            Total.Text = IntTotal.ToString();
        }

        private void FullButton_Click(object sender, EventArgs e)
        {
            FullButton.Enabled = false;
            IntTotal += Int32.Parse(Full.Text);
            Total.Text = IntTotal.ToString();
        }

        private void SmallButton_Click(object sender, EventArgs e)
        {
            SmallButton.Enabled = false;
            IntTotal += Int32.Parse(Small.Text);
            Total.Text = IntTotal.ToString();
        }

        private void LargeButton_Click(object sender, EventArgs e)
        {
            LargeButton.Enabled = false;
            IntTotal += Int32.Parse(Large.Text);
            Total.Text = IntTotal.ToString();
        }

        private void ChanceButton_Click(object sender, EventArgs e)
        {
            ChanceButton.Enabled = false;
            IntTotal += Int32.Parse(Chance.Text);
            Total.Text = IntTotal.ToString();
        }

        private void YahtzeeButton_Click(object sender, EventArgs e)
        {
            YahtzeeButton.Enabled = false;
            IntTotal += Int32.Parse(Yahtzee.Text);
            Total.Text = IntTotal.ToString();
        }
    }
}
