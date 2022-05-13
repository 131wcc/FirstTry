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
    public partial class FormChangeInformation : Form
    {
        User user;
        public FormChangeInformation(string a, string b, int c, string d, string f, string g, string h, int i, string j, string k)
        {
            InitializeComponent();

            user = new User(a, b, c, d, f, g, h, i, j, k);
        }

        private void 退出登陆ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void 借阅记录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormReturnBook form6 = new FormReturnBook
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form6.Show();
            this.Close();
        }

        private void 查找书籍ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBorrowBook form3 = new FormBorrowBook
                            (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            form3.Show();
            this.Close();
        }

        private void FormChangeInformation_Load(object sender, EventArgs e)
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
            PasswordBox.Text = user.Password;
            QuestionBox.Text = user.Question;
            AnswerBox.Text = user.Answer;

            if (user.ID == 0)
                menuStrip1.Visible = true;
            else if (user.ID == 1)
                menuStrip2.Visible = true;
            else if (user.ID == 2)
            {
                menuStrip2.Visible = true;
                AdminManageButton.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (PasswordBox.UseSystemPasswordChar == true)
                PasswordBox.UseSystemPasswordChar = false;
            else
                PasswordBox.UseSystemPasswordChar = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (AnswerBox.UseSystemPasswordChar == true)
                AnswerBox.UseSystemPasswordChar = false;
            else
                AnswerBox.UseSystemPasswordChar = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (OldPasswordBox.UseSystemPasswordChar == true)
                OldPasswordBox.UseSystemPasswordChar = false;
            else
                OldPasswordBox.UseSystemPasswordChar = true;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            NameBox.Text = user.Name;
            if (user.Sex == 0)
                BoyButton.Checked = true;
            else
                GirlButton.Checked = true;
            phoneBox.Text = user.Telephone;
            AddressBox.Text = user.Address;

            PasswordBox.Text = user.Password;
            QuestionBox.Text = user.Question;
            AnswerBox.Text = user.Answer;
        }

        private void SureButton_Click(object sender, EventArgs e)
        {
            user.Name = NameBox.Text;
            if (BoyButton.Checked == true)
                user.Sex = 0;
            else
                user.Sex = 1;
            user.Telephone = phoneBox.Text;
            user.Address = AddressBox.Text;
            user.Password = PasswordBox.Text;
            user.Question = QuestionBox.Text;
            user.Answer = AnswerBox.Text;   

            user.ChangeInformantion(user);
            MessageBox.Show("修改成功！", "信息修改成功");

            PasswordBox.Enabled = false;
            QuestionBox.Enabled = false;
            AnswerBox.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            sureBOX.Visible = true;
            OldPasswordBox.Enabled = true;
        }

        private void sureBOX_Click(object sender, EventArgs e)
        {
            if (OldPasswordBox.Text != "")
            {
                if (OldPasswordBox.Text == user.Password)
                {
                    sureBOX.Visible = false;
                    OldPasswordBox.Enabled = false;
                    PasswordBox.Enabled = true;
                    QuestionBox.Enabled = true;
                    AnswerBox.Enabled = true;

                    button1.Enabled = true;
                    button2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("原密码输入错误！", "信息修改错误");
                    return;
                }
            }
            else
                MessageBox.Show("请输入原密码后再进行修改！", "信息修改错误");
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            FormBookManage f = new FormBookManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            FormRecordManage f = new FormRecordManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void 退出登入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        private void 用户管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUserManage f = new FormUserManage
                (user.Account, user.Password, user.Sex, user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

        private void 管理员管理ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormAdminManage f = new FormAdminManage(user.Account, user.Password, user.Sex,
                user.Telephone, user.Address, user.RegisterTime, user.Name, user.ID, user.Question, user.Answer);
            f.Show();
            this.Close();
        }

       




    }
}
