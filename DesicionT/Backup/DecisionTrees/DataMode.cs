using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecisionTrees
{
    public class DataMode
    {
        private string[,] dataArray = new string[20, 6]{
        { "90-100", "bad", "positive", "16-18", "strong", "substandard" },
        { "90-100", "bad", "positive", "16-18", "weak", "substandard" },
        { "90-100", "bad", "sometimes", "19-21", "weak", "substandard" },
        { "90-100", "good", "positive", "22-24", "strong", "threeGoodStudent" },
        { "90-100", "ordinary", "positive", "19-21", "weak", "threeGoodStudent" },
        { "90-100", "bad", "sometimes", "16-18", "weak", "substandard" },
        { "80-89", "good", "sometimes", "16-18", "strong", "threeGoodStudent" },
        { "80-89", "good", "sometimes", "16-18", "weak", "threeGoodStuden" },
        { "80-89", "ordinary", "sometimes", "16-18", "strong", "threeGoodStudentr" },
        { "70-79", "ordinary", "positive", "22-24", "weak", "substandard" },
        { "0-69", "ordinary", "sometimes", "19-21", "weak", "substandard" },       
        { "80-89", "ordinary", "sometimes", "16-18", "strong", "threeGoodStuden" },
        { "80-89", "ordinary", "positive", "16-18", "weak", "substandard" },
        { "90-100", "bad", "sometimes", "22-24", "weak", "substandard" },
        { "80-89", "ordinary", "sometimes", "16-18", "strong", "threeGoodStudent" },
        { "80-89", "ordinary", "positive", "16-18", "strong", "threeGoodStudent" },
        { "70-79", "good", "sometimes", "22-24", "strong", "substandard" },
        { "70-79", "good", "sometimes", "22-24", "strong", "substandard" },
        { "0-69", "good", "positive", "22-24", "strong", "substandard" },
        { "0-69", "good", "positive", "19-21", "strong", "substandard" }};
        
        private string[][] attribute = new string[6][];

        private string[] Items = new string[] { "grade", "morality", "sports", "age", "otherAbility", "whetherThreeGood" };

        private int[] conditionAmount = new int[] { 4, 3, 3, 3, 2, 2 };

        public DataMode()
        {
        }
        //初始化属性值
        public string[][] getAttribute()
        {
            attribute[0]=new string[4]{"90-100","80-89","70-79","0-69"};
            attribute[1] = new string[3] { "good", "ordinary","bad"};
            attribute[2] = new string[3] { "positive", "sometimes", "nonparticipation" };
            attribute[3] = new string[3] { "16-18", "19-21", "22-24" };
            attribute[4] = new string[2] { "strong", "weak" };
            attribute[5] = new string[2] { "threeGoodStudent", "substandard" };
            return attribute;
        }

        public int getAttributeByName(string name,string condition)
        {
            getAttribute();
            int index=getIndexOfItems(name);
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
            for (int i = 0; i < 6; i++)
            {
                if (Items[i].CompareTo(name)==0)
                {
                    index=i;
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
            int counter=20;
            return counter;
        }
    }
}
