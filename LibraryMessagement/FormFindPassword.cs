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
    public partial class FormFindPassword : Form
    {
        public FormFindPassword()
        {
            InitializeComponent();
        }

        private void ReturnButton_Click(object sender, EventArgs e)
        {
            FormLand form1 = new FormLand();
            form1.Show();
            this.Close();
        }

        User user = new User();
        private void sureButton_Click(object sender, EventArgs e)
        {    
            if(accountText.Text!="" && phoneText.Text!="" && sureButton.Text=="确认")
            {
                user.Account = accountText.Text;
                user.Telephone = phoneText.Text;

                if(user.FindPassword())
                {
                    label2.Visible = true;
                    label3.Visible = true;
                    questionText.Visible = true;
                    answerText.Visible = true;
                    questionText.Text = user.Question;

                    sureButton.Text = "找回密码";
                }
                else
                    MessageBox.Show("无该信息匹配的账号", "找回密码失败");                
            }
            else if(sureButton.Text=="找回密码" && answerText.Text!="")
            {
                if(answerText.Text==user.Answer)
                    MessageBox.Show("您的密码为："+user.Password, "找回密码成功");
            }
            else
                MessageBox.Show("必要信息不能为空！", "找回密码失败");
        }


    }
}
