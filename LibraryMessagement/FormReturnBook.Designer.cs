namespace LibraryMessagement
{
    partial class FormReturnBook
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.查找书籍ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.借阅记录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登陆ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Insex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowLimitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IfLoseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllButton = new System.Windows.Forms.Button();
            this.LosedButton = new System.Windows.Forms.Button();
            this.NoReturnButton = new System.Windows.Forms.Button();
            this.ReturnedButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.LoseButton = new System.Windows.Forms.Button();
            this.DalayButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.DalayTimeBox = new System.Windows.Forms.DateTimePicker();
            this.MoneyBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ReturnTimeBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查找书籍ToolStripMenuItem,
            this.借阅记录ToolStripMenuItem,
            this.修改信息ToolStripMenuItem,
            this.退出登陆ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(913, 32);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查找书籍ToolStripMenuItem
            // 
            this.查找书籍ToolStripMenuItem.Name = "查找书籍ToolStripMenuItem";
            this.查找书籍ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.查找书籍ToolStripMenuItem.Text = "借阅书籍";
            this.查找书籍ToolStripMenuItem.Click += new System.EventHandler(this.查找书籍ToolStripMenuItem_Click);
            // 
            // 借阅记录ToolStripMenuItem
            // 
            this.借阅记录ToolStripMenuItem.Name = "借阅记录ToolStripMenuItem";
            this.借阅记录ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.借阅记录ToolStripMenuItem.Text = "借阅记录";
            // 
            // 修改信息ToolStripMenuItem
            // 
            this.修改信息ToolStripMenuItem.Name = "修改信息ToolStripMenuItem";
            this.修改信息ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.修改信息ToolStripMenuItem.Text = "修改信息";
            this.修改信息ToolStripMenuItem.Click += new System.EventHandler(this.修改信息ToolStripMenuItem_Click);
            // 
            // 退出登陆ToolStripMenuItem
            // 
            this.退出登陆ToolStripMenuItem.Name = "退出登陆ToolStripMenuItem";
            this.退出登陆ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.退出登陆ToolStripMenuItem.Text = "退出登陆";
            this.退出登陆ToolStripMenuItem.Click += new System.EventHandler(this.退出登陆ToolStripMenuItem_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Insex,
            this.BookidHeader,
            this.BookNameHeader,
            this.BorrowTimeHeader,
            this.BorrowLimitHeader,
            this.ReturnTimeHeader,
            this.IfLoseHeader});
            this.listView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 44);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(889, 334);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // Insex
            // 
            this.Insex.Text = "序号";
            this.Insex.Width = 89;
            // 
            // BookidHeader
            // 
            this.BookidHeader.Text = "书号";
            this.BookidHeader.Width = 120;
            // 
            // BookNameHeader
            // 
            this.BookNameHeader.Text = "书名";
            this.BookNameHeader.Width = 130;
            // 
            // BorrowTimeHeader
            // 
            this.BorrowTimeHeader.Text = "借书时间";
            this.BorrowTimeHeader.Width = 130;
            // 
            // BorrowLimitHeader
            // 
            this.BorrowLimitHeader.Text = "借阅期限";
            this.BorrowLimitHeader.Width = 130;
            // 
            // ReturnTimeHeader
            // 
            this.ReturnTimeHeader.Text = "归还时间";
            this.ReturnTimeHeader.Width = 130;
            // 
            // IfLoseHeader
            // 
            this.IfLoseHeader.Text = "是否丢失";
            this.IfLoseHeader.Width = 120;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.LoseButton);
            this.panel1.Controls.Add(this.DalayButton);
            this.panel1.Controls.Add(this.ReturnButton);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 402);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 266);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.AllButton);
            this.panel2.Controls.Add(this.LosedButton);
            this.panel2.Controls.Add(this.NoReturnButton);
            this.panel2.Controls.Add(this.ReturnedButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(689, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(174, 245);
            this.panel2.TabIndex = 4;
            // 
            // AllButton
            // 
            this.AllButton.Location = new System.Drawing.Point(19, 209);
            this.AllButton.Name = "AllButton";
            this.AllButton.Size = new System.Drawing.Size(137, 38);
            this.AllButton.TabIndex = 4;
            this.AllButton.Text = "全部";
            this.AllButton.UseVisualStyleBackColor = true;
            this.AllButton.Click += new System.EventHandler(this.AllButton_Click);
            // 
            // LosedButton
            // 
            this.LosedButton.Location = new System.Drawing.Point(19, 155);
            this.LosedButton.Name = "LosedButton";
            this.LosedButton.Size = new System.Drawing.Size(137, 38);
            this.LosedButton.TabIndex = 3;
            this.LosedButton.Text = "挂失";
            this.LosedButton.UseVisualStyleBackColor = true;
            this.LosedButton.Click += new System.EventHandler(this.LosedButton_Click);
            // 
            // NoReturnButton
            // 
            this.NoReturnButton.Location = new System.Drawing.Point(19, 98);
            this.NoReturnButton.Name = "NoReturnButton";
            this.NoReturnButton.Size = new System.Drawing.Size(137, 41);
            this.NoReturnButton.TabIndex = 2;
            this.NoReturnButton.Text = "未归还";
            this.NoReturnButton.UseVisualStyleBackColor = true;
            this.NoReturnButton.Click += new System.EventHandler(this.NoReturnButton_Click);
            // 
            // ReturnedButton
            // 
            this.ReturnedButton.Location = new System.Drawing.Point(19, 44);
            this.ReturnedButton.Name = "ReturnedButton";
            this.ReturnedButton.Size = new System.Drawing.Size(137, 38);
            this.ReturnedButton.TabIndex = 1;
            this.ReturnedButton.Text = "已归还";
            this.ReturnedButton.UseVisualStyleBackColor = true;
            this.ReturnedButton.Click += new System.EventHandler(this.ReturnedButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 24);
            this.label4.TabIndex = 0;
            this.label4.Text = "筛选";
            // 
            // LoseButton
            // 
            this.LoseButton.Enabled = false;
            this.LoseButton.Location = new System.Drawing.Point(527, 178);
            this.LoseButton.Name = "LoseButton";
            this.LoseButton.Size = new System.Drawing.Size(124, 48);
            this.LoseButton.TabIndex = 3;
            this.LoseButton.Text = "挂失";
            this.LoseButton.UseVisualStyleBackColor = true;
            this.LoseButton.Click += new System.EventHandler(this.LoseButton_Click);
            // 
            // DalayButton
            // 
            this.DalayButton.Enabled = false;
            this.DalayButton.Location = new System.Drawing.Point(527, 101);
            this.DalayButton.Name = "DalayButton";
            this.DalayButton.Size = new System.Drawing.Size(124, 48);
            this.DalayButton.TabIndex = 2;
            this.DalayButton.Text = "延迟";
            this.DalayButton.UseVisualStyleBackColor = true;
            this.DalayButton.Click += new System.EventHandler(this.DalayButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Enabled = false;
            this.ReturnButton.Location = new System.Drawing.Point(527, 25);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(124, 48);
            this.ReturnButton.TabIndex = 1;
            this.ReturnButton.Text = "归还";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.DalayTimeBox);
            this.panel3.Controls.Add(this.MoneyBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.ReturnTimeBox);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(25, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(473, 201);
            this.panel3.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(185, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "延迟归还日期：";
            // 
            // DalayTimeBox
            // 
            this.DalayTimeBox.CustomFormat = "";
            this.DalayTimeBox.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DalayTimeBox.Location = new System.Drawing.Point(194, 148);
            this.DalayTimeBox.Name = "DalayTimeBox";
            this.DalayTimeBox.Size = new System.Drawing.Size(221, 35);
            this.DalayTimeBox.TabIndex = 4;
            this.DalayTimeBox.Value = new System.DateTime(2021, 10, 20, 20, 29, 26, 0);
            // 
            // MoneyBox
            // 
            this.MoneyBox.Enabled = false;
            this.MoneyBox.Location = new System.Drawing.Point(194, 85);
            this.MoneyBox.Name = "MoneyBox";
            this.MoneyBox.Size = new System.Drawing.Size(222, 35);
            this.MoneyBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "挂失赔偿金额：";
            // 
            // ReturnTimeBox
            // 
            this.ReturnTimeBox.Enabled = false;
            this.ReturnTimeBox.Location = new System.Drawing.Point(194, 21);
            this.ReturnTimeBox.Name = "ReturnTimeBox";
            this.ReturnTimeBox.Size = new System.Drawing.Size(222, 35);
            this.ReturnTimeBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "预计归还时间：";
            // 
            // FormReturnBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 680);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormReturnBook";
            this.Text = "书籍归还窗口";
            this.Load += new System.EventHandler(this.FormReturnBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查找书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登陆ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader BookidHeader;
        private System.Windows.Forms.ColumnHeader BookNameHeader;
        private System.Windows.Forms.ColumnHeader BorrowTimeHeader;
        private System.Windows.Forms.ColumnHeader BorrowLimitHeader;
        private System.Windows.Forms.ColumnHeader ReturnTimeHeader;
        private System.Windows.Forms.ColumnHeader IfLoseHeader;
        private System.Windows.Forms.ColumnHeader Insex;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button LoseButton;
        private System.Windows.Forms.Button DalayButton;
        private System.Windows.Forms.Button ReturnButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker DalayTimeBox;
        private System.Windows.Forms.TextBox MoneyBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ReturnTimeBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button LosedButton;
        private System.Windows.Forms.Button NoReturnButton;
        private System.Windows.Forms.Button ReturnedButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AllButton;
    }
}