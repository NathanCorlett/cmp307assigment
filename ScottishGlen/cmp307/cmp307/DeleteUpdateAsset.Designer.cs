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
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2100902DataSet = new cmp307.mssql2100902DataSet();
            this.assetsTableAdapter = new cmp307.mssql2100902DataSetTableAdapters.assetsTableAdapter();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DateBox = new System.Windows.Forms.TextBox();
            this.systemnamebox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ModelBox = new System.Windows.Forms.TextBox();
            this.ManufacturerBox = new System.Windows.Forms.TextBox();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.EmployeeTextBox = new System.Windows.Forms.TextBox();
            this.CommentTextBox = new System.Windows.Forms.TextBox();
            this.AssetNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtSelectedAsset = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.hardwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeResponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.manufacturerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iPadressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datePurchesedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.systemNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assetsBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.mssql2100902DataSet2 = new cmp307.mssql2100902DataSet2();
            this.assetsTableAdapter1 = new cmp307.mssql2100902DataSet2TableAdapters.assetsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet2)).BeginInit();
            this.SuspendLayout();
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(452, 263);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Date Purchesed:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(466, 289);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "SystemName:";
            // 
            // DateBox
            // 
            this.DateBox.Location = new System.Drawing.Point(545, 260);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(246, 20);
            this.DateBox.TabIndex = 35;
            this.DateBox.Text = "dd/mm/yy";
            // 
            // systemnamebox
            // 
            this.systemnamebox.Location = new System.Drawing.Point(545, 286);
            this.systemnamebox.Name = "systemnamebox";
            this.systemnamebox.Size = new System.Drawing.Size(246, 20);
            this.systemnamebox.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(501, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 33;
            this.label7.Text = "model:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(466, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Manufacturer:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(505, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Type:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(484, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "IP Adress:";
            // 
            // ModelBox
            // 
            this.ModelBox.Location = new System.Drawing.Point(545, 159);
            this.ModelBox.Name = "ModelBox";
            this.ModelBox.Size = new System.Drawing.Size(246, 20);
            this.ModelBox.TabIndex = 29;
            // 
            // ManufacturerBox
            // 
            this.ManufacturerBox.Location = new System.Drawing.Point(545, 185);
            this.ManufacturerBox.Name = "ManufacturerBox";
            this.ManufacturerBox.Size = new System.Drawing.Size(246, 20);
            this.ManufacturerBox.TabIndex = 28;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Location = new System.Drawing.Point(545, 234);
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(246, 20);
            this.IPTextBox.TabIndex = 27;
            // 
            // TypeBox
            // 
            this.TypeBox.Location = new System.Drawing.Point(545, 211);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(246, 20);
            this.TypeBox.TabIndex = 26;
            // 
            // EmployeeTextBox
            // 
            this.EmployeeTextBox.Location = new System.Drawing.Point(545, 133);
            this.EmployeeTextBox.Name = "EmployeeTextBox";
            this.EmployeeTextBox.Size = new System.Drawing.Size(246, 20);
            this.EmployeeTextBox.TabIndex = 25;
            // 
            // CommentTextBox
            // 
            this.CommentTextBox.Location = new System.Drawing.Point(545, 312);
            this.CommentTextBox.Name = "CommentTextBox";
            this.CommentTextBox.Size = new System.Drawing.Size(246, 20);
            this.CommentTextBox.TabIndex = 24;
            // 
            // AssetNameTextBox
            // 
            this.AssetNameTextBox.Location = new System.Drawing.Point(545, 107);
            this.AssetNameTextBox.Name = "AssetNameTextBox";
            this.AssetNameTextBox.Size = new System.Drawing.Size(246, 20);
            this.AssetNameTextBox.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Extra Information:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Employee Responsible by ID:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(472, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Asset Name:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Hardware ID:";
            // 
            // txtSelectedAsset
            // 
            this.txtSelectedAsset.Location = new System.Drawing.Point(545, 81);
            this.txtSelectedAsset.Name = "txtSelectedAsset";
            this.txtSelectedAsset.ReadOnly = true;
            this.txtSelectedAsset.Size = new System.Drawing.Size(246, 20);
            this.txtSelectedAsset.TabIndex = 39;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.hardwareIDDataGridViewTextBoxColumn,
            this.employeeResponsibleDataGridViewTextBoxColumn,
            this.assetNameDataGridViewTextBoxColumn,
            this.commentDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.manufacturerDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn,
            this.iPadressDataGridViewTextBoxColumn,
            this.datePurchesedDataGridViewTextBoxColumn,
            this.systemNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetsBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(16, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(372, 426);
            this.dataGridView1.TabIndex = 40;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick_1);
            // 
            // hardwareIDDataGridViewTextBoxColumn
            // 
            this.hardwareIDDataGridViewTextBoxColumn.DataPropertyName = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.HeaderText = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn.Name = "hardwareIDDataGridViewTextBoxColumn";
            this.hardwareIDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeResponsibleDataGridViewTextBoxColumn
            // 
            this.employeeResponsibleDataGridViewTextBoxColumn.DataPropertyName = "EmployeeResponsible";
            this.employeeResponsibleDataGridViewTextBoxColumn.HeaderText = "EmployeeResponsible";
            this.employeeResponsibleDataGridViewTextBoxColumn.Name = "employeeResponsibleDataGridViewTextBoxColumn";
            this.employeeResponsibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assetNameDataGridViewTextBoxColumn
            // 
            this.assetNameDataGridViewTextBoxColumn.DataPropertyName = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.HeaderText = "AssetName";
            this.assetNameDataGridViewTextBoxColumn.Name = "assetNameDataGridViewTextBoxColumn";
            this.assetNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // commentDataGridViewTextBoxColumn
            // 
            this.commentDataGridViewTextBoxColumn.DataPropertyName = "comment";
            this.commentDataGridViewTextBoxColumn.HeaderText = "comment";
            this.commentDataGridViewTextBoxColumn.Name = "commentDataGridViewTextBoxColumn";
            this.commentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            this.manufacturerDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iPadressDataGridViewTextBoxColumn
            // 
            this.iPadressDataGridViewTextBoxColumn.DataPropertyName = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.HeaderText = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.Name = "iPadressDataGridViewTextBoxColumn";
            this.iPadressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datePurchesedDataGridViewTextBoxColumn
            // 
            this.datePurchesedDataGridViewTextBoxColumn.DataPropertyName = "DatePurchesed";
            this.datePurchesedDataGridViewTextBoxColumn.HeaderText = "DatePurchesed";
            this.datePurchesedDataGridViewTextBoxColumn.Name = "datePurchesedDataGridViewTextBoxColumn";
            this.datePurchesedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // systemNameDataGridViewTextBoxColumn
            // 
            this.systemNameDataGridViewTextBoxColumn.DataPropertyName = "SystemName";
            this.systemNameDataGridViewTextBoxColumn.HeaderText = "SystemName";
            this.systemNameDataGridViewTextBoxColumn.Name = "systemNameDataGridViewTextBoxColumn";
            this.systemNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // assetsBindingSource1
            // 
            this.assetsBindingSource1.DataMember = "assets";
            this.assetsBindingSource1.DataSource = this.mssql2100902DataSet2;
            // 
            // mssql2100902DataSet2
            // 
            this.mssql2100902DataSet2.DataSetName = "mssql2100902DataSet2";
            this.mssql2100902DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsTableAdapter1
            // 
            this.assetsTableAdapter1.ClearBeforeFill = true;
            // 
            // DeleteUpdateAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSelectedAsset);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.systemnamebox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModelBox);
            this.Controls.Add(this.ManufacturerBox);
            this.Controls.Add(this.IPTextBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.EmployeeTextBox);
            this.Controls.Add(this.CommentTextBox);
            this.Controls.Add(this.AssetNameTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Edit);
            this.Controls.Add(this.DeleteButton);
            this.Name = "DeleteUpdateAsset";
            this.Text = "DeleteAsset";
            this.Load += new System.EventHandler(this.DeleteAsset_Load);
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private mssql2100902DataSet mssql2100902DataSet;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2100902DataSetTableAdapters.assetsTableAdapter assetsTableAdapter;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox DateBox;
        private System.Windows.Forms.TextBox systemnamebox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ModelBox;
        private System.Windows.Forms.TextBox ManufacturerBox;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.TextBox EmployeeTextBox;
        private System.Windows.Forms.TextBox CommentTextBox;
        private System.Windows.Forms.TextBox AssetNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSelectedAsset;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2100902DataSet2 mssql2100902DataSet2;
        private System.Windows.Forms.BindingSource assetsBindingSource1;
        private mssql2100902DataSet2TableAdapters.assetsTableAdapter assetsTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeResponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn assetNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn commentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn manufacturerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iPadressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datePurchesedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn systemNameDataGridViewTextBoxColumn;
    }
}