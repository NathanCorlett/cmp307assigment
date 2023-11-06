namespace cmp307
{
    partial class DeleteUpdateAsset
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
            this.hardwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeResponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2100902DataSet = new cmp307.mssql2100902DataSet();
            this.assetsTableAdapter = new cmp307.mssql2100902DataSetTableAdapters.assetsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSelectedAsset = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.AssetNameTextBox = new System.Windows.Forms.TextBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.Edit = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hardwareIDDataGridViewTextBoxColumn,
            this.employeeResponsibleDataGridViewTextBoxColumn,
            this.assetNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(403, 423);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // hardwareIDDataGridViewTextBoxColumn
            // 
            this.hardwareIDDataGridViewTextBoxColumn.DataPropertyName = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.HeaderText = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.Name = "hardwareIDDataGridViewTextBoxColumn";
            // 
            // employeeResponsibleDataGridViewTextBoxColumn
            // 
            this.employeeResponsibleDataGridViewTextBoxColumn.DataPropertyName = "EmployeeResponsible";
            this.employeeResponsibleDataGridViewTextBoxColumn.HeaderText = "EmployeeResponsible";
            this.employeeResponsibleDataGridViewTextBoxColumn.Name = "employeeResponsibleDataGridViewTextBoxColumn";
            // 
            // assetNameDataGridViewTextBoxColumn
            // 
            this.assetNameDataGridViewTextBoxColumn.DataPropertyName = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.HeaderText = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.Name = "assetNameDataGridViewTextBoxColumn";
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "assets";
            this.assetsBindingSource.DataSource = this.mssql2100902DataSet;
            // 
            // mssql2100902DataSet
            // 
            this.mssql2100902DataSet.DataSetName = "mssql2100902DataSet";
            this.mssql2100902DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(429, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selected Assets ID:";
            // 
            // txtSelectedAsset
            // 
            this.txtSelectedAsset.Location = new System.Drawing.Point(535, 20);
            this.txtSelectedAsset.Name = "txtSelectedAsset";
            this.txtSelectedAsset.ReadOnly = true;
            this.txtSelectedAsset.Size = new System.Drawing.Size(129, 20);
            this.txtSelectedAsset.TabIndex = 3;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(561, 353);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(123, 82);
            this.DeleteButton.TabIndex = 4;
            this.DeleteButton.Text = "Delete asset";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Employee:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(478, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Comment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Asset name:";
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(535, 95);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(129, 20);
            this.CommentTextBox.TabIndex = 8;
            // 
            // AssetNameTextBox
            // 
            this.AssetNameTextBox.Location = new System.Drawing.Point(535, 69);
            this.AssetNameTextBox.Name = "AssetNameTextBox";
            this.AssetNameTextBox.Size = new System.Drawing.Size(129, 20);
            this.AssetNameTextBox.TabIndex = 9;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(535, 46);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(129, 20);
            this.EmployeeTextBox.TabIndex = 10;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(432, 353);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(123, 82);
            this.Edit.TabIndex = 11;
            this.Edit.Text = "update asset";
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(702, 19);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(89, 53);
            this.BackButton.TabIndex = 12;
            this.BackButton.Text = "back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // DeleteAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.AssetNameTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.txtSelectedAsset);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "DeleteAsset";
            this.Text = "DeleteAsset";
            this.Load += new System.EventHandler(this.DeleteAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2100902DataSet mssql2100902DataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2100902DataSetTableAdapters.assetsTableAdapter assetsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeResponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSelectedAsset;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox AssetNameTextBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button BackButton;
    }
}