namespace StoreApp
{
    partial class RegisterForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.RegLoginField = new System.Windows.Forms.TextBox();
            this.RegPasswordField = new System.Windows.Forms.TextBox();
            this.RegRepeatPasswordField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegSignUp = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sign Up";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RegLoginField
            // 
            this.RegLoginField.Location = new System.Drawing.Point(130, 54);
            this.RegLoginField.Name = "RegLoginField";
            this.RegLoginField.Size = new System.Drawing.Size(193, 20);
            this.RegLoginField.TabIndex = 2;
            // 
            // RegPasswordField
            // 
            this.RegPasswordField.Location = new System.Drawing.Point(130, 105);
            this.RegPasswordField.Name = "RegPasswordField";
            this.RegPasswordField.Size = new System.Drawing.Size(193, 20);
            this.RegPasswordField.TabIndex = 3;
            this.RegPasswordField.UseSystemPasswordChar = true;
            // 
            // RegRepeatPasswordField
            // 
            this.RegRepeatPasswordField.Location = new System.Drawing.Point(130, 131);
            this.RegRepeatPasswordField.Name = "RegRepeatPasswordField";
            this.RegRepeatPasswordField.Size = new System.Drawing.Size(193, 20);
            this.RegRepeatPasswordField.TabIndex = 4;
            this.RegRepeatPasswordField.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Repeat Password:";
            // 
            // RegSignUp
            // 
            this.RegSignUp.Location = new System.Drawing.Point(171, 164);
            this.RegSignUp.Name = "RegSignUp";
            this.RegSignUp.Size = new System.Drawing.Size(110, 23);
            this.RegSignUp.TabIndex = 8;
            this.RegSignUp.Text = "Sign Up";
            this.RegSignUp.UseVisualStyleBackColor = true;
            this.RegSignUp.Click += new System.EventHandler(this.RegSignUp_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Location = new System.Drawing.Point(142, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Already have an accaunt? SIgn In";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(452, 227);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.RegSignUp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RegRepeatPasswordField);
            this.Controls.Add(this.RegPasswordField);
            this.Controls.Add(this.RegLoginField);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sign Up";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RegLoginField;
        private System.Windows.Forms.TextBox RegPasswordField;
        private System.Windows.Forms.TextBox RegRepeatPasswordField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button RegSignUp;
        private System.Windows.Forms.Label label5;
    }
}