namespace LibraryMessagement
{
    partial class FormAdminManage
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
            this.管理员管理ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.addressText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.boy = new System.Windows.Forms.RadioButton();
            this.answerText = new System.Windows.Forms.TextBox();
            this.questionText = new System.Windows.Forms.TextBox();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.passwordText = new System.Windows.Forms.TextBox();
            this.accountText = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.girl = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
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
            this.menuStrip2.Size = new System.Drawing.Size(744, 32);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.管理员管理ToolStripMenuItem,
            this.管理员管理ToolStripMenuItem1});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(94, 28);
            this.toolStripMenuItem1.Text = "用户管理";
            // 
            // 管理员管理ToolStripMenuItem
            // 
            this.管理员管理ToolStripMenuItem.Name = "管理员管理ToolStripMenuItem";
            this.管理员管理ToolStripMenuItem.Size = new System.Drawing.Size(182, 30);
            this.管理员管理ToolStripMenuItem.Text = "用户管理";
            this.管理员管理ToolStripMenuItem.Click += new System.EventHandler(this.用户管理ToolStripMenuItem_Click);
            // 
            // 管理员管理ToolStripMenuItem1
            // 
            this.管理员管理ToolStripMenuItem1.Name = "管理员管理ToolStripMenuItem1";
            this.管理员管理ToolStripMenuItem1.Size = new System.Drawing.Size(182, 30);
            this.管理员管理ToolStripMenuItem1.Text = "管理员管理";
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
            this.listView1.Location = new System.Drawing.Point(20, 49);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(703, 275);
            this.listView1.TabIndex = 10;
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
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addressText);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ClearButton);
            this.panel2.Controls.Add(this.boy);
            this.panel2.Controls.Add(this.answerText);
            this.panel2.Controls.Add(this.questionText);
            this.panel2.Controls.Add(this.phoneText);
            this.panel2.Controls.Add(this.nameText);
            this.panel2.Controls.Add(this.passwordText);
            this.panel2.Controls.Add(this.accountText);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.girl);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.DeleteButton);
            this.panel2.Controls.Add(this.ChangeButton);
            this.panel2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel2.Location = new System.Drawing.Point(20, 345);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(700, 318);
            this.panel2.TabIndex = 13;
            // 
            // addressText
            // 
            this.addressText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addressText.Location = new System.Drawing.Point(462, 171);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(203, 39);
            this.addressText.TabIndex = 39;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(360, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 28);
            this.label6.TabIndex = 40;
            this.label6.Text = "地址：";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(502, 238);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(104, 58);
            this.ClearButton.TabIndex = 38;
            this.ClearButton.Text = "取消";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // boy
            // 
            this.boy.AutoSize = true;
            this.boy.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.boy.Location = new System.Drawing.Point(126, 172);
            this.boy.Name = "boy";
            this.boy.Size = new System.Drawing.Size(66, 32);
            this.boy.TabIndex = 31;
            this.boy.TabStop = true;
            this.boy.Text = "男";
            this.boy.UseVisualStyleBackColor = true;
            // 
            // answerText
            // 
            this.answerText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.answerText.Location = new System.Drawing.Point(462, 117);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(203, 39);
            this.answerText.TabIndex = 36;
            // 
            // questionText
            // 
            this.questionText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.questionText.Location = new System.Drawing.Point(462, 71);
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(203, 39);
            this.questionText.TabIndex = 34;
            // 
            // phoneText
            // 
            this.phoneText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.phoneText.Location = new System.Drawing.Point(462, 17);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(203, 39);
            this.phoneText.TabIndex = 29;
            // 
            // nameText
            // 
            this.nameText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.nameText.Location = new System.Drawing.Point(126, 116);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(209, 39);
            this.nameText.TabIndex = 27;
            // 
            // passwordText
            // 
            this.passwordText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.passwordText.Location = new System.Drawing.Point(126, 65);
            this.passwordText.Name = "passwordText";
            this.passwordText.Size = new System.Drawing.Size(209, 39);
            this.passwordText.TabIndex = 25;
            // 
            // accountText
            // 
            this.accountText.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.accountText.Location = new System.Drawing.Point(126, 14);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(209, 39);
            this.accountText.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(360, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 28);
            this.label8.TabIndex = 37;
            this.label8.Text = "答案*：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(360, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 28);
            this.label7.TabIndex = 35;
            this.label7.Text = "密保*：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(23, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 28);
            this.label5.TabIndex = 33;
            this.label5.Text = "性别*：";
            // 
            // girl
            // 
            this.girl.AutoSize = true;
            this.girl.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.girl.Location = new System.Drawing.Point(250, 172);
            this.girl.Name = "girl";
            this.girl.Size = new System.Drawing.Size(66, 32);
            this.girl.TabIndex = 32;
            this.girl.TabStop = true;
            this.girl.Text = "女";
            this.girl.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(360, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 28);
            this.label4.TabIndex = 30;
            this.label4.Text = "手机*：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(23, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 28);
            this.label3.TabIndex = 28;
            this.label3.Text = "姓名*：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(23, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 28);
            this.label2.TabIndex = 26;
            this.label2.Text = "密码*：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 28);
            this.label1.TabIndex = 24;
            this.label1.Text = "账号*：";
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(365, 238);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(104, 58);
            this.AddButton.TabIndex = 22;
            this.AddButton.Text = "添加";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(231, 238);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(104, 58);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "注销";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Enabled = false;
            this.ChangeButton.Location = new System.Drawing.Point(97, 238);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(104, 58);
            this.ChangeButton.TabIndex = 20;
            this.ChangeButton.Text = "修改";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // FormAdminManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 689);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.menuStrip2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAdminManage";
            this.Text = "管理员管理";
            this.Load += new System.EventHandler(this.FormAdminManage_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 管理员管理ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem 退出登入ToolStripMenuItem;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader InsexHeader;
        private System.Windows.Forms.ColumnHeader UserNameHeader;
        private System.Windows.Forms.ColumnHeader UserAccountHeader;
        private System.Windows.Forms.ColumnHeader UserSexHeader;
        private System.Windows.Forms.ColumnHeader UserphoneHeader;
        private System.Windows.Forms.ColumnHeader UserAddressHeader;
        private System.Windows.Forms.ColumnHeader TimeHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.RadioButton boy;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox passwordText;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton girl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label label6;
    }
}