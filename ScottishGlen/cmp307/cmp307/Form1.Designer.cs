namespace cmp307
{
    partial class Form1
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
            this.AddAsset = new System.Windows.Forms.Button();
            this.DeleteAsset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddAsset
            // 
            this.AddAsset.Location = new System.Drawing.Point(15, 14);
            this.AddAsset.Name = "AddAsset";
            this.AddAsset.Size = new System.Drawing.Size(140, 80);
            this.AddAsset.TabIndex = 0;
            this.AddAsset.Text = "Add Asset";
            this.AddAsset.UseVisualStyleBackColor = true;
            this.AddAsset.Click += new System.EventHandler(this.AddAsset_Click);
            // 
            // DeleteAsset
            // 
            this.DeleteAsset.Location = new System.Drawing.Point(161, 14);
            this.DeleteAsset.Name = "DeleteAsset";
            this.DeleteAsset.Size = new System.Drawing.Size(140, 80);
            this.DeleteAsset.TabIndex = 3;
            this.DeleteAsset.Text = "Delete/update Asset";
            this.DeleteAsset.UseVisualStyleBackColor = true;
            this.DeleteAsset.Click += new System.EventHandler(this.DeleteAsset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteAsset);
            this.Controls.Add(this.AddAsset);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button AddAsset;
        private System.Windows.Forms.Button DeleteAsset;
    }
}

