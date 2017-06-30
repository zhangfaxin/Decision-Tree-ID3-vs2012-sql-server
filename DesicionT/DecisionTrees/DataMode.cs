using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTrees
{
    public class DataMode
    {
        public string[,] dataArray = Form1.S.dataArray;
        private string[][] attribute = new string[6][];
        private string[] Items = new string[] { "Outlook", "Temperature", "Humidity", "Windy", "Play" };
        private int[] conditionAmount = new int[] { 3, 3, 2, 2, 2 };

        public DataMode()
        {

        }
        //初始化属性值
        public string[][] getAttribute()
        {
            attribute[0] = new string[3] { "sunny", "overcast", "rain" };
            attribute[1] = new string[3] { "hot", "mild", "cool" };
            attribute[2] = new string[2] { "high", "normal" };
            attribute[3] = new string[2] { "TRUE", "FALSE" };
            attribute[4] = new string[2] { "Yes", "No" };
            return attribute;
        }

        public int getAttributeByName(string name, string condition)
        {
            getAttribute();
            int index = getIndexOfItems(name);
            int sum = getChildAmountByName(name);
            for (int i = 0; i < sum; i++)
            {
                if (attribute[index][i].CompareTo(condition) == 0)
                {
                    return i;
                }
            }
            return 0;
        }
        public string[] getItems()
        {
            return Items;
        }
        public int getIndexOfItems(string name)
        {
            int index = 0;
            for (int i = 0; i <6; i++)
            {
                if (Items[i].CompareTo(name) == 0)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public string[,] getData()
        {
            return dataArray;
        }

        public int getChildAmountByName(string name)
        {
            return conditionAmount[getIndexOfItems(name)];
        }

        public int getDataAmount()
        {
            int counter = 14;
            
            return counter;
        }
    }
}
