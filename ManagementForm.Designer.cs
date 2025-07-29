namespace Mini_LMS_App
{
    partial class ManagementForm
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
            components = new System.ComponentModel.Container();
            studentGridView = new DataGridView();
            iDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            roleDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            firstNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            lastNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            gPADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            saveHighestGPAButton = new Button();
            deleteHighestGPAButton = new Button();
            ((System.ComponentModel.ISupportInitialize)studentGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // studentGridView
            // 
            studentGridView.AutoGenerateColumns = false;
            studentGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentGridView.Columns.AddRange(new DataGridViewColumn[] { iDDataGridViewTextBoxColumn, roleDataGridViewTextBoxColumn, firstNameDataGridViewTextBoxColumn, lastNameDataGridViewTextBoxColumn, gPADataGridViewTextBoxColumn });
            studentGridView.DataSource = studentBindingSource;
            studentGridView.Location = new Point(0, 0);
            studentGridView.Name = "studentGridView";
            studentGridView.RowHeadersWidth = 62;
            studentGridView.Size = new Size(799, 450);
            studentGridView.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            iDDataGridViewTextBoxColumn.HeaderText = "ID";
            iDDataGridViewTextBoxColumn.MinimumWidth = 8;
            iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            iDDataGridViewTextBoxColumn.Width = 150;
            // 
            // roleDataGridViewTextBoxColumn
            // 
            roleDataGridViewTextBoxColumn.DataPropertyName = "Role";
            roleDataGridViewTextBoxColumn.HeaderText = "Role";
            roleDataGridViewTextBoxColumn.MinimumWidth = 8;
            roleDataGridViewTextBoxColumn.Name = "roleDataGridViewTextBoxColumn";
            roleDataGridViewTextBoxColumn.Width = 150;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            firstNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            firstNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            lastNameDataGridViewTextBoxColumn.MinimumWidth = 8;
            lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            lastNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // gPADataGridViewTextBoxColumn
            // 
            gPADataGridViewTextBoxColumn.DataPropertyName = "GPA";
            gPADataGridViewTextBoxColumn.HeaderText = "GPA";
            gPADataGridViewTextBoxColumn.MinimumWidth = 8;
            gPADataGridViewTextBoxColumn.Name = "gPADataGridViewTextBoxColumn";
            gPADataGridViewTextBoxColumn.Width = 150;
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Student);
            // 
            // saveHighestGPAButton
            // 
            saveHighestGPAButton.FlatStyle = FlatStyle.Popup;
            saveHighestGPAButton.Location = new Point(805, 0);
            saveHighestGPAButton.Name = "saveHighestGPAButton";
            saveHighestGPAButton.Size = new Size(226, 222);
            saveHighestGPAButton.TabIndex = 1;
            saveHighestGPAButton.Text = "Save Highest GPA";
            saveHighestGPAButton.UseVisualStyleBackColor = true;
            saveHighestGPAButton.Click += saveHighestGPAButton_Click;
            // 
            // deleteHighestGPAButton
            // 
            deleteHighestGPAButton.FlatStyle = FlatStyle.Popup;
            deleteHighestGPAButton.Location = new Point(805, 228);
            deleteHighestGPAButton.Name = "deleteHighestGPAButton";
            deleteHighestGPAButton.Size = new Size(226, 222);
            deleteHighestGPAButton.TabIndex = 2;
            deleteHighestGPAButton.Text = "Delete Highest GPA";
            deleteHighestGPAButton.UseVisualStyleBackColor = true;
            deleteHighestGPAButton.Click += deleteHighestGPAButton_Click;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 450);
            Controls.Add(deleteHighestGPAButton);
            Controls.Add(saveHighestGPAButton);
            Controls.Add(studentGridView);
            Name = "ManagementForm";
            Text = "Learning Management System";
            Load += ManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)studentGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView studentGridView;
        private DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roleDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn gPADataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private Button saveHighestGPAButton;
        private Button deleteHighestGPAButton;
    }
}
