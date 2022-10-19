
namespace ShifrLab1
{
    partial class PasswordChangeWindow
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NewPassword = new System.Windows.Forms.TextBox();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.ChangePasswordBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NewPasswordCheck = new System.Windows.Forms.TextBox();
            this.Back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Old Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "New Password";
            // 
            // NewPassword
            // 
            this.NewPassword.Location = new System.Drawing.Point(98, 276);
            this.NewPassword.Name = "NewPassword";
            this.NewPassword.Size = new System.Drawing.Size(202, 23);
            this.NewPassword.TabIndex = 7;
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(98, 199);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(202, 23);
            this.OldPassword.TabIndex = 6;
            // 
            // ChangePasswordBtn
            // 
            this.ChangePasswordBtn.Location = new System.Drawing.Point(131, 406);
            this.ChangePasswordBtn.Name = "ChangePasswordBtn";
            this.ChangePasswordBtn.Size = new System.Drawing.Size(130, 29);
            this.ChangePasswordBtn.TabIndex = 5;
            this.ChangePasswordBtn.Text = "Change Password";
            this.ChangePasswordBtn.UseVisualStyleBackColor = true;
            this.ChangePasswordBtn.Click += new System.EventHandler(this.ChangePasswordBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 314);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Enter new password";
            // 
            // NewPasswordCheck
            // 
            this.NewPasswordCheck.Location = new System.Drawing.Point(98, 339);
            this.NewPasswordCheck.Name = "NewPasswordCheck";
            this.NewPasswordCheck.Size = new System.Drawing.Size(202, 23);
            this.NewPasswordCheck.TabIndex = 10;
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(131, 441);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(130, 29);
            this.Back.TabIndex = 12;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // PasswordChangeWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 607);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NewPasswordCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NewPassword);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.ChangePasswordBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PasswordChangeWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PasswordChangeWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NewPassword;
        private System.Windows.Forms.TextBox OldPassword;
        private System.Windows.Forms.Button ChangePasswordBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NewPasswordCheck;
        private System.Windows.Forms.Button Back;
    }
}