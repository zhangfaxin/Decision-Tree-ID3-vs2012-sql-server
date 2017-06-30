using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
namespace DecisionTrees
{
    public partial class DecisionTreeForm : Form
    {
        private static  TreeNode rootNode = new TreeNode();
        private   TreeNode temp = new TreeNode();
        private static string rootName = "";
        
        private DataMode data = new DataMode();
        private ID3_Algorithm ID3Method = new ID3_Algorithm();

        public string grade = "", morality = "", sports = "", age = "", otherAbility = "";

        private int[] conditionAmount = new int[] {3,3,2, 2, 2 };
        public DecisionTreeForm()
        {
            InitializeComponent();
        }

        private void DecisionTreeForm_Load(object sender, EventArgs e)
        {
            createTreeView();
            comboBoxInitial();
        }
        public TreeNode getRoot()
        {
            return rootNode;
        }
        /// <summary>
        /// 决策树可视化
        /// </summary>
        private void createTreeView()
        {
            DataMode  data=new DataMode();
            TreeController Tree = new TreeController();
            ID3_Algorithm id = new ID3_Algorithm();
            Tree.initialFlash();
            Tree.initialisBuild();

            string[,] dataArray=data.getData();
            rootName = Tree.getTreeNodeName(0);

            rootNode.Text = rootName;
            rootNode.Name = rootName;
            rootNode.Tag = rootName;
            DecisiontreeView.Nodes.Add(rootNode);
            Tree.createChild(rootNode, rootName);
            temp.Name = rootNode.LastNode.Name;
            temp.Text = rootNode.LastNode.Text;
            temp.Tag = rootNode.LastNode.Tag;

            Tree.createTree(temp);
            DecisiontreeView.ExpandAll();         
          
        }
        /// <summary>
        /// 初始化comboBox
        /// </summary>
        private void comboBoxInitial()
        {
            comboBoxGrade.SelectedIndex = 0;
            comboBoxmorality.SelectedIndex = 0;
            comboBoxsports.SelectedIndex = 0;
            comboBoxage.SelectedIndex = 0;
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            textBoxTest.Text = getTestResult();
        }
        /// <summary>
        /// 获得测试结果
        /// </summary>
        /// <returns></returns>
        public string getTestResult()
        {
            TreeController Tree = new TreeController();

            string name = rootNode.Name;
            string condition = getCondition(name);

            int index=data.getAttributeByName(name,condition);

            while (condition.CompareTo("00")!=0)
            {
                if (index == 0)
                    name = Tree.FindNode(rootNode.FirstNode, condition).Name;
                else if (index == 1)
                    name = Tree.FindNode(rootNode.FirstNode.NextNode, condition).Name;
                else if (index == 2)
                    name = Tree.FindNode(rootNode.FirstNode.NextNode.NextNode, condition).Name;
                else
                    name = Tree.FindNode(rootNode.FirstNode.NextNode.NextNode.NextNode, condition).Name;

                condition = getCondition(name);
            }
            return name;
        }

        /// <summary>
        /// 获得决策条件
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        private string getCondition(string name)
        {
            string Condition = "";
            switch (name)
            {
                case "Outlook": Condition = grade; break;
                case "Temperature": Condition = morality; break;
                case "Humidity": Condition = sports; break;
                case "Windy": Condition = age; break;
                default: Condition = "00"; break;
            }
            return Condition;
        }

       
        /////////////////////////////////////////
        //下面都是comboBox的选择操作
        ////////////////////////////////////////
      
        private void comboBoxGrade_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index=comboBoxGrade.SelectedIndex;
            switch (index)
            {
                case 0: grade = "sunny"; break;
                case 1: grade = "overcast"; break;
                case 2: grade = "rain"; break;
            }
        }

        private void comboBoxmorality_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxmorality.SelectedIndex;
            switch (index)
            {
                case 0: morality = "hot"; break;
                case 1: morality = "mild"; break;
                case 2: morality = "cool "; break;
            }
        }

        private void comboBoxsports_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxsports.SelectedIndex;
            switch (index)
            {
                case 0: sports = "high"; break;
                case 1: sports = "normal"; break;
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = comboBoxage.SelectedIndex;
            switch (index)
            {
                case 0: age = "TRUE"; break;
                case 1: age = "FALSE"; break;
            }
        }


        private void DecisiontreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void textBoxTest_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
