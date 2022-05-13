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
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();

            boy.Checked = true;
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(accountText.Text=="" ||passwordText.Text==""||nameText.Text==""||
                phoneText.Text==""||questionText.Text==""||answerText.Text=="")
            {
                MessageBox.Show("必填项不能为空！", "注册失败");
                return;
            }

            User user = new User(accountText.Text);
            if (user.Name == "")
            {
                MessageBox.Show("账号或手机号已被注册！", "注册失败");
                return;
            }
            else
            {
                user.Account = accountText.Text;
                user.Password = passwordText.Text;
                user.Name = nameText.Text;
                if (girl.Checked == true)
                    user.Sex = 1;
                else
                    user.Sex = 0;
                user.Telephone = phoneText.Text;
                user.Address = addressText.Text;
                user.Question = questionText.Text;
                user.Answer = answerText.Text;

                user.RegisterUser();

                MessageBox.Show("注册成功！", "注册成功");

                FormLand form1 = new FormLand();
                form1.Show();
                this.Close();
            }
        }

        private void RetuenButton_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }
    }
}
