
namespace ShifrLab1
{
    partial class MainWindow
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
            this.ChangePassword = new System.Windows.Forms.Button();
            this.AboutProgramm = new System.Windows.Forms.Button();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.Login = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Block = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Limited = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Exit = new System.Windows.Forms.Button();
            this.AddUser = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.TextBox();
            this.labelUser = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangePassword
            // 
            this.ChangePassword.Location = new System.Drawing.Point(910, 57);
            this.ChangePassword.Name = "ChangePassword";
            this.ChangePassword.Size = new System.Drawing.Size(139, 27);
            this.ChangePassword.TabIndex = 0;
            this.ChangePassword.Text = "Change Password";
            this.ChangePassword.UseVisualStyleBackColor = true;
            this.ChangePassword.Click += new System.EventHandler(this.ChangePassword_Click);
            // 
            // AboutProgramm
            // 
            this.AboutProgramm.Location = new System.Drawing.Point(910, 12);
            this.AboutProgramm.Name = "AboutProgramm";
            this.AboutProgramm.Size = new System.Drawing.Size(139, 27);
            this.AboutProgramm.TabIndex = 1;
            this.AboutProgramm.Text = "AboutProgramm";
            this.AboutProgramm.UseVisualStyleBackColor = true;
            this.AboutProgramm.Click += new System.EventHandler(this.AboutProgramm_Click);
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Login,
            this.Block,
            this.Limited});
            this.dataGrid.Location = new System.Drawing.Point(31, 12);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowTemplate.Height = 25;
            this.dataGrid.Size = new System.Drawing.Size(856, 382);
            this.dataGrid.TabIndex = 2;
            // 
            // Login
            // 
            this.Login.HeaderText = "Login";
            this.Login.Name = "Login";
            this.Login.ReadOnly = true;
            // 
            // Block
            // 
            this.Block.HeaderText = "Block";
            this.Block.Name = "Block";
            // 
            // Limited
            // 
            this.Limited.HeaderText = "Limited";
            this.Limited.Name = "Limited";
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(942, 587);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(107, 27);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // AddUser
            // 
            this.AddUser.Location = new System.Drawing.Point(506, 415);
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(113, 27);
            this.AddUser.TabIndex = 4;
            this.AddUser.Text = "Add User";
            this.AddUser.UseVisualStyleBackColor = true;
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(165, 416);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(296, 23);
            this.UserName.TabIndex = 5;
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(94, 419);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(65, 15);
            this.labelUser.TabIndex = 6;
            this.labelUser.Text = "User Name";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(669, 416);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(105, 26);
            this.SaveBtn.TabIndex = 7;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 626);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.labelUser);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.AddUser);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.AboutProgramm);
            this.Controls.Add(this.ChangePassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ChangePassword;
        private System.Windows.Forms.Button AboutProgramm;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button AddUser;
        private System.Windows.Forms.TextBox UserName;
        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Login;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Block;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Limited;
        private System.Windows.Forms.Button SaveBtn;
    }
}