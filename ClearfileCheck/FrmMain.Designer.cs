﻿namespace ClearfileCheck
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "jsmx01_js326.a27",
            "√",
            "√"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))), null);
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "jsmx02_js326.a27",
            "×",
            "×"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))), null);
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("......");
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("上交所过户文件");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("中登上海");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("中登深圳");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("股转");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("北交所");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("中登账户");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("TA&多金");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("所有文件", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7});
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
            "上交所",
            "11/20",
            "×"}, -1);
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
            "中登上海",
            "20/20",
            "√"}, -1);
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("中登深圳");
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem("股转");
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("北交所");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem("中登账户");
            System.Windows.Forms.ListViewItem listViewItem10 = new System.Windows.Forms.ListViewItem("TA&多金");
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lvFile = new System.Windows.Forms.ListView();
            this.clmHead0 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHead4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tvFolder = new System.Windows.Forms.TreeView();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lvStatus = new System.Windows.Forms.ListView();
            this.文件源 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.进度 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.是否收齐 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(12, 361);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(799, 56);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "18:24:15 文件\\\\10.32.0.133\\dd\\hfxn\\xyfile\\qtsl.a27正在被其他程序占用，无法复制到清算机\r\n18:23:11 文件\\\\" +
    "10.32.0.133\\dd\\dcom_files\\sjsdz1027.dbf无法访问";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 346);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "异常信息：";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(754, 450);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(75, 27);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "执行";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "文件列表：";
            // 
            // lvFile
            // 
            this.lvFile.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHead0,
            this.clmHead3,
            this.clmHead4});
            this.lvFile.FullRowSelect = true;
            this.lvFile.GridLines = true;
            this.lvFile.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1,
            listViewItem2,
            listViewItem3});
            this.lvFile.Location = new System.Drawing.Point(169, 24);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(372, 304);
            this.lvFile.TabIndex = 7;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            this.lvFile.View = System.Windows.Forms.View.Details;
            // 
            // clmHead0
            // 
            this.clmHead0.Text = "文件名";
            this.clmHead0.Width = 120;
            // 
            // clmHead3
            // 
            this.clmHead3.Text = "已复制到清算机";
            this.clmHead3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHead3.Width = 116;
            // 
            // clmHead4
            // 
            this.clmHead4.Text = "两边文件是否一致";
            this.clmHead4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.clmHead4.Width = 120;
            // 
            // tvFolder
            // 
            this.tvFolder.Location = new System.Drawing.Point(12, 24);
            this.tvFolder.Name = "tvFolder";
            treeNode1.Name = "Node1";
            treeNode1.Text = "上交所过户文件";
            treeNode2.Name = "Node3";
            treeNode2.Text = "中登上海";
            treeNode3.Name = "Node5";
            treeNode3.Text = "中登深圳";
            treeNode4.Name = "Node0";
            treeNode4.Text = "股转";
            treeNode5.Name = "Node2";
            treeNode5.Text = "北交所";
            treeNode6.Name = "Node1";
            treeNode6.Text = "中登账户";
            treeNode7.Name = "Node3";
            treeNode7.Text = "TA&多金";
            treeNode8.Name = "Node0";
            treeNode8.Text = "所有文件";
            this.tvFolder.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode8});
            this.tvFolder.Size = new System.Drawing.Size(150, 304);
            this.tvFolder.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(653, 457);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 8;
            this.label4.Text = "状态：检查中...";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(361, 441);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(37, 21);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "检查间隔：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 443);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 12);
            this.label9.TabIndex = 16;
            this.label9.Text = "分钟";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(29, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(125, 12);
            this.label10.TabIndex = 17;
            this.label10.Text = "上一次检查完成时间：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(149, 450);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 12);
            this.label11.TabIndex = 18;
            this.label11.Text = "18:00:00";
            // 
            // lvStatus
            // 
            this.lvStatus.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.文件源,
            this.进度,
            this.是否收齐});
            this.lvStatus.FullRowSelect = true;
            this.lvStatus.GridLines = true;
            this.lvStatus.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6,
            listViewItem7,
            listViewItem8,
            listViewItem9,
            listViewItem10});
            this.lvStatus.Location = new System.Drawing.Point(574, 24);
            this.lvStatus.Name = "lvStatus";
            this.lvStatus.Size = new System.Drawing.Size(237, 304);
            this.lvStatus.TabIndex = 19;
            this.lvStatus.UseCompatibleStateImageBehavior = false;
            this.lvStatus.View = System.Windows.Forms.View.Details;
            // 
            // 文件源
            // 
            this.文件源.Text = "文件源";
            this.文件源.Width = 80;
            // 
            // 进度
            // 
            this.进度.Text = "进度";
            // 
            // 是否收齐
            // 
            this.是否收齐.Text = "是否收齐";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(572, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "文件拷贝状态：";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(292, 468);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(144, 16);
            this.checkBox1.TabIndex = 21;
            this.checkBox1.Text = "文件拷贝完成停止程序";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 503);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lvStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tvFolder);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "FrmMain";
            this.Text = "清算文件拷贝";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ColumnHeader clmHead0;
        private System.Windows.Forms.ColumnHeader clmHead3;
        private System.Windows.Forms.ColumnHeader clmHead4;
        private System.Windows.Forms.TreeView tvFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ListView lvStatus;
        private System.Windows.Forms.ColumnHeader 文件源;
        private System.Windows.Forms.ColumnHeader 进度;
        private System.Windows.Forms.ColumnHeader 是否收齐;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}
