namespace cmp307
{
    partial class assetsoftwarelink
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
            this.BackBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2100902DataSet7 = new cmp307.mssql2100902DataSet7();
            this.assetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.assetsTableAdapter = new cmp307.mssql2100902DataSet7TableAdapters.assetsTableAdapter();
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
            this.linkedSoftwareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.mssql2100902DataSet8 = new cmp307.mssql2100902DataSet8();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareTableAdapter = new cmp307.mssql2100902DataSet8TableAdapters.SoftwareTableAdapter();
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.mssql2100902DataSet9 = new cmp307.mssql2100902DataSet9();
            this.softwareLinkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareLinkTableAdapter = new cmp307.mssql2100902DataSet9TableAdapters.SoftwareLinkTableAdapter();
            this.linkIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hardwareIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareIDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateOfLinkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SoftwareIDBox = new System.Windows.Forms.TextBox();
            this.LinkIDBox = new System.Windows.Forms.TextBox();
            this.HardWareIDBox = new System.Windows.Forms.TextBox();
            this.linkBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareLinkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 12);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(117, 65);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
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
            this.systemNameDataGridViewTextBoxColumn,
            this.linkedSoftwareDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.assetsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(356, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(251, 209);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // mssql2100902DataSet7
            // 
            this.mssql2100902DataSet7.DataSetName = "mssql2100902DataSet7";
            this.mssql2100902DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // assetsBindingSource
            // 
            this.assetsBindingSource.DataMember = "assets";
            this.assetsBindingSource.DataSource = this.mssql2100902DataSet7;
            // 
            // assetsTableAdapter
            // 
            this.assetsTableAdapter.ClearBeforeFill = true;
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
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "model";
            this.modelDataGridViewTextBoxColumn.HeaderText = "model";
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            // 
            // manufacturerDataGridViewTextBoxColumn
            // 
            this.manufacturerDataGridViewTextBoxColumn.DataPropertyName = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.HeaderText = "manufacturer";
            this.manufacturerDataGridViewTextBoxColumn.Name = "manufacturerDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "type";
            this.typeDataGridViewTextBoxColumn.HeaderText = "type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // iPadressDataGridViewTextBoxColumn
            // 
            this.iPadressDataGridViewTextBoxColumn.DataPropertyName = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.HeaderText = "IPadress";
            this.iPadressDataGridViewTextBoxColumn.Name = "iPadressDataGridViewTextBoxColumn";
            // 
            // datePurchesedDataGridViewTextBoxColumn
            // 
            this.datePurchesedDataGridViewTextBoxColumn.DataPropertyName = "DatePurchesed";
            this.datePurchesedDataGridViewTextBoxColumn.HeaderText = "DatePurchesed";
            this.datePurchesedDataGridViewTextBoxColumn.Name = "datePurchesedDataGridViewTextBoxColumn";
            // 
            // systemNameDataGridViewTextBoxColumn
            // 
            this.systemNameDataGridViewTextBoxColumn.DataPropertyName = "SystemName";
            this.systemNameDataGridViewTextBoxColumn.HeaderText = "SystemName";
            this.systemNameDataGridViewTextBoxColumn.Name = "systemNameDataGridViewTextBoxColumn";
            // 
            // linkedSoftwareDataGridViewTextBoxColumn
            // 
            this.linkedSoftwareDataGridViewTextBoxColumn.DataPropertyName = "LinkedSoftware";
            this.linkedSoftwareDataGridViewTextBoxColumn.HeaderText = "LinkedSoftware";
            this.linkedSoftwareDataGridViewTextBoxColumn.Name = "linkedSoftwareDataGridViewTextBoxColumn";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIDDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.softwareBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(613, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(175, 209);
            this.dataGridView2.TabIndex = 2;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // mssql2100902DataSet8
            // 
            this.mssql2100902DataSet8.DataSetName = "mssql2100902DataSet8";
            this.mssql2100902DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "Software";
            this.softwareBindingSource.DataSource = this.mssql2100902DataSet8;
            // 
            // softwareTableAdapter
            // 
            this.softwareTableAdapter.ClearBeforeFill = true;
            // 
            // softwareIDDataGridViewTextBoxColumn
            // 
            this.softwareIDDataGridViewTextBoxColumn.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn.Name = "softwareIDDataGridViewTextBoxColumn";
            // 
            // softwareNameDataGridViewTextBoxColumn
            // 
            this.softwareNameDataGridViewTextBoxColumn.DataPropertyName = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.HeaderText = "SoftwareName";
            this.softwareNameDataGridViewTextBoxColumn.Name = "softwareNameDataGridViewTextBoxColumn";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.linkIDDataGridViewTextBoxColumn,
            this.hardwareIDDataGridViewTextBoxColumn1,
            this.softwareIDDataGridViewTextBoxColumn1,
            this.dateOfLinkDataGridViewTextBoxColumn});
            this.dataGridView3.DataSource = this.softwareLinkBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(613, 218);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(175, 220);
            this.dataGridView3.TabIndex = 3;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // mssql2100902DataSet9
            // 
            this.mssql2100902DataSet9.DataSetName = "mssql2100902DataSet9";
            this.mssql2100902DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareLinkBindingSource
            // 
            this.softwareLinkBindingSource.DataMember = "SoftwareLink";
            this.softwareLinkBindingSource.DataSource = this.mssql2100902DataSet9;
            // 
            // softwareLinkTableAdapter
            // 
            this.softwareLinkTableAdapter.ClearBeforeFill = true;
            // 
            // linkIDDataGridViewTextBoxColumn
            // 
            this.linkIDDataGridViewTextBoxColumn.DataPropertyName = "LinkID";
            this.linkIDDataGridViewTextBoxColumn.HeaderText = "LinkID";
            this.linkIDDataGridViewTextBoxColumn.Name = "linkIDDataGridViewTextBoxColumn";
            // 
            // hardwareIDDataGridViewTextBoxColumn1
            // 
            this.hardwareIDDataGridViewTextBoxColumn1.DataPropertyName = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn1.HeaderText = "HardwareID";
            this.hardwareIDDataGridViewTextBoxColumn1.Name = "hardwareIDDataGridViewTextBoxColumn1";
            // 
            // softwareIDDataGridViewTextBoxColumn1
            // 
            this.softwareIDDataGridViewTextBoxColumn1.DataPropertyName = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn1.HeaderText = "SoftwareID";
            this.softwareIDDataGridViewTextBoxColumn1.Name = "softwareIDDataGridViewTextBoxColumn1";
            // 
            // dateOfLinkDataGridViewTextBoxColumn
            // 
            this.dateOfLinkDataGridViewTextBoxColumn.DataPropertyName = "DateOfLink";
            this.dateOfLinkDataGridViewTextBoxColumn.HeaderText = "DateOfLink";
            this.dateOfLinkDataGridViewTextBoxColumn.Name = "dateOfLinkDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 153);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "SoftwareID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "HardwareID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(351, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "LinkID:";
            // 
            // SoftwareIDBox
            // 
            this.SoftwareIDBox.Location = new System.Drawing.Point(131, 150);
            this.SoftwareIDBox.Name = "SoftwareIDBox";
            this.SoftwareIDBox.ReadOnly = true;
            this.SoftwareIDBox.Size = new System.Drawing.Size(159, 20);
            this.SoftwareIDBox.TabIndex = 7;
            // 
            // LinkIDBox
            // 
            this.LinkIDBox.Location = new System.Drawing.Point(398, 241);
            this.LinkIDBox.Name = "LinkIDBox";
            this.LinkIDBox.ReadOnly = true;
            this.LinkIDBox.Size = new System.Drawing.Size(153, 20);
            this.LinkIDBox.TabIndex = 8;
            // 
            // HardWareIDBox
            // 
            this.HardWareIDBox.Location = new System.Drawing.Point(131, 124);
            this.HardWareIDBox.Name = "HardWareIDBox";
            this.HardWareIDBox.ReadOnly = true;
            this.HardWareIDBox.Size = new System.Drawing.Size(159, 20);
            this.HardWareIDBox.TabIndex = 9;
            // 
            // linkBtn
            // 
            this.linkBtn.Location = new System.Drawing.Point(131, 195);
            this.linkBtn.Name = "linkBtn";
            this.linkBtn.Size = new System.Drawing.Size(159, 66);
            this.linkBtn.TabIndex = 10;
            this.linkBtn.Text = "CerateLink";
            this.linkBtn.UseVisualStyleBackColor = true;
            this.linkBtn.Click += new System.EventHandler(this.linkBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(398, 281);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(152, 66);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Delete Link";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // assetsoftwarelink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.linkBtn);
            this.Controls.Add(this.HardWareIDBox);
            this.Controls.Add(this.LinkIDBox);
            this.Controls.Add(this.SoftwareIDBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BackBtn);
            this.Name = "assetsoftwarelink";
            this.Text = "assetsoftwarelink";
            this.Load += new System.EventHandler(this.assetsoftwarelink_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.assetsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareLinkBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2100902DataSet7 mssql2100902DataSet7;
        private System.Windows.Forms.BindingSource assetsBindingSource;
        private mssql2100902DataSet7TableAdapters.assetsTableAdapter assetsTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn linkedSoftwareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private mssql2100902DataSet8 mssql2100902DataSet8;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private mssql2100902DataSet8TableAdapters.SoftwareTableAdapter softwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView3;
        private mssql2100902DataSet9 mssql2100902DataSet9;
        private System.Windows.Forms.BindingSource softwareLinkBindingSource;
        private mssql2100902DataSet9TableAdapters.SoftwareLinkTableAdapter softwareLinkTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn linkIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hardwareIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateOfLinkDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SoftwareIDBox;
        private System.Windows.Forms.TextBox LinkIDBox;
        private System.Windows.Forms.TextBox HardWareIDBox;
        private System.Windows.Forms.Button linkBtn;
        private System.Windows.Forms.Button DelBtn;
    }
}