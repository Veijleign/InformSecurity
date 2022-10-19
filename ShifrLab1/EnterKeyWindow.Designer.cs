
namespace ShifrLab1
{
    partial class EnterKeyWindow
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
            this.Enter = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.KeyStr = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Enter
            // 
            this.Enter.Location = new System.Drawing.Point(329, 199);
            this.Enter.Name = "Enter";
            this.Enter.Size = new System.Drawing.Size(137, 53);
            this.Enter.TabIndex = 0;
            this.Enter.Text = "Enter";
            this.Enter.UseVisualStyleBackColor = true;
            this.Enter.Click += new System.EventHandler(this.Enter_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(65, 199);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(137, 53);
            this.Exit.TabIndex = 1;
            this.Exit.Text = "Выход";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // KeyStr
            // 
            this.KeyStr.Location = new System.Drawing.Point(65, 118);
            this.KeyStr.Name = "KeyStr";
            this.KeyStr.Size = new System.Drawing.Size(401, 23);
            this.KeyStr.TabIndex = 2;
            this.KeyStr.TextChanged += new System.EventHandler(this.KeyStr_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Enter database key decryption";
            // 
            // EnterKeyWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(553, 349);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.KeyStr);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Enter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EnterKeyWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnterKeyWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enter;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.TextBox KeyStr;
        private System.Windows.Forms.Label label2;
    }
}