namespace LibraryMessagement
{
    partial class FormFindPassword
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
            this.label4 = new System.Windows.Forms.Label();
            this.accountText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.questionText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answerText = new System.Windows.Forms.TextBox();
            this.sureButton = new System.Windows.Forms.Button();
            this.ReturnButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(86, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 21);
            this.label4.TabIndex = 9;
            this.label4.Text = "账号：";
            // 
            // accountText
            // 
            this.accountText.Location = new System.Drawing.Point(168, 62);
            this.accountText.Name = "accountText";
            this.accountText.Size = new System.Drawing.Size(260, 28);
            this.accountText.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(86, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "手机：";
            // 
            // phoneText
            // 
            this.phoneText.Location = new System.Drawing.Point(168, 117);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(260, 28);
            this.phoneText.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(86, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "密保：";
            this.label2.Visible = false;
            // 
            // questionText
            // 
            this.questionText.Location = new System.Drawing.Point(168, 176);
            this.questionText.Multiline = true;
            this.questionText.Name = "questionText";
            this.questionText.Size = new System.Drawing.Size(260, 28);
            this.questionText.TabIndex = 12;
            this.questionText.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(86, 234);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "答案：";
            this.label3.Visible = false;
            // 
            // answerText
            // 
            this.answerText.Location = new System.Drawing.Point(168, 234);
            this.answerText.Name = "answerText";
            this.answerText.Size = new System.Drawing.Size(260, 28);
            this.answerText.TabIndex = 14;
            this.answerText.Visible = false;
            // 
            // sureButton
            // 
            this.sureButton.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.sureButton.Location = new System.Drawing.Point(90, 321);
            this.sureButton.Name = "sureButton";
            this.sureButton.Size = new System.Drawing.Size(125, 66);
            this.sureButton.TabIndex = 16;
            this.sureButton.Text = "确认";
            this.sureButton.UseVisualStyleBackColor = true;
            this.sureButton.Click += new System.EventHandler(this.sureButton_Click);
            // 
            // ReturnButton
            // 
            this.ReturnButton.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ReturnButton.Location = new System.Drawing.Point(304, 321);
            this.ReturnButton.Name = "ReturnButton";
            this.ReturnButton.Size = new System.Drawing.Size(124, 66);
            this.ReturnButton.TabIndex = 17;
            this.ReturnButton.Text = "返回";
            this.ReturnButton.UseVisualStyleBackColor = true;
            this.ReturnButton.Click += new System.EventHandler(this.ReturnButton_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 421);
            this.Controls.Add(this.ReturnButton);
            this.Controls.Add(this.sureButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.questionText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.phoneText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.accountText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form4";
            this.Text = "找回密码";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox accountText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox questionText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox answerText;
        private System.Windows.Forms.Button sureButton;
        private System.Windows.Forms.Button ReturnButton;
    }
}