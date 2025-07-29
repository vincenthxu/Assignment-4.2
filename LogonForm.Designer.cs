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
            LogonLabel = new Label();
            LogonNoButton = new Button();
            LogonYesButton = new Button();
            SuspendLayout();
            // 
            // LogonLabel
            // 
            LogonLabel.AutoSize = true;
            LogonLabel.Font = new Font("Segoe UI", 40F);
            LogonLabel.Location = new Point(54, 96);
            LogonLabel.Name = "LogonLabel";
            LogonLabel.Size = new Size(703, 106);
            LogonLabel.TabIndex = 0;
            LogonLabel.Text = "Are you a teacher?";
            // 
            // LogonNoButton
            // 
            LogonNoButton.DialogResult = DialogResult.No;
            LogonNoButton.Font = new Font("Segoe UI", 40F);
            LogonNoButton.Location = new Point(12, 279);
            LogonNoButton.Name = "LogonNoButton";
            LogonNoButton.Size = new Size(383, 159);
            LogonNoButton.TabIndex = 1;
            LogonNoButton.Text = "No";
            LogonNoButton.UseVisualStyleBackColor = true;
            // 
            // LogonYesButton
            // 
            LogonYesButton.DialogResult = DialogResult.Yes;
            LogonYesButton.Font = new Font("Segoe UI", 40F);
            LogonYesButton.Location = new Point(401, 279);
            LogonYesButton.Name = "LogonYesButton";
            LogonYesButton.Size = new Size(387, 159);
            LogonYesButton.TabIndex = 2;
            LogonYesButton.Text = "Yes";
            LogonYesButton.UseVisualStyleBackColor = true;
            // 
            // LogonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(LogonYesButton);
            Controls.Add(LogonNoButton);
            Controls.Add(LogonLabel);
            Name = "LogonForm";
            Text = "Log In";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LogonLabel;
        private Button LogonNoButton;
        private Button LogonYesButton;
    }
}