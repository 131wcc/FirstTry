using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryMessagement
{
    public partial class FormStart : Form
    {
        User user;
        public FormStart(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);
            if (user.ID == 0)
                this.Text = "用户" + user.Name + "，欢迎回来！";
            else
                this.Text = "管理员" + user.Name + "，欢迎回来！";
        }

        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelAdmin = new System.Windows.Forms.Panel();
            this.ManageAdminButton = new System.Windows.Forms.Button();
            this.LeftButton2 = new System.Windows.Forms.Button();
            this.ManageUserButton = new System.Windows.Forms.Button();
            this.ManageBookButton = new System.Windows.Forms.Button();
            this.ChangeButton2 = new System.Windows.Forms.Button();
            this.ManageRecordButton = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.TimeBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.GirlButton = new System.Windows.Forms.RadioButton();
            this.BoyButton = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AddressBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AccountBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panelUser = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelAdmin.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panelAdmin);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panelUser);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(743, 590);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryMessagement.Properties.Resources._1634782096_1_;
            this.pictureBox1.Location = new System.Drawing.Point(55, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(166, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panelAdmin
            // 
            this.panelAdmin.Controls.Add(this.ManageAdminButton);
            this.panelAdmin.Controls.Add(this.LeftButton2);
            this.panelAdmin.Controls.Add(this.ManageUserButton);
            this.panelAdmin.Controls.Add(this.ManageBookButton);
            this.panelAdmin.Controls.Add(this.ChangeButton2);
            this.panelAdmin.Controls.Add(this.ManageRecordButton);
            this.panelAdmin.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelAdmin.Location = new System.Drawing.Point(46, 240);
            this.panelAdmin.Name = "panelAdmin";
            this.panelAdmin.Size = new System.Drawing.Size(186, 331);
            this.panelAdmin.TabIndex = 4;
            this.panelAdmin.Visible = false;
            // 
            // ManageAdminButton
            // 
            this.ManageAdminButton.Location = new System.Drawing.Point(14, 35);
            this.ManageAdminButton.Name = "ManageAdminButton";
            this.ManageAdminButton.Size = new System.Drawing.Size(163, 42);
            this.ManageAdminButton.TabIndex = 8;
            this.ManageAdminButton.Text = "管理员管理管理";
            this.ManageAdminButton.UseVisualStyleBackColor = true;
            this.ManageAdminButton.Visible = false;
            this.ManageAdminButton.Click += new System.EventHandler(this.ManageAdminButton_Click);
            // 
            // LeftButton2
            // 
            this.LeftButton2.Location = new System.Drawing.Point(29, 275);
            this.LeftButton2.Name = "LeftButton2";
            this.LeftButton2.Size = new System.Drawing.Size(128, 42);
            this.LeftButton2.TabIndex = 7;
            this.LeftButton2.Text = "退出登入";
            this.LeftButton2.UseVisualStyleBackColor = true;
            this.LeftButton2.Click += new System.EventHandler(this.LeftButton2_Click);
            // 
            // ManageUserButton
            // 
            this.ManageUserButton.Location = new System.Drawing.Point(29, 83);
            this.ManageUserButton.Name = "ManageUserButton";
            this.ManageUserButton.Size = new System.Drawing.Size(128, 42);
            this.ManageUserButton.TabIndex = 6;
            this.ManageUserButton.Text = "用户管理";
            this.ManageUserButton.UseVisualStyleBackColor = true;
            this.ManageUserButton.Click += new System.EventHandler(this.ManageUserButton_Click);
            // 
            // ManageBookButton
            // 
            this.ManageBookButton.Location = new System.Drawing.Point(29, 131);
            this.ManageBookButton.Name = "ManageBookButton";
            this.ManageBookButton.Size = new System.Drawing.Size(128, 42);
            this.ManageBookButton.TabIndex = 5;
            this.ManageBookButton.Text = "书籍管理";
            this.ManageBookButton.UseVisualStyleBackColor = true;
            this.ManageBookButton.Click += new System.EventHandler(this.ManageBookButton_Click);
            // 
            // ChangeButton2
            // 
            this.ChangeButton2.Location = new System.Drawing.Point(29, 227);
            this.ChangeButton2.Name = "ChangeButton2";
            this.ChangeButton2.Size = new System.Drawing.Size(128, 42);
            this.ChangeButton2.TabIndex = 3;
            this.ChangeButton2.Text = "修改信息";
            this.ChangeButton2.UseVisualStyleBackColor = true;
            this.ChangeButton2.Click += new System.EventHandler(this.ChangeButton2_Click);
            // 
            // ManageRecordButton
            // 
            this.ManageRecordButton.Location = new System.Drawing.Point(29, 179);
            this.ManageRecordButton.Name = "ManageRecordButton";
            this.ManageRecordButton.Size = new System.Drawing.Size(128, 42);
            this.ManageRecordButton.TabIndex = 4;
            this.ManageRecordButton.Text = "记录管理";
            this.ManageRecordButton.UseVisualStyleBackColor = true;
            this.ManageRecordButton.Click += new System.EventHandler(this.ManageRecordButton_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.textBox1);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.TimeBox);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.GirlButton);
            this.panel4.Controls.Add(this.BoyButton);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.phoneBox);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.AddressBox);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.NameBox);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.AccountBox);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel4.Location = new System.Drawing.Point(276, 39);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(423, 505);
            this.panel4.TabIndex = 2;
            // 
            // TimeBox
            // 
            this.TimeBox.Enabled = false;
            this.TimeBox.Location = new System.Drawing.Point(170, 384);
            this.TimeBox.Name = "TimeBox";
            this.TimeBox.Size = new System.Drawing.Size(207, 35);
            this.TimeBox.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(20, 387);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(135, 24);
            this.label9.TabIndex = 23;
            this.label9.Text = "注册时间：";
            // 
            // GirlButton
            // 
            this.GirlButton.AutoSize = true;
            this.GirlButton.Enabled = false;
            this.GirlButton.Location = new System.Drawing.Point(271, 200);
            this.GirlButton.Name = "GirlButton";
            this.GirlButton.Size = new System.Drawing.Size(60, 28);
            this.GirlButton.TabIndex = 22;
            this.GirlButton.TabStop = true;
            this.GirlButton.Text = "女";
            this.GirlButton.UseVisualStyleBackColor = true;
            // 
            // BoyButton
            // 
            this.BoyButton.AutoSize = true;
            this.BoyButton.Enabled = false;
            this.BoyButton.Location = new System.Drawing.Point(170, 200);
            this.BoyButton.Name = "BoyButton";
            this.BoyButton.Size = new System.Drawing.Size(60, 28);
            this.BoyButton.TabIndex = 21;
            this.BoyButton.TabStop = true;
            this.BoyButton.Text = "男";
            this.BoyButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(70, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "性别：";
            // 
            // phoneBox
            // 
            this.phoneBox.Enabled = false;
            this.phoneBox.Location = new System.Drawing.Point(170, 255);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(207, 35);
            this.phoneBox.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 24);
            this.label3.TabIndex = 18;
            this.label3.Text = "手机：";
            // 
            // AddressBox
            // 
            this.AddressBox.Enabled = false;
            this.AddressBox.Location = new System.Drawing.Point(170, 318);
            this.AddressBox.Name = "AddressBox";
            this.AddressBox.Size = new System.Drawing.Size(207, 35);
            this.AddressBox.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 321);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 24);
            this.label2.TabIndex = 16;
            this.label2.Text = "地址：";
            // 
            // NameBox
            // 
            this.NameBox.Enabled = false;
            this.NameBox.Location = new System.Drawing.Point(170, 74);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(207, 35);
            this.NameBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "姓名：";
            // 
            // AccountBox
            // 
            this.AccountBox.Enabled = false;
            this.AccountBox.Location = new System.Drawing.Point(170, 138);
            this.AccountBox.Name = "AccountBox";
            this.AccountBox.Size = new System.Drawing.Size(207, 35);
            this.AccountBox.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 24);
            this.label8.TabIndex = 13;
            this.label8.Text = "账号：";
            // 
            // panelUser
            // 
            this.panelUser.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelUser.Controls.Add(this.button4);
            this.panelUser.Controls.Add(this.button3);
            this.panelUser.Controls.Add(this.button1);
            this.panelUser.Controls.Add(this.button2);
            this.panelUser.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panelUser.Location = new System.Drawing.Point(55, 295);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(166, 239);
            this.panelUser.TabIndex = 1;
            this.panelUser.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(18, 26);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 42);
            this.button4.TabIndex = 6;
            this.button4.Text = "借阅书籍";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.BorrowButton_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 42);
            this.button3.TabIndex = 5;
            this.button3.Text = "借阅记录";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 170);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 42);
            this.button1.TabIndex = 3;
            this.button1.Text = "退出登入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 122);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 42);
            this.button2.TabIndex = 4;
            this.button2.Text = "修改信息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(170, 449);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(207, 35);
            this.textBox1.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(70, 452);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "欠费：";
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 631);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormStart";
            this.Text = "Form7";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelAdmin.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            NameBox.Text = user.Name;
            if (user.Sex == 0)
                BoyButton.Checked = true;
            else
                GirlButton.Checked = true;
            phoneBox.Text = user.Telephone;
            AddressBox.Text = user.Address;
            TimeBox.Text = user.RegisterTime;
            AccountBox.Text = user.Account;


            if (user.ID == 0)
                panelUser.Visible = true;
            else if (user.ID == 1)
                panelAdmin.Visible = true;
            else if(user.ID==2)
            {
                panelAdmin.Visible = true;
                ManageAdminButton.Visible = true;
            }

        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void RecordButton_Click(object sender, EventArgs e)
        {
            FormReturnBook form6 = new FormReturnBook
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form6.Show();
            this.Close();
        }

        private void BorrowButton_Click(object sender, EventArgs e)
        {
            FormBorrowBook form3 = new FormBorrowBook
                            (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form3.Show();
            this.Close();
        }

        private void ChangeButton_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void LeftButton2_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void ChangeButton2_Click(object sender, EventArgs e)
        {
            FormChangeInformation form5 = new FormChangeInformation
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form5.Show();
            this.Close();
        }

        private void ManageRecordButton_Click(object sender, EventArgs e)
        {
            FormRecordManage f = new FormRecordManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void ManageBookButton_Click(object sender, EventArgs e)
        {
            FormBookManage f=new FormBookManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void ManageUserButton_Click(object sender, EventArgs e)
        {
            FormUserManage f = new FormUserManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void ManageAdminButton_Click(object sender, EventArgs e)
        {
            FormAdminManage f = new FormAdminManage(user.Account, user.Password, user.Sex,
                user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }
    }
}
