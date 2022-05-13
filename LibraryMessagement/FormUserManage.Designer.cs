namespace LibraryMessagement
{
    partial class FormUserManage
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.管理员管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AdminManageButton = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listView1 = new System.Windows.Forms.ListView();
            this.InsexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAccountHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserSexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserphoneHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.UserAddressHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TimeHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1 = new System.Windows.Forms.Panel();
            this.CanButton = new System.Windows.Forms.Button();
            this.FindButton = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.Changebutton = new System.Windows.Forms.Button();
            this.GirlButton = new System.Windows.Forms.RadioButton();
            this.BoyButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip2.Size = new System.Drawing.Size(658, 32);
            this.menuStrip2.TabIndex = 8;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.AdminManageButton});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem1.Text = "用户管理";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.管理员管理ToolStripMenuItem.Text = "用户管理";
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
            this.toolStripMenuItem3.Click += new System.EventHandler(this.toolStripMenuItem3_Click);
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
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.InsexHeader,
            this.UserNameHeader,
            this.UserAccountHeader,
            this.UserSexHeader,
            this.UserphoneHeader,
            this.UserAddressHeader,
            this.TimeHeader});
            this.listView1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(12, 46);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(625, 277);
            this.listView1.TabIndex = 9;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.Click += new System.EventHandler(this.listView1_Click);
            // 
            // InsexHeader
            // 
            this.InsexHeader.Text = "序号";
            this.InsexHeader.Width = 120;
            // 
            // UserNameHeader
            // 
            this.UserNameHeader.Text = "姓名";
            this.UserNameHeader.Width = 120;
            // 
            // UserAccountHeader
            // 
            this.UserAccountHeader.Text = "账号";
            this.UserAccountHeader.Width = 130;
            // 
            // UserSexHeader
            // 
            this.UserSexHeader.Text = "性别";
            this.UserSexHeader.Width = 120;
            // 
            // UserphoneHeader
            // 
            this.UserphoneHeader.Text = "手机";
            this.UserphoneHeader.Width = 130;
            // 
            // UserAddressHeader
            // 
            this.UserAddressHeader.Text = "地址";
            this.UserAddressHeader.Width = 130;
            // 
            // TimeHeader
            // 
            this.TimeHeader.Text = "注册时间";
            this.TimeHeader.Width = 130;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.CanButton);
            this.panel1.Controls.Add(this.FindButton);
            this.panel1.Controls.Add(this.NBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.AccountBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(12, 329);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 121);
            this.panel1.TabIndex = 10;
            // 
            // CanButton
            // 
            this.CanButton.Location = new System.Drawing.Point(504, 38);
            this.CanButton.Name = "CanButton";
            this.CanButton.Size = new System.Drawing.Size(94, 47);
            this.CanButton.TabIndex = 39;
            this.CanButton.Text = "取消";
            this.CanButton.UseVisualStyleBackColor = true;
            this.CanButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // FindButton
            // 
            this.FindButton.Location = new System.Drawing.Point(373, 38);
            this.FindButton.Name = "FindButton";
            this.FindButton.Size = new System.Drawing.Size(94, 47);
            this.FindButton.TabIndex = 38;
            this.FindButton.Text = "查询";
            this.FindButton.UseVisualStyleBackColor = true;
            this.FindButton.Click += new System.EventHandler(this.FindButton_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(148, 69);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(194, 35);
            this.NBox.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 24);
            this.label6.TabIndex = 36;
            this.label6.Text = "姓名：";
            // 
            // AccountBox
            // 
            this.AccountBox.Location = new System.Drawing.Point(148, 20);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(194, 35);
            this.AccountBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(80, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 34;
            this.label5.Text = "账号：";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Deletebutton);
            this.panel2.Controls.Add(this.Changebutton);
            this.panel2.Controls.Add(this.GirlButton);
            this.panel2.Controls.Add(this.BoyButton);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.phoneBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.AddressBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.NameBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(12, 466);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(624, 230);
            this.panel2.TabIndex = 11;
            // 
            // Deletebutton
            // 
            this.Deletebutton.Location = new System.Drawing.Point(437, 120);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(145, 54);
            this.Deletebutton.TabIndex = 42;
            this.Deletebutton.Text = "注销";
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // Changebutton
            // 
            this.Changebutton.Location = new System.Drawing.Point(437, 45);
            this.Changebutton.Name = "Changebutton";
            this.Changebutton.Size = new System.Drawing.Size(145, 54);
            this.Changebutton.TabIndex = 41;
            this.Changebutton.Text = "修改";
            this.Changebutton.UseVisualStyleBackColor = true;
            this.Changebutton.Click += new System.EventHandler(this.Changebutton_Click);
            // 
            // GirlButton
            // 
            this.GirlButton.AutoSize = true;
            this.GirlButton.Location = new System.Drawing.Point(243, 75);
            this.GirlButton.Name = "GirlButton";
            this.GirlButton.Size = new System.Drawing.Size(60, 28);
            this.GirlButton.TabIndex = 40;
            this.GirlButton.TabStop = true;
            this.GirlButton.Text = "女";
            this.GirlButton.UseVisualStyleBackColor = true;
            // 
            // BoyButton
            // 
            this.BoyButton.AutoSize = true;
            this.BoyButton.Location = new System.Drawing.Point(142, 75);
            this.BoyButton.Name = "BoyButton";
            this.BoyButton.Size = new System.Drawing.Size(60, 28);
            this.BoyButton.TabIndex = 39;
            this.BoyButton.TabStop = true;
            this.BoyButton.Text = "男";
            this.BoyButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 38;
            this.label4.Text = "性别：";
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(142, 117);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(254, 35);
            this.phoneBox.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 36;
            this.label3.Text = "手机：";
            // 
            // AddressBox
            // 
            this.AddressBox.Location = new System.Drawing.Point(142, 163);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(254, 35);
            this.AddressBox.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 34;
            this.label2.Text = "地址：";
            // 
            // NameBox
            // 
            this.NameBox.Location = new System.Drawing.Point(142, 22);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(254, 35);
            this.NameBox.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "姓名：";
            // 
            // FormUserManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 711);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUserManage";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.FormUserManage_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 退出登入ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader UserNameHeader;
        private System.Windows.Forms.ColumnHeader UserAccountHeader;
        private System.Windows.Forms.ColumnHeader UserphoneHeader;
        private System.Windows.Forms.ColumnHeader UserAddressHeader;
        private System.Windows.Forms.ColumnHeader TimeHeader;
        private System.Windows.Forms.ColumnHeader UserSexHeader;
        private System.Windows.Forms.ColumnHeader InsexHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton GirlButton;
        private System.Windows.Forms.RadioButton BoyButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddressBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button Changebutton;
        private System.Windows.Forms.Button FindButton;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox AccountBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button CanButton;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AdminManageButton;
    }
}