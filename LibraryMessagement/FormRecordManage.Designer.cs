namespace LibraryMessagement
{
    partial class FormRecordManage
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.Insex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookidHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BookNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAccountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BorrowLimitHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ReturnTimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IfLoseHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用户管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminManageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.UserAccountBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.UserNameBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.BookNameBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.BookIdBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.AllB = new System.Windows.Forms.Button();
            this.OverdueButton = new System.Windows.Forms.Button();
            this.NoLoseB = new System.Windows.Forms.Button();
            this.LoseB = new System.Windows.Forms.Button();
            this.NoReturnB = new System.Windows.Forms.Button();
            this.ReturnB = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Insex,
            this.BookidHeader,
            this.BookNameHeader,
            this.UserNameHeader,
            this.UserAccountHeader,
            this.BorrowTimeHeader,
            this.BorrowLimitHeader,
            this.ReturnTimeHeader,
            this.IfLoseHeader});
            this.listView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 45);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(726, 282);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // UserNameHeader
            // 
            this.UserNameHeader.Text = "借阅者";
            this.UserNameHeader.Width = 130;
            // 
            // UserAccountHeader
            // 
            this.UserAccountHeader.Text = "借阅账号";
            this.UserAccountHeader.Width = 130;
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
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4,
            this.退出登入ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(754, 32);
            this.menuStrip2.TabIndex = 10;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用户管理ToolStripMenuItem,
            this.AdminManageButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem1.Text = "用户管理";
            // 
            // 用户管理ToolStripMenuItem
            // 
            this.用户管理ToolStripMenuItem.Name = "用户管理ToolStripMenuItem";
            this.用户管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.用户管理ToolStripMenuItem.Text = "用户管理";
            this.用户管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // AdminManageButton
            // 
            this.AdminManageButton.Name = "AdminManageButton";
            this.AdminManageButton.Size = new System.Drawing.Size(182, 30);
            this.AdminManageButton.Text = "管理员管理";
            this.AdminManageButton.Visible = false;
            this.AdminManageButton.Click += new System.EventHandler(this.管理员管理ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem2.Text = "书籍管理";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem3.Text = "记录管理";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem4.Text = "修改信息";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click);
            // 
            // 退出登入ToolStripMenuItem
            // 
            this.退出登入ToolStripMenuItem.Name = "退出登入ToolStripMenuItem";
            this.退出登入ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.退出登入ToolStripMenuItem.Text = "退出登入";
            this.退出登入ToolStripMenuItem.Click += new System.EventHandler(this.退出登入ToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.UserAccountBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.UserNameBox);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.BookNameBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.BookIdBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 343);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 253);
            this.panel1.TabIndex = 11;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(302, 133);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(87, 47);
            this.ClearButton.TabIndex = 25;
            this.ClearButton.Text = "清空";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(302, 66);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(87, 47);
            this.FindButton.TabIndex = 24;
            this.FindButton.Text = "筛选";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // UserAccountBox
            // 
            this.UserAccountBox.Location = new System.Drawing.Point(128, 185);
            this.UserAccountBox.Name = "UserAccountBox";
            this.UserAccountBox.Size = new System.Drawing.Size(149, 35);
            this.UserAccountBox.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 24);
            this.label1.TabIndex = 22;
            this.label1.Text = "借阅账号：";
            // 
            // UserNameBox
            // 
            this.UserNameBox.Location = new System.Drawing.Point(128, 133);
            this.UserNameBox.Name = "UserNameBox";
            this.UserNameBox.Size = new System.Drawing.Size(149, 35);
            this.UserNameBox.TabIndex = 21;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 24);
            this.label12.TabIndex = 20;
            this.label12.Text = "借阅者：";
            // 
            // BookNameBox
            // 
            this.BookNameBox.Location = new System.Drawing.Point(128, 78);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(149, 35);
            this.BookNameBox.TabIndex = 19;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 81);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 24);
            this.label11.TabIndex = 18;
            this.label11.Text = "书名：";
            // 
            // BookIdBox
            // 
            this.BookIdBox.Location = new System.Drawing.Point(128, 25);
            this.BookIdBox.Name = "BookIdBox";
            this.BookIdBox.Size = new System.Drawing.Size(149, 35);
            this.BookIdBox.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 24);
            this.label10.TabIndex = 14;
            this.label10.Text = "书号：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.AllB);
            this.panel2.Controls.Add(this.OverdueButton);
            this.panel2.Controls.Add(this.NoLoseB);
            this.panel2.Controls.Add(this.LoseB);
            this.panel2.Controls.Add(this.NoReturnB);
            this.panel2.Controls.Add(this.ReturnB);
            this.panel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(457, 343);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(281, 253);
            this.panel2.TabIndex = 12;
            // 
            // AllB
            // 
            this.AllB.Location = new System.Drawing.Point(149, 171);
            this.AllB.Name = "AllB";
            this.AllB.Size = new System.Drawing.Size(113, 54);
            this.AllB.TabIndex = 5;
            this.AllB.Text = "全部";
            this.AllB.UseVisualStyleBackColor = true;
            this.AllB.Click += new System.EventHandler(this.AllB_Click);
            // 
            // OverdueButton
            // 
            this.OverdueButton.Location = new System.Drawing.Point(19, 171);
            this.OverdueButton.Name = "OverdueButton";
            this.OverdueButton.Size = new System.Drawing.Size(113, 54);
            this.OverdueButton.TabIndex = 4;
            this.OverdueButton.Text = "过期";
            this.OverdueButton.UseVisualStyleBackColor = true;
            this.OverdueButton.Click += new System.EventHandler(this.OverdueButton_Click);
            // 
            // NoLoseB
            // 
            this.NoLoseB.Location = new System.Drawing.Point(149, 94);
            this.NoLoseB.Name = "NoLoseB";
            this.NoLoseB.Size = new System.Drawing.Size(113, 54);
            this.NoLoseB.TabIndex = 3;
            this.NoLoseB.Text = "未挂失";
            this.NoLoseB.UseVisualStyleBackColor = true;
            this.NoLoseB.Click += new System.EventHandler(this.NoLoseB_Click);
            // 
            // LoseB
            // 
            this.LoseB.Location = new System.Drawing.Point(19, 94);
            this.LoseB.Name = "LoseB";
            this.LoseB.Size = new System.Drawing.Size(113, 54);
            this.LoseB.TabIndex = 2;
            this.LoseB.Text = "挂失";
            this.LoseB.UseVisualStyleBackColor = true;
            this.LoseB.Click += new System.EventHandler(this.LoseB_Click);
            // 
            // NoReturnB
            // 
            this.NoReturnB.Location = new System.Drawing.Point(149, 24);
            this.NoReturnB.Name = "NoReturnB";
            this.NoReturnB.Size = new System.Drawing.Size(113, 54);
            this.NoReturnB.TabIndex = 1;
            this.NoReturnB.Text = "未归还";
            this.NoReturnB.UseVisualStyleBackColor = true;
            this.NoReturnB.Click += new System.EventHandler(this.NoReturnB_Click);
            // 
            // ReturnB
            // 
            this.ReturnB.Location = new System.Drawing.Point(19, 24);
            this.ReturnB.Name = "ReturnB";
            this.ReturnB.Size = new System.Drawing.Size(113, 54);
            this.ReturnB.TabIndex = 0;
            this.ReturnB.Text = "归还";
            this.ReturnB.UseVisualStyleBackColor = true;
            this.ReturnB.Click += new System.EventHandler(this.ReturnB_Click);
            // 
            // FormRecordManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 610);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRecordManage";
            this.Text = "记录管理";
            this.Load += new System.EventHandler(this.FormRecordManage_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Insex;
        private System.Windows.Forms.ColumnHeader BookidHeader;
        private System.Windows.Forms.ColumnHeader BookNameHeader;
        private System.Windows.Forms.ColumnHeader BorrowTimeHeader;
        private System.Windows.Forms.ColumnHeader BorrowLimitHeader;
        private System.Windows.Forms.ColumnHeader ReturnTimeHeader;
        private System.Windows.Forms.ColumnHeader IfLoseHeader;
        private System.Windows.Forms.ColumnHeader UserNameHeader;
        private System.Windows.Forms.ColumnHeader UserAccountHeader;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 退出登入ToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox UserAccountBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox UserNameBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox BookNameBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox BookIdBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button AllB;
        private System.Windows.Forms.Button OverdueButton;
        private System.Windows.Forms.Button NoLoseB;
        private System.Windows.Forms.Button LoseB;
        private System.Windows.Forms.Button NoReturnB;
        private System.Windows.Forms.Button ReturnB;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.ToolStripMenuItem 用户管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminManageButton;

    }
}