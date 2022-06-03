namespace Clinic_Application
{
    partial class frmForgetPssword
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
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblVarificationCode = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.lblConfirmPassword = new System.Windows.Forms.Label();
            this.lblNewPassword = new System.Windows.Forms.Label();
            this.txtbxEmail = new System.Windows.Forms.TextBox();
            this.txtbxNewPassword = new System.Windows.Forms.TextBox();
            this.txtbxConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtbxUserName = new System.Windows.Forms.TextBox();
            this.txtbxVarificationCode = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(212, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(42, 17);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // lblVarificationCode
            // 
            this.lblVarificationCode.AutoSize = true;
            this.lblVarificationCode.Location = new System.Drawing.Point(212, 116);
            this.lblVarificationCode.Name = "lblVarificationCode";
            this.lblVarificationCode.Size = new System.Drawing.Size(115, 17);
            this.lblVarificationCode.TabIndex = 1;
            this.lblVarificationCode.Text = "Varification Code";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(212, 179);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(79, 17);
            this.lblUserName.TabIndex = 3;
            this.lblUserName.Text = "User Name";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Location = new System.Drawing.Point(212, 305);
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(121, 17);
            this.lblConfirmPassword.TabIndex = 5;
            this.lblConfirmPassword.Text = "Confirm Password";
            // 
            // lblNewPassword
            // 
            this.lblNewPassword.AutoSize = true;
            this.lblNewPassword.Location = new System.Drawing.Point(212, 239);
            this.lblNewPassword.Name = "lblNewPassword";
            this.lblNewPassword.Size = new System.Drawing.Size(100, 17);
            this.lblNewPassword.TabIndex = 4;
            this.lblNewPassword.Text = "New Password";
            // 
            // txtbxEmail
            // 
            this.txtbxEmail.Location = new System.Drawing.Point(372, 55);
            this.txtbxEmail.Name = "txtbxEmail";
            this.txtbxEmail.Size = new System.Drawing.Size(100, 22);
            this.txtbxEmail.TabIndex = 6;
            // 
            // txtbxNewPassword
            // 
            this.txtbxNewPassword.Location = new System.Drawing.Point(372, 234);
            this.txtbxNewPassword.Name = "txtbxNewPassword";
            this.txtbxNewPassword.Size = new System.Drawing.Size(100, 22);
            this.txtbxNewPassword.TabIndex = 7;
            // 
            // txtbxConfirmPassword
            // 
            this.txtbxConfirmPassword.Location = new System.Drawing.Point(372, 300);
            this.txtbxConfirmPassword.Name = "txtbxConfirmPassword";
            this.txtbxConfirmPassword.Size = new System.Drawing.Size(100, 22);
            this.txtbxConfirmPassword.TabIndex = 8;
            // 
            // txtbxUserName
            // 
            this.txtbxUserName.Location = new System.Drawing.Point(372, 174);
            this.txtbxUserName.Name = "txtbxUserName";
            this.txtbxUserName.Size = new System.Drawing.Size(100, 22);
            this.txtbxUserName.TabIndex = 9;
            // 
            // txtbxVarificationCode
            // 
            this.txtbxVarificationCode.Location = new System.Drawing.Point(372, 111);
            this.txtbxVarificationCode.Name = "txtbxVarificationCode";
            this.txtbxVarificationCode.Size = new System.Drawing.Size(100, 22);
            this.txtbxVarificationCode.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(330, 373);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 11;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(463, 372);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmForgetPssword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtbxVarificationCode);
            this.Controls.Add(this.txtbxUserName);
            this.Controls.Add(this.txtbxConfirmPassword);
            this.Controls.Add(this.txtbxNewPassword);
            this.Controls.Add(this.txtbxEmail);
            this.Controls.Add(this.lblConfirmPassword);
            this.Controls.Add(this.lblNewPassword);
            this.Controls.Add(this.lblUserName);
            this.Controls.Add(this.lblVarificationCode);
            this.Controls.Add(this.lblEmail);
            this.Name = "frmForgetPssword";
            this.Text = "Forget Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblVarificationCode;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblConfirmPassword;
        private System.Windows.Forms.Label lblNewPassword;
        private System.Windows.Forms.TextBox txtbxEmail;
        private System.Windows.Forms.TextBox txtbxNewPassword;
        private System.Windows.Forms.TextBox txtbxConfirmPassword;
        private System.Windows.Forms.TextBox txtbxUserName;
        private System.Windows.Forms.TextBox txtbxVarificationCode;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnExit;
    }
}