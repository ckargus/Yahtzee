using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YahtzeeActual
{
   class Check
    {
        private List<int> elementCount;
        public void CountElements(List<int> list)
        {
            elementCount = new List<int>();
            for(int i = 0; i < 6; i++)
            {
                elementCount.Add(0);
            }
            foreach (int x in list)
            {
                if (x == 1)
                {
                    elementCount[0]++;
                }
                else if (x == 2)
                {
                    elementCount[1]++;
                }
                else if (x == 3)
                {
                    elementCount[2]++;
                }
                else if (x == 4)
                {
                    elementCount[3]++;
                }
                else if (x == 5)
                {
                    elementCount[4]++;
                }
                else if (x == 6)
                {
                    elementCount[5]++;
                }
            }
        }
        public void Basic(int finding, List<int> list, Label text)
        {
            int temp = 0;
            foreach(int x in list)
            {
                if(x == finding)
                {
                    temp += finding;
                }
            }
            text.Text = temp.ToString();
        }
        public void ThreeOfAKind(List<int> list, Label text)
        {
            int temp = 0;
            foreach(int x in elementCount)
            {
                if(x >= 3)
                {
                    foreach(int y in list)
                    {
                        temp += y;
                    }
                }
            }
            text.Text = temp.ToString();
        }
        public void FourOfAKind(List<int> list, Label text)
        {
            int temp = 0;
            foreach (int x in elementCount)
            {
                if (x >= 4)
                {
                    foreach (int y in list)
                    {
                        temp += y;
                    }
                }
            }
            text.Text = temp.ToString();
        }
        public void Yathzee(Label text)
        {
            foreach (int x in elementCount)
            {
                if (x >= 5)
                {
                    text.Text = "50";
                    return;
                }
            }
            text.Text = "0";
        }
        public void SmallStright(Label text)
        {
            bool stright = false;
            if(elementCount[0] > 0 && elementCount[1] > 0 && elementCount[2] > 0 && elementCount[3] > 0)
            {
                stright = true;
            }
            else if(elementCount[1] > 0 && elementCount[2] > 0 && elementCount[3] > 0 && elementCount[4] > 0)
            {
                stright = true;
            }
            else if (elementCount[2] > 0 && elementCount[3] > 0 && elementCount[4] > 0 && elementCount[5] > 0)
            {
                stright = true;
            }
            if(stright)
            {
                text.Text = "30";
            }
            else
            {
                text.Text = "0";
            }
        }
        public void LargeStright(Label text)
        {
            bool stright = false;
            if (elementCount[0] > 0 && elementCount[1] > 0 && elementCount[2] > 0 && elementCount[3] > 0 && elementCount[4] > 0)
            {
                stright = true;
            }
            else if (elementCount[1] > 0 && elementCount[2] > 0 && elementCount[3] > 0 && elementCount[4] > 0 && elementCount[5] > 0)
            {
                stright = true;
            }
            if (stright)
            {
                text.Text = "40";
            }
            else
            {
                text.Text = "0";
            }
        }
        public void Chance(List<int> list, Label text)
        {
            int temp = 0;
            foreach(int x in list)
            {
                temp += x;
            }
            text.Text = temp.ToString();
        }
        public void FullHouse(Label text)
        {
            foreach (int x in elementCount)
            {
                if (x == 3)
                {
                    foreach (int y in elementCount)
                    {
                        if (y == 2)
                        {
                            text.Text = "25";
                            return;
                        }
                    }
                }
            }
            text.Text = "0";
        }
    }
}
