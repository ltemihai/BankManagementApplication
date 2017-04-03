namespace BankManagementApplication.PresentationLayer
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginaccountsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bankdbDataSet2 = new BankManagementApplication.bankdbDataSet2();
            this.login_accountsTableAdapter = new BankManagementApplication.bankdbDataSet2TableAdapters.login_accountsTableAdapter();
            this.addUserButton = new System.Windows.Forms.Button();
            this.removeUserButton = new System.Windows.Forms.Button();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.findUserButton = new System.Windows.Forms.Button();
            this.generateRaportButton = new System.Windows.Forms.Button();
            this.logOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginaccountsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.loginaccountsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(162, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 180);
            this.dataGridView1.TabIndex = 0;
            // 
            // userDataGridViewTextBoxColumn
            // 
            this.userDataGridViewTextBoxColumn.DataPropertyName = "user";
            this.userDataGridViewTextBoxColumn.HeaderText = "user";
            this.userDataGridViewTextBoxColumn.Name = "userDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // loginaccountsBindingSource
            // 
            this.loginaccountsBindingSource.DataMember = "login_accounts";
            this.loginaccountsBindingSource.DataSource = this.bankdbDataSet2;
            // 
            // bankdbDataSet2
            // 
            this.bankdbDataSet2.DataSetName = "bankdbDataSet2";
            this.bankdbDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // login_accountsTableAdapter
            // 
            this.login_accountsTableAdapter.ClearBeforeFill = true;
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(42, 23);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(75, 23);
            this.addUserButton.TabIndex = 1;
            this.addUserButton.Text = "Add";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // removeUserButton
            // 
            this.removeUserButton.Location = new System.Drawing.Point(42, 52);
            this.removeUserButton.Name = "removeUserButton";
            this.removeUserButton.Size = new System.Drawing.Size(75, 23);
            this.removeUserButton.TabIndex = 2;
            this.removeUserButton.Text = "Remove";
            this.removeUserButton.UseVisualStyleBackColor = true;
            this.removeUserButton.Click += new System.EventHandler(this.removeUserButton_Click);
            // 
            // updateUserButton
            // 
            this.updateUserButton.Location = new System.Drawing.Point(42, 81);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(75, 23);
            this.updateUserButton.TabIndex = 3;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = true;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // findUserButton
            // 
            this.findUserButton.Location = new System.Drawing.Point(42, 110);
            this.findUserButton.Name = "findUserButton";
            this.findUserButton.Size = new System.Drawing.Size(75, 23);
            this.findUserButton.TabIndex = 4;
            this.findUserButton.Text = "Find";
            this.findUserButton.UseVisualStyleBackColor = true;
            this.findUserButton.Click += new System.EventHandler(this.findUserButton_Click);
            // 
            // generateRaportButton
            // 
            this.generateRaportButton.Location = new System.Drawing.Point(42, 139);
            this.generateRaportButton.Name = "generateRaportButton";
            this.generateRaportButton.Size = new System.Drawing.Size(75, 23);
            this.generateRaportButton.TabIndex = 5;
            this.generateRaportButton.Text = "Generate";
            this.generateRaportButton.UseVisualStyleBackColor = true;
            // 
            // logOutButton
            // 
            this.logOutButton.Location = new System.Drawing.Point(42, 168);
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Size = new System.Drawing.Size(75, 23);
            this.logOutButton.TabIndex = 6;
            this.logOutButton.Text = "Logout";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 229);
            this.Controls.Add(this.logOutButton);
            this.Controls.Add(this.generateRaportButton);
            this.Controls.Add(this.findUserButton);
            this.Controls.Add(this.updateUserButton);
            this.Controls.Add(this.removeUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.loginaccountsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bankdbDataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private bankdbDataSet2 bankdbDataSet2;
        private System.Windows.Forms.BindingSource loginaccountsBindingSource;
        private bankdbDataSet2TableAdapters.login_accountsTableAdapter login_accountsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn userDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button removeUserButton;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Button findUserButton;
        private System.Windows.Forms.Button generateRaportButton;
        private System.Windows.Forms.Button logOutButton;
    }
}