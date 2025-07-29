namespace Mini_LMS_App
{
    partial class LogonForm
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
            LoginButton = new Button();
            usernameLabel = new Label();
            passwordLabel = new Label();
            usernameInputBox = new TextBox();
            passwordInputBox = new TextBox();
            LoginCancelButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 12F);
            LoginButton.Location = new Point(453, 247);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(200, 75);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Log In";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // usernameLabel
            // 
            usernameLabel.AutoSize = true;
            usernameLabel.Location = new Point(146, 118);
            usernameLabel.Name = "usernameLabel";
            usernameLabel.Size = new Size(91, 25);
            usernameLabel.TabIndex = 3;
            usernameLabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(150, 181);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(87, 25);
            passwordLabel.TabIndex = 4;
            passwordLabel.Text = "Password";
            // 
            // usernameInputBox
            // 
            usernameInputBox.Location = new Point(255, 115);
            usernameInputBox.Name = "usernameInputBox";
            usernameInputBox.Size = new Size(387, 31);
            usernameInputBox.TabIndex = 5;
            // 
            // passwordInputBox
            // 
            passwordInputBox.Location = new Point(255, 178);
            passwordInputBox.Name = "passwordInputBox";
            passwordInputBox.Size = new Size(387, 31);
            passwordInputBox.TabIndex = 6;
            passwordInputBox.UseSystemPasswordChar = true;
            // 
            // LoginCancelButton
            // 
            LoginCancelButton.DialogResult = DialogResult.Cancel;
            LoginCancelButton.Font = new Font("Segoe UI", 12F);
            LoginCancelButton.Location = new Point(247, 247);
            LoginCancelButton.Name = "LoginCancelButton";
            LoginCancelButton.Size = new Size(200, 75);
            LoginCancelButton.TabIndex = 1;
            LoginCancelButton.Text = "Cancel";
            LoginCancelButton.UseVisualStyleBackColor = true;
            LoginCancelButton.Click += LoginCancelButton_Click;
            // 
            // LogonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordInputBox);
            Controls.Add(usernameInputBox);
            Controls.Add(passwordLabel);
            Controls.Add(usernameLabel);
            Controls.Add(LoginButton);
            Controls.Add(LoginCancelButton);
            Name = "LogonForm";
            Text = "Log In";
            Load += LogonForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LogonNoButton;
        private Button LoginButton;
        private Label usernameLabel;
        private Label passwordLabel;
        private TextBox usernameInputBox;
        private TextBox passwordInputBox;
        private Button LoginCancelButton;
    }
}