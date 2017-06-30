using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;

namespace DecisionTrees
{
    class TreeController
    {
        private DataMode data = new DataMode();
        private ID3_Algorithm ID3 = new ID3_Algorithm();
        private DecisionTreeForm Form = new DecisionTreeForm();

        private  TreeNode no;
        private  string tag;
        private  string name;
        private  string fatherTag = "";

        private static int[] flash;
        private static int[] isBuild = new int[5];
        private static int DataSize = 0;
        private int[] conditionAmount = new int[] { 4, 3, 3, 3, 2, 2 };

        private int positive = 0;
        private int All = 0;

        public TreeController()
        {
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void initialFlash()
        {
            DataSize = data.getDataAmount();
            flash = new int[DataSize];
            for (int i = 0; i < DataSize; i++)
            {
                flash[i] = 0;
            }
        }
        /// <summary>
        /// 初始化
        /// </summary>
        public void initialisBuild()
        {
            for (int i = 0; i < 5; i++)
                isBuild[i] = 0;
        }
        /// <summary>
        /// 获得flash的最大值
        /// </summary>
        /// <returns></returns>
        public int getMaxFlash()
        {
            int max = 0;
            for (int i = 0; i < DataSize; i++)
            {
                if (flash[i] > max)
                {
                    max = flash[i];
                }
            }
            return max;
        }
        public int[] getFlash()
        {
            return flash;
        }
        /// <summary>
        /// 递归查询决策树节点
        /// </summary>
        /// <param name="tnParent"></param>
        /// <param name="strValue"></param>
        /// <returns></returns>
        public TreeNode FindNode(TreeNode tnParent, string strValue)
        {

            if (tnParent == null) return null;

            if (tnParent.Tag.ToString().CompareTo(strValue) == 0)
            {
                return tnParent;
            }

            foreach (TreeNode tn in tnParent.Nodes)
            {

                if (FindNode(tn, strValue) != null)
                    return FindNode(tn, strValue);

            }
            return null;
        }
        /// <summary>
        /// 通过标记小化数据范围
        /// </summary>
        /// <param name="dataArray"></param>
        /// <param name="node"></param>
        public void smallDataByContidion(string[,] dataArray, TreeNode node)
        {
            string condition = "";
            int index;
            initialFlash();
            initialisBuild();
            while (node.Name.CompareTo(Form.getRoot().Name) != 0)
            {
                index = data.getIndexOfItems(FindNode(Form.getRoot(), node.Tag.ToString()).Parent.Name);
                condition = node.Tag.ToString();
                for (int i = 0; i < DataSize; i++)
                {
                    if (dataArray[i, index].CompareTo(condition) == 0)
                    {
                        flash[i]++;
                    }
                }
                node.Name = FindNode(Form.getRoot(), condition).Parent.Name;
                node.Tag = FindNode(Form.getRoot(), condition).Parent.Tag;
                isBuild[data.getIndexOfItems(node.Name)]++;
            }
        }
        /// <summary>
        /// 根据节点建立其子节点，即其每个属性的分支，这里子节点赋以默认值
        /// </summary>
        /// <param name="Node"></param>
        /// <param name="name"></param>
        public void createChild(TreeNode Node, string name)
        {
            int childAmount = data.getChildAmountByName(name), index = data.getIndexOfItems(name);
            string[][] Attribute = data.getAttribute();
            for (int i = 0; i < childAmount; i++)
            {
                TreeNode childNode = new TreeNode();
                childNode.Tag = Attribute[index][i];
                childNode.Text = Attribute[index][i];
                childNode.Name = "00";
               // childNode.Text = childNode.Name;
                Node.Nodes.Add(childNode);
            }
        }

        /// <summary>
        /// 判断某节点是否还有子节点
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public bool haveChildNode(TreeNode node)
        {
            if (node.Name.CompareTo("threeGoodStudent") == 0 || node.Name.CompareTo("substandard") == 0)
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 添加一个新的节点
        /// </summary>
        /// <param name="dataArray"></param>
        /// <param name="node"></param>
        /// <returns></returns>

        public string addNewNode(string[,] dataArray, TreeNode node)
        {
            bool end = true;
            TreeNode Node = new TreeNode();
            string NodeName = "";
            Node.Text = node.Text;
            Node.Tag = node.Tag;
            Node.Name = node.Name;

            smallDataByContidion(dataArray, node);

            double value = getGrain(getMaxFlash());
            
            for (int i = 0; i < 5;i++ )
            {
                if (isBuild[i] == 0)
                    end = false;
            }
            
            if (value < 0.1 ||end==true)//如果增益小于0.1，就直接添加叶子节点
            {
                if (positive > All - positive)
                {
                    FindNode(Form.getRoot(), Node.Tag.ToString()).Text = "threeGoodStudent" + "<" + FindNode(Form.getRoot(), Node.Tag.ToString()).Tag + ">";
                    FindNode(Form.getRoot(), Node.Tag.ToString()).Name = "threeGoodStudent";
                }
                else
                {
                    FindNode(Form.getRoot(), Node.Tag.ToString()).Text = "substandard" + "<" + FindNode(Form.getRoot(), Node.Tag.ToString()).Tag + ">";
                    FindNode(Form.getRoot(), Node.Tag.ToString()).Name = "substandard";
                }

            }
            else//添加节点
            {
               NodeName = getTreeNodeName(getMaxFlash());
                FindNode(Form.getRoot(), Node.Tag.ToString()).Text = NodeName + "<" + FindNode(Form.getRoot(), Node.Tag.ToString()).Tag + ">";
                FindNode(Form.getRoot(), Node.Tag.ToString()).Name = NodeName;
                createChild(FindNode(Form.getRoot(), Node.Tag.ToString()), NodeName);
            }
            return NodeName;
        }
        /// <summary>
        /// 建立一棵完整决策树
        /// </summary>
        /// <param name="treeCreate"></param>
        public void createTree(TreeNode treeCreate)
        {
            string[,] dataArray = data.getData();

            no = new TreeNode();
            no.Tag = treeCreate.Tag;
            no.Text = treeCreate.Text;
            no.Name = treeCreate.Name;
            name = no.Name;

            while (name.CompareTo(Form.getRoot().Name) != 0)
            {
                tag = no.Tag.ToString();
                name = no.Name;

                if (name.CompareTo("00") == 0)//建立该节点
                {
                    addNewNode(dataArray, no);
                    if (haveChildNode(FindNode(Form.getRoot(), tag)))
                    {
                        no = new TreeNode();
                        no.Text = FindNode(Form.getRoot(), tag).LastNode.Text;
                        no.Name = FindNode(Form.getRoot(), tag).LastNode.Name;
                        no.Tag = FindNode(Form.getRoot(), tag).LastNode.Tag;
                        fatherTag = tag;
                    }
                    else
                    {
                        if (FindNode(Form.getRoot(), tag).PrevNode == null)
                        {
                            no = new TreeNode();
                            no.Text = FindNode(Form.getRoot(), tag).Parent.Text;
                            no.Name = FindNode(Form.getRoot(), tag).Parent.Name;
                            no.Tag = FindNode(Form.getRoot(), tag).Parent.Tag;

                        }
                        else
                        {
                            no = new TreeNode();
                            no.Text = FindNode(Form.getRoot(), tag).PrevNode.Text;
                            no.Name = FindNode(Form.getRoot(), tag).PrevNode.Name;
                            no.Tag = FindNode(Form.getRoot(), tag).PrevNode.Tag;

                        }
                    }
                  
                }
                else//返回上一节点
                {
                    if (FindNode(Form.getRoot(), tag).PrevNode != null)
                    {
                        no = new TreeNode();
                        no.Text = FindNode(Form.getRoot(), tag).PrevNode.Text;
                        no.Name = FindNode(Form.getRoot(), tag).PrevNode.Name;
                        no.Tag = FindNode(Form.getRoot(), tag).PrevNode.Tag;
                    }
                    else
                    {
                        if (FindNode(Form.getRoot(), tag).Name.CompareTo(Form.getRoot().Name) != 0)
                        {
                            no = new TreeNode();
                            no.Text = FindNode(Form.getRoot(), tag).Parent.Text;
                            no.Name = FindNode(Form.getRoot(), tag).Parent.Name;
                            no.Tag = FindNode(Form.getRoot(), tag).Parent.Tag;
                        }
                    }
                }

            }
        }
        //
        /// <summary>
        /// 
        /// </summary>
        /// <param name="array"></param>
        /// <param name="maxFlash"></param>
        /// <returns></returns>
        public double getEntropy_S(string[,] array, int maxFlash)
        {
            int i = 0, counter = 0;

            while (i < data.getDataAmount())
            {
                if (maxFlash == flash[i]&&array[i, 5].CompareTo("threeGoodStudent") == 0)
                {
                    counter++;
                 }
                i++;
            }

            All = getCounterOfMaxFlash();
            positive = counter;

            return ID3.getEntropy(counter, All - counter);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int getCounterOfMaxFlash()
        {
            int i = 0, sum = 0, maxFlash = getMaxFlash();
            while (i < data.getDataAmount())
            {
                if (maxFlash == flash[i])
                {
                    sum++;
                }
                i++;
            }
            return sum;
        }
        /// <summary>
        /// 获得信息增益
        /// </summary>
        /// <param name="name"></param>
        /// <param name="maxFlash"></param>
        /// <returns></returns>
        public double getEntropyByItems(string name, int maxFlash)
        {
            int index = data.getIndexOfItems(name), size = conditionAmount[index];//, maxFlash = getMaxFlash();
            string[][] attribute = data.getAttribute();
            string[,] Data = data.getData();

            double[] numerator = new double[size+1];
            double[] enominator = new double[size+1];
 
            int i, j;
            double result = 0.0;

            for (i = 0; i < size; i++)
            {
                numerator[i] = 0.0;
                enominator[i] = 0.0;
            }

            for (i = 0; i < size; i++)
            {
                for (j = 0; j < data.getDataAmount(); j++)
                {
                    if (maxFlash == flash[j]&&Data[j, index].CompareTo(attribute[index][i]) == 0 )
                    {
                        enominator[i]++;
                        if (Data[j, 5].CompareTo("threeGoodStudent") == 0)
                            numerator[i]++;
                    }
                }
            }

            for (i = 0; i < size; i++)
            {
                result = result + (enominator[i] / getCounterOfMaxFlash() * 1.00) * ID3.getEntropy(numerator[i], enominator[i] - numerator[i]);
            }
            return getEntropy_S(Data, maxFlash) - result;
        }

        /// <summary>
        /// 获得Grain
        /// </summary>
        /// <param name="maxFlash"></param>
        /// <returns></returns>
        public double getGrain(int maxFlash)
        {
            string[] Items = data.getItems();
            double result = 0.0;

            for (int i = 0; i < 5; i++)
            {
                double compare = getEntropyByItems(Items[i], maxFlash);
                if (compare > result && isBuild[i]==0)
                {
                    result = compare;
                }
            }
            return result;
        }

        /// <summary>
        /// 获得节点的名称
        /// </summary>
        /// <param name="maxFlash"></param>
        /// <returns></returns>
        public string getTreeNodeName(int maxFlash)
        {
            string[] Items = data.getItems();
            int maxIndex = 0;
            double result = -0.01;
            for (int i = 0; i < 5; i++)
            {
                double compare = getEntropyByItems(Items[i], maxFlash);

                if (maxFlash == 0 && compare < 0.05)
                {
                    isBuild[i]++;
                }
                
                if (compare > result && isBuild[i] == 0)
                {
                    result = compare;
                    maxIndex = i;
                }
            }
            return Items[maxIndex];
        }
    }
}
