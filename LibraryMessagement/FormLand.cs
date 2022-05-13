using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace LibraryMessagement
{
    public partial class FormLand : Form
    {
        User user = new User();
        Path p = new Path();

        public FormLand()
        {
            InitializeComponent();

            using (StreamReader sr = new StreamReader(p.APpath))
            {
                AccountText.Text = sr.ReadLine();
                PasswordText.Text = sr.ReadLine();
            }

            if (AccountText.Text != "" && PasswordText.Text != "")
                remmberButton.Checked = true;
        }

       
        private void LandButton_Click(object sender, EventArgs e)
        {
            if(AccountText.Text!=""&&PasswordText.Text!="")
            {
                if (user.Land(AccountText.Text, PasswordText.Text))
                {
                    using (StreamWriter sw = new StreamWriter(p.APpath))
                    {
                        if (remmberButton.Checked == true)
                        {
                            sw.WriteLine(AccountText.Text);
                            sw.WriteLine(PasswordText.Text);
                        }
                    }

                    FormStart f=new FormStart
                        (user.Account, user.Password, user.Sex, 
                        user.Telephone, user.Address, user.RegisterTime, 
                        user.Name, user.ID, user.Question, user.Answer);
                    f.Show();
                    this.Hide();                    
                }
                else
                    MessageBox.Show("账号或密码输入错误", "登录失败");
            }
            else
                MessageBox.Show("账号或密码不能为空", "登录失败");
        }

        private void Register_Click(object sender, EventArgs e)
        {      
            FormRegister form2 = new FormRegister();
            form2.Show();
            this.Hide();
        }

        private void forgetButton_Click(object sender, EventArgs e)
        {
            FormFindPassword form4 = new FormFindPassword();
            form4.Show();
            this.Hide();
        }
       
    }
}
