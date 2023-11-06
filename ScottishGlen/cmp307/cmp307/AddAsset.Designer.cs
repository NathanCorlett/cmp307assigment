namespace cmp307
{
    partial class AddAsset
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.AddAssetTextBox = new System.Windows.Forms.TextBox();
            this.AddAssetCommentTextBox = new System.Windows.Forms.TextBox();
            this.AddAssetEmployeeIDTextBox = new System.Windows.Forms.TextBox();
            this.AddAssetButton = new System.Windows.Forms.Button();
            this.AddAssetBackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asset Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Employee Responsible by ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Extra Information:";
            // 
            // AddAssetTextBox
            // 
            this.AddAssetTextBox.Location = new System.Drawing.Point(81, 108);
            this.AddAssetTextBox.Name = "AddAssetTextBox";
            this.AddAssetTextBox.Size = new System.Drawing.Size(246, 20);
            this.AddAssetTextBox.TabIndex = 3;
            // 
            // AddAssetCommentTextBox
            // 
            this.AddAssetCommentTextBox.Location = new System.Drawing.Point(103, 242);
            this.AddAssetCommentTextBox.Name = "AddAssetCommentTextBox";
            this.AddAssetCommentTextBox.Size = new System.Drawing.Size(246, 20);
            this.AddAssetCommentTextBox.TabIndex = 4;
            // 
            // AddAssetEmployeeIDTextBox
            // 
            this.AddAssetEmployeeIDTextBox.Location = new System.Drawing.Point(159, 164);
            this.AddAssetEmployeeIDTextBox.Name = "AddAssetEmployeeIDTextBox";
            this.AddAssetEmployeeIDTextBox.Size = new System.Drawing.Size(67, 20);
            this.AddAssetEmployeeIDTextBox.TabIndex = 5;
            // 
            // AddAssetButton
            // 
            this.AddAssetButton.Location = new System.Drawing.Point(440, 130);
            this.AddAssetButton.Name = "AddAssetButton";
            this.AddAssetButton.Size = new System.Drawing.Size(230, 86);
            this.AddAssetButton.TabIndex = 6;
            this.AddAssetButton.Text = "Add Asset";
            this.AddAssetButton.UseVisualStyleBackColor = true;
            // 
            // AddAssetBackButton
            // 
            this.AddAssetBackButton.Location = new System.Drawing.Point(12, 12);
            this.AddAssetBackButton.Name = "AddAssetBackButton";
            this.AddAssetBackButton.Size = new System.Drawing.Size(108, 67);
            this.AddAssetBackButton.TabIndex = 7;
            this.AddAssetBackButton.Text = "Back";
            this.AddAssetBackButton.UseVisualStyleBackColor = true;
            // 
            // AddAsset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AddAssetBackButton);
            this.Controls.Add(this.AddAssetButton);
            this.Controls.Add(this.AddAssetEmployeeIDTextBox);
            this.Controls.Add(this.AddAssetCommentTextBox);
            this.Controls.Add(this.AddAssetTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddAsset";
            this.Text = "AddAsset";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AddAssetTextBox;
        private System.Windows.Forms.TextBox AddAssetCommentTextBox;
        private System.Windows.Forms.TextBox AddAssetEmployeeIDTextBox;
        private System.Windows.Forms.Button AddAssetButton;
        private System.Windows.Forms.Button AddAssetBackButton;
    }
}