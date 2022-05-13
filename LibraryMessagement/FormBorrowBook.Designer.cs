namespace LibraryMessagement
{
    partial class FormBorrowBook
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.FindBookButton = new System.Windows.Forms.Button();
            this.BorrowBookButton = new System.Windows.Forms.Button();
            this.BookIDBox = new System.Windows.Forms.ComboBox();
            this.TimeLimitBox = new System.Windows.Forms.TextBox();
            this.NumNowBox = new System.Windows.Forms.TextBox();
            this.BookNameBox = new System.Windows.Forms.ComboBox();
            this.AuthorBox = new System.Windows.Forms.ComboBox();
            this.CancalButton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(485, 32);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 查找书籍ToolStripMenuItem
            // 
            this.查找书籍ToolStripMenuItem.Name = "查找书籍ToolStripMenuItem";
            this.查找书籍ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.查找书籍ToolStripMenuItem.Text = "借阅书籍";
            // 
            // 借阅记录ToolStripMenuItem
            // 
            this.借阅记录ToolStripMenuItem.Name = "借阅记录ToolStripMenuItem";
            this.借阅记录ToolStripMenuItem.Size = new System.Drawing.Size(94, 28);
            this.借阅记录ToolStripMenuItem.Text = "借阅记录";
            this.借阅记录ToolStripMenuItem.Click += new System.EventHandler(this.借阅记录ToolStripMenuItem_Click);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(111, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "书号：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(111, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "书名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(111, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "作者：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(86, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "现存量：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(61, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 24);
            this.label5.TabIndex = 9;
            this.label5.Text = "借阅期限：";
            // 
            // FindBookButton
            // 
            this.FindBookButton.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FindBookButton.Location = new System.Drawing.Point(50, 374);
            this.FindBookButton.Name = "FindBookButton";
            this.FindBookButton.Size = new System.Drawing.Size(106, 58);
            this.FindBookButton.TabIndex = 11;
            this.FindBookButton.Text = "查找";
            this.FindBookButton.UseVisualStyleBackColor = true;
            this.FindBookButton.Click += new System.EventHandler(this.FindBookButton_Click);
            // 
            // BorrowBookButton
            // 
            this.BorrowBookButton.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BorrowBookButton.Location = new System.Drawing.Point(188, 374);
            this.BorrowBookButton.Name = "BorrowBookButton";
            this.BorrowBookButton.Size = new System.Drawing.Size(105, 58);
            this.BorrowBookButton.TabIndex = 12;
            this.BorrowBookButton.Text = "借阅";
            this.BorrowBookButton.UseVisualStyleBackColor = true;
            this.BorrowBookButton.Click += new System.EventHandler(this.BorrowBookButton_Click);
            // 
            // BookIDBox
            // 
            this.BookIDBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookIDBox.FormattingEnabled = true;
            this.BookIDBox.Location = new System.Drawing.Point(203, 65);
            this.BookIDBox.Name = "BookIDBox";
            this.BookIDBox.Size = new System.Drawing.Size(197, 32);
            this.BookIDBox.TabIndex = 13;
            this.BookIDBox.SelectedIndexChanged += new System.EventHandler(this.BookIDBox_SelectedIndexChanged);
            // 
            // TimeLimitBox
            // 
            this.TimeLimitBox.Enabled = false;
            this.TimeLimitBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TimeLimitBox.Location = new System.Drawing.Point(203, 291);
            this.TimeLimitBox.Name = "TimeLimitBox";
            this.TimeLimitBox.Size = new System.Drawing.Size(197, 35);
            this.TimeLimitBox.TabIndex = 14;
            // 
            // NumNowBox
            // 
            this.NumNowBox.Enabled = false;
            this.NumNowBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NumNowBox.Location = new System.Drawing.Point(203, 230);
            this.NumNowBox.Name = "NumNowBox";
            this.NumNowBox.Size = new System.Drawing.Size(197, 35);
            this.NumNowBox.TabIndex = 15;
            // 
            // BookNameBox
            // 
            this.BookNameBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.BookNameBox.FormattingEnabled = true;
            this.BookNameBox.Location = new System.Drawing.Point(203, 122);
            this.BookNameBox.Name = "BookNameBox";
            this.BookNameBox.Size = new System.Drawing.Size(197, 32);
            this.BookNameBox.TabIndex = 16;
            this.BookNameBox.SelectedIndexChanged += new System.EventHandler(this.BookNameBox_SelectedIndexChanged);
            // 
            // AuthorBox
            // 
            this.AuthorBox.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.AuthorBox.FormattingEnabled = true;
            this.AuthorBox.Location = new System.Drawing.Point(202, 176);
            this.AuthorBox.Name = "AuthorBox";
            this.AuthorBox.Size = new System.Drawing.Size(197, 32);
            this.AuthorBox.TabIndex = 17;
            this.AuthorBox.SelectedIndexChanged += new System.EventHandler(this.AuthorBox_SelectedIndexChanged);
            // 
            // CancalButton
            // 
            this.CancalButton.Font = new System.Drawing.Font("SimSun", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.CancalButton.Location = new System.Drawing.Point(326, 374);
            this.CancalButton.Name = "CancalButton";
            this.CancalButton.Size = new System.Drawing.Size(105, 58);
            this.CancalButton.TabIndex = 18;
            this.CancalButton.Text = "取消";
            this.CancalButton.UseVisualStyleBackColor = true;
            this.CancalButton.Click += new System.EventHandler(this.CancalButton_Click);
            // 
            // FormBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 473);
            this.Controls.Add(this.CancalButton);
            this.Controls.Add(this.AuthorBox);
            this.Controls.Add(this.BookNameBox);
            this.Controls.Add(this.NumNowBox);
            this.Controls.Add(this.TimeLimitBox);
            this.Controls.Add(this.BookIDBox);
            this.Controls.Add(this.BorrowBookButton);
            this.Controls.Add(this.FindBookButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBorrowBook";
            this.Text = "书籍借阅";
            this.Load += new System.EventHandler(this.FormBorrowBook_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查找书籍ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 借阅记录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登陆ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button FindBookButton;
        private System.Windows.Forms.Button BorrowBookButton;
        private System.Windows.Forms.ComboBox BookIDBox;
        private System.Windows.Forms.TextBox TimeLimitBox;
        private System.Windows.Forms.TextBox NumNowBox;
        private System.Windows.Forms.ComboBox BookNameBox;
        private System.Windows.Forms.ComboBox AuthorBox;
        private System.Windows.Forms.Button CancalButton;

    }
}