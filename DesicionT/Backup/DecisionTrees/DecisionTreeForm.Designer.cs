namespace DecisionTrees
{
    partial class DecisionTreeForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DecisionTreeForm));
            this.DecisiontreeView = new System.Windows.Forms.TreeView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonTest = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTest = new System.Windows.Forms.TextBox();
            this.comboBoxOtherAbility = new System.Windows.Forms.ComboBox();
            this.comboBoxage = new System.Windows.Forms.ComboBox();
            this.comboBoxsports = new System.Windows.Forms.ComboBox();
            this.comboBoxmorality = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxGrade = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // DecisiontreeView
            // 
            this.DecisiontreeView.Location = new System.Drawing.Point(6, 20);
            this.DecisiontreeView.Name = "DecisiontreeView";
            this.DecisiontreeView.Size = new System.Drawing.Size(235, 334);
            this.DecisiontreeView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.DecisiontreeView);
            this.groupBox1.Location = new System.Drawing.Point(2, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 360);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tree";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox2.Controls.Add(this.buttonTest);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.textBoxTest);
            this.groupBox2.Controls.Add(this.comboBoxOtherAbility);
            this.groupBox2.Controls.Add(this.comboBoxage);
            this.groupBox2.Controls.Add(this.comboBoxsports);
            this.groupBox2.Controls.Add(this.comboBoxmorality);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxGrade);
            this.groupBox2.Location = new System.Drawing.Point(253, 1);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(190, 360);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Test";
            // 
            // buttonTest
            // 
            this.buttonTest.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonTest.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.buttonTest.ForeColor = System.Drawing.Color.Green;
            this.buttonTest.Location = new System.Drawing.Point(67, 311);
            this.buttonTest.Name = "buttonTest";
            this.buttonTest.Size = new System.Drawing.Size(75, 36);
            this.buttonTest.TabIndex = 12;
            this.buttonTest.Text = "Test";
            this.buttonTest.UseVisualStyleBackColor = false;
            this.buttonTest.Click += new System.EventHandler(this.buttonTest_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(5, 263);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "result:";
            // 
            // textBoxTest
            // 
            this.textBoxTest.Location = new System.Drawing.Point(66, 262);
            this.textBoxTest.Name = "textBoxTest";
            this.textBoxTest.Size = new System.Drawing.Size(112, 21);
            this.textBoxTest.TabIndex = 10;
            // 
            // comboBoxOtherAbility
            // 
            this.comboBoxOtherAbility.FormattingEnabled = true;
            this.comboBoxOtherAbility.Items.AddRange(new object[] {
            "strong",
            "weak"});
            this.comboBoxOtherAbility.Location = new System.Drawing.Point(67, 202);
            this.comboBoxOtherAbility.Name = "comboBoxOtherAbility";
            this.comboBoxOtherAbility.Size = new System.Drawing.Size(112, 20);
            this.comboBoxOtherAbility.TabIndex = 9;
            this.comboBoxOtherAbility.SelectedIndexChanged += new System.EventHandler(this.comboBoxOtherAbility_SelectedIndexChanged);
            // 
            // comboBoxage
            // 
            this.comboBoxage.FormattingEnabled = true;
            this.comboBoxage.Items.AddRange(new object[] {
            "16-18",
            "19-21",
            "22-24"});
            this.comboBoxage.Location = new System.Drawing.Point(67, 161);
            this.comboBoxage.Name = "comboBoxage";
            this.comboBoxage.Size = new System.Drawing.Size(112, 20);
            this.comboBoxage.TabIndex = 8;
            this.comboBoxage.SelectedIndexChanged += new System.EventHandler(this.comboBoxage_SelectedIndexChanged);
            // 
            // comboBoxsports
            // 
            this.comboBoxsports.FormattingEnabled = true;
            this.comboBoxsports.Items.AddRange(new object[] {
            "positive",
            "sometimes",
            "nonparticipation"});
            this.comboBoxsports.Location = new System.Drawing.Point(66, 119);
            this.comboBoxsports.Name = "comboBoxsports";
            this.comboBoxsports.Size = new System.Drawing.Size(113, 20);
            this.comboBoxsports.TabIndex = 7;
            this.comboBoxsports.SelectedIndexChanged += new System.EventHandler(this.comboBoxsports_SelectedIndexChanged);
            // 
            // comboBoxmorality
            // 
            this.comboBoxmorality.FormattingEnabled = true;
            this.comboBoxmorality.Items.AddRange(new object[] {
            "good",
            "ordinary",
            "bad"});
            this.comboBoxmorality.Location = new System.Drawing.Point(66, 72);
            this.comboBoxmorality.Name = "comboBoxmorality";
            this.comboBoxmorality.Size = new System.Drawing.Size(113, 20);
            this.comboBoxmorality.TabIndex = 6;
            this.comboBoxmorality.SelectedIndexChanged += new System.EventHandler(this.comboBoxmorality_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ability:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "sports:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "morality:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "grade:";
            // 
            // comboBoxGrade
            // 
            this.comboBoxGrade.FormattingEnabled = true;
            this.comboBoxGrade.Items.AddRange(new object[] {
            "90-100",
            "80-89",
            "70-79",
            "0-69"});
            this.comboBoxGrade.Location = new System.Drawing.Point(67, 30);
            this.comboBoxGrade.Name = "comboBoxGrade";
            this.comboBoxGrade.Size = new System.Drawing.Size(112, 20);
            this.comboBoxGrade.TabIndex = 0;
            this.comboBoxGrade.SelectedIndexChanged += new System.EventHandler(this.comboBoxGrade_SelectedIndexChanged);
            // 
            // DecisionTreeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 365);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DecisionTreeForm";
            this.Text = "DecisionTreeForm";
            this.Load += new System.EventHandler(this.DecisionTreeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView DecisiontreeView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxGrade;
        private System.Windows.Forms.ComboBox comboBoxmorality;
        private System.Windows.Forms.ComboBox comboBoxsports;
        private System.Windows.Forms.ComboBox comboBoxage;
        private System.Windows.Forms.ComboBox comboBoxOtherAbility;
        private System.Windows.Forms.Button buttonTest;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTest;
    }
}

