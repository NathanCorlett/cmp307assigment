namespace cmp307
{
    partial class AddSoftware
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
            this.label1 = new System.Windows.Forms.Label();
            this.SoftwareNameBox = new System.Windows.Forms.TextBox();
            this.AddSoftwareBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mssql2100902DataSet5 = new cmp307.mssql2100902DataSet5();
            this.softwareBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.softwareTableAdapter = new cmp307.mssql2100902DataSet5TableAdapters.SoftwareTableAdapter();
            this.softwareIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.softwareNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(12, 13);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(111, 74);
            this.BackBtn.TabIndex = 0;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Software name:";
            // 
            // SoftwareNameBox
            // 
            this.SoftwareNameBox.Location = new System.Drawing.Point(129, 106);
            this.SoftwareNameBox.Name = "SoftwareNameBox";
            this.SoftwareNameBox.Size = new System.Drawing.Size(124, 20);
            this.SoftwareNameBox.TabIndex = 2;
            // 
            // AddSoftwareBtn
            // 
            this.AddSoftwareBtn.Location = new System.Drawing.Point(45, 144);
            this.AddSoftwareBtn.Name = "AddSoftwareBtn";
            this.AddSoftwareBtn.Size = new System.Drawing.Size(208, 66);
            this.AddSoftwareBtn.TabIndex = 3;
            this.AddSoftwareBtn.Text = "AddSoftware";
            this.AddSoftwareBtn.UseVisualStyleBackColor = true;
            this.AddSoftwareBtn.Click += new System.EventHandler(this.AddSoftwareBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.softwareIDDataGridViewTextBoxColumn,
            this.softwareNameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.softwareBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(384, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(368, 412);
            this.dataGridView1.TabIndex = 4;
            // 
            // mssql2100902DataSet5
            // 
            this.mssql2100902DataSet5.DataSetName = "mssql2100902DataSet5";
            this.mssql2100902DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // softwareBindingSource
            // 
            this.softwareBindingSource.DataMember = "Software";
            this.softwareBindingSource.DataSource = this.mssql2100902DataSet5;
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
            // AddSoftware
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddSoftwareBtn);
            this.Controls.Add(this.SoftwareNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BackBtn);
            this.Name = "AddSoftware";
            this.Text = "AddSoftware";
            this.Load += new System.EventHandler(this.AddSoftware_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssql2100902DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.softwareBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SoftwareNameBox;
        private System.Windows.Forms.Button AddSoftwareBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private mssql2100902DataSet5 mssql2100902DataSet5;
        private System.Windows.Forms.BindingSource softwareBindingSource;
        private mssql2100902DataSet5TableAdapters.SoftwareTableAdapter softwareTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn softwareNameDataGridViewTextBoxColumn;
    }
}