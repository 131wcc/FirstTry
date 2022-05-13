namespace LibraryMessagement
{
    partial class FormLand
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.AccountText = new System.Windows.Forms.TextBox();
            this.PasswordText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LandButton = new System.Windows.Forms.Button();
            this.Register = new System.Windows.Forms.Label();
            this.remmberButton = new System.Windows.Forms.CheckBox();
            this.forgetButton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AccountText
            // 
            this.AccountText.Location = new System.Drawing.Point(182, 84);
            this.AccountText.Name = "AccountText";
            this.AccountText.Size = new System.Drawing.Size(240, 28);
            this.AccountText.TabIndex = 0;
            // 
            // PasswordText
            // 
            this.PasswordText.Location = new System.Drawing.Point(182, 176);
            this.PasswordText.Name = "PasswordText";
            this.PasswordText.Size = new System.Drawing.Size(240, 28);
            this.PasswordText.TabIndex = 1;
            this.PasswordText.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(82, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(82, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "密码：";
            // 
            // LandButton
            // 
            this.LandButton.Font = new System.Drawing.Font("SimSun", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LandButton.Location = new System.Drawing.Point(86, 284);
            this.LandButton.Name = "LandButton";
            this.LandButton.Size = new System.Drawing.Size(334, 63);
            this.LandButton.TabIndex = 4;
            this.LandButton.Text = "登录";
            this.LandButton.UseVisualStyleBackColor = true;
            this.LandButton.Click += new System.EventHandler(this.LandButton_Click);
            // 
            // Register
            // 
            this.Register.AutoSize = true;
            this.Register.Font = new System.Drawing.Font("SimSun", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Register.Location = new System.Drawing.Point(12, 382);
            this.Register.Name = "Register";
            this.Register.Size = new System.Drawing.Size(84, 18);
            this.Register.TabIndex = 5;
            this.Register.Text = "注册账号";
            this.Register.Click += new System.EventHandler(this.Register_Click);
            // 
            // remmberButton
            // 
            this.remmberButton.AutoSize = true;
            this.remmberButton.Location = new System.Drawing.Point(86, 230);
            this.remmberButton.Name = "remmberButton";
            this.remmberButton.Size = new System.Drawing.Size(106, 22);
            this.remmberButton.TabIndex = 6;
            this.remmberButton.Text = "记住密码";
            this.remmberButton.UseVisualStyleBackColor = true;
            // 
            // forgetButton
            // 
            this.forgetButton.AutoSize = true;
            this.forgetButton.Font = new System.Drawing.Font("SimSun", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.forgetButton.Location = new System.Drawing.Point(338, 230);
            this.forgetButton.Name = "forgetButton";
            this.forgetButton.Size = new System.Drawing.Size(84, 18);
            this.forgetButton.TabIndex = 7;
            this.forgetButton.Text = "忘记密码";
            this.forgetButton.Click += new System.EventHandler(this.forgetButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 422);
            this.Controls.Add(this.forgetButton);
            this.Controls.Add(this.remmberButton);
            this.Controls.Add(this.Register);
            this.Controls.Add(this.LandButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PasswordText);
            this.Controls.Add(this.AccountText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "图书管理系统";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AccountText;
        private System.Windows.Forms.TextBox PasswordText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LandButton;
        private System.Windows.Forms.Label Register;
        private System.Windows.Forms.CheckBox remmberButton;
        private System.Windows.Forms.Label forgetButton;

    }
}

