
namespace ShifrLab1
{
    partial class EnterWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EnterBtn = new System.Windows.Forms.Button();
            this.Login = new System.Windows.Forms.TextBox();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.repeatPassword = new System.Windows.Forms.Label();
            this.NewPasswordCheck = new System.Windows.Forms.TextBox();
            this.Exit = new System.Windows.Forms.Button();
            this.Oldpasswordtext = new System.Windows.Forms.Label();
            this.OldPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EnterBtn
            // 
            this.EnterBtn.Location = new System.Drawing.Point(194, 441);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(130, 28);
            this.EnterBtn.TabIndex = 0;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.UseVisualStyleBackColor = true;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(162, 184);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(202, 23);
            this.Login.TabIndex = 1;
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(162, 299);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(202, 23);
            this.Password.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(166, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // repeatPassword
            // 
            this.repeatPassword.AutoSize = true;
            this.repeatPassword.Location = new System.Drawing.Point(166, 345);
            this.repeatPassword.Name = "repeatPassword";
            this.repeatPassword.Size = new System.Drawing.Size(96, 15);
            this.repeatPassword.TabIndex = 13;
            this.repeatPassword.Text = "Repeat password";
            this.repeatPassword.Visible = false;
            // 
            // NewPasswordCheck
            // 
            this.NewPasswordCheck.Location = new System.Drawing.Point(162, 370);
            this.NewPasswordCheck.Name = "NewPasswordCheck";
            this.NewPasswordCheck.Size = new System.Drawing.Size(202, 23);
            this.NewPasswordCheck.TabIndex = 12;
            this.NewPasswordCheck.Visible = false;
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(194, 484);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(130, 28);
            this.Exit.TabIndex = 14;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Oldpasswordtext
            // 
            this.Oldpasswordtext.AutoSize = true;
            this.Oldpasswordtext.Location = new System.Drawing.Point(166, 218);
            this.Oldpasswordtext.Name = "Oldpasswordtext";
            this.Oldpasswordtext.Size = new System.Drawing.Size(79, 15);
            this.Oldpasswordtext.TabIndex = 16;
            this.Oldpasswordtext.Text = "Old password";
            this.Oldpasswordtext.Visible = false;
            // 
            // OldPassword
            // 
            this.OldPassword.Location = new System.Drawing.Point(162, 244);
            this.OldPassword.Name = "OldPassword";
            this.OldPassword.Size = new System.Drawing.Size(202, 23);
            this.OldPassword.TabIndex = 15;
            this.OldPassword.Visible = false;
            // 
            // EnterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 663);
            this.Controls.Add(this.Oldpasswordtext);
            this.Controls.Add(this.OldPassword);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.repeatPassword);
            this.Controls.Add(this.NewPasswordCheck);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.EnterBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EnterBtn;
        private System.Windows.Forms.TextBox Login;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label repeatPassword;
        private System.Windows.Forms.TextBox NewPasswordCheck;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Oldpasswordtext;
        private System.Windows.Forms.TextBox OldPassword;
    }
}

