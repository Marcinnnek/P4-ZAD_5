
namespace P4_PROJEKT_NR_1
{
    partial class Create_Login
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
            this.labelUserName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.textBoxRePassword = new System.Windows.Forms.TextBox();
            this.textBoxReRPassword = new System.Windows.Forms.TextBox();
            this.checkBoxRODO = new System.Windows.Forms.CheckBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxLoginPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelLoginPassword = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelUserName
            // 
            this.labelUserName.AutoSize = true;
            this.labelUserName.Location = new System.Drawing.Point(65, 37);
            this.labelUserName.Name = "labelUserName";
            this.labelUserName.Size = new System.Drawing.Size(80, 19);
            this.labelUserName.TabIndex = 0;
            this.labelUserName.Text = "User Name:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(65, 70);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(70, 19);
            this.labelPassword.TabIndex = 1;
            this.labelPassword.Text = "Password:";
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Location = new System.Drawing.Point(65, 103);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(116, 19);
            this.labelRepeatPassword.TabIndex = 2;
            this.labelRepeatPassword.Text = "Repeat Password:";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Location = new System.Drawing.Point(194, 34);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(186, 26);
            this.textBoxUserName.TabIndex = 3;
            // 
            // textBoxRePassword
            // 
            this.textBoxRePassword.Location = new System.Drawing.Point(194, 67);
            this.textBoxRePassword.Name = "textBoxRePassword";
            this.textBoxRePassword.PasswordChar = '*';
            this.textBoxRePassword.Size = new System.Drawing.Size(186, 26);
            this.textBoxRePassword.TabIndex = 4;
            // 
            // textBoxReRPassword
            // 
            this.textBoxReRPassword.Location = new System.Drawing.Point(194, 100);
            this.textBoxReRPassword.Name = "textBoxReRPassword";
            this.textBoxReRPassword.PasswordChar = '*';
            this.textBoxReRPassword.Size = new System.Drawing.Size(186, 26);
            this.textBoxReRPassword.TabIndex = 5;
            // 
            // checkBoxRODO
            // 
            this.checkBoxRODO.AutoSize = true;
            this.checkBoxRODO.Location = new System.Drawing.Point(194, 133);
            this.checkBoxRODO.Name = "checkBoxRODO";
            this.checkBoxRODO.Size = new System.Drawing.Size(111, 23);
            this.checkBoxRODO.TabIndex = 6;
            this.checkBoxRODO.Text = "Zgoda RODO";
            this.checkBoxRODO.UseVisualStyleBackColor = true;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(577, 34);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(198, 26);
            this.textBoxLogin.TabIndex = 7;
            // 
            // textBoxLoginPassword
            // 
            this.textBoxLoginPassword.Location = new System.Drawing.Point(577, 67);
            this.textBoxLoginPassword.Name = "textBoxLoginPassword";
            this.textBoxLoginPassword.PasswordChar = '*';
            this.textBoxLoginPassword.Size = new System.Drawing.Size(198, 26);
            this.textBoxLoginPassword.TabIndex = 8;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(500, 37);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(46, 19);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Login:";
            // 
            // labelLoginPassword
            // 
            this.labelLoginPassword.AutoSize = true;
            this.labelLoginPassword.Location = new System.Drawing.Point(500, 70);
            this.labelLoginPassword.Name = "labelLoginPassword";
            this.labelLoginPassword.Size = new System.Drawing.Size(70, 19);
            this.labelLoginPassword.TabIndex = 10;
            this.labelLoginPassword.Text = "Password:";
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(194, 178);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(86, 26);
            this.buttonCancel.TabIndex = 11;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(294, 178);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(86, 26);
            this.buttonRegister.TabIndex = 12;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(631, 103);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(86, 26);
            this.buttonLogin.TabIndex = 13;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Create_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 216);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelLoginPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxLoginPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.checkBoxRODO);
            this.Controls.Add(this.textBoxReRPassword);
            this.Controls.Add(this.textBoxRePassword);
            this.Controls.Add(this.textBoxUserName);
            this.Controls.Add(this.labelRepeatPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUserName);
            this.Name = "Create_Login";
            this.Text = "Rejestracja i logowanie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUserName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.TextBox textBoxRePassword;
        private System.Windows.Forms.TextBox textBoxReRPassword;
        private System.Windows.Forms.CheckBox checkBoxRODO;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxLoginPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelLoginPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonLogin;
    }
}