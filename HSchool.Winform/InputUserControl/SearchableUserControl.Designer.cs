namespace HSchool.Winform.InputUserControl
{
    partial class SearchableUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StringTextBox
            // 
            this.StringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StringTextBox.Location = new System.Drawing.Point(3, 16);
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(118, 22);
            this.StringTextBox.TabIndex = 3;
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(48, 13);
            this.CaptionLabel.TabIndex = 2;
            this.CaptionLabel.Text = "Caption";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(123, 16);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(24, 23);
            this.SearchButton.TabIndex = 4;
            this.SearchButton.Text = "...";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(3, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(144, 22);
            this.textBox1.TabIndex = 5;
            // 
            // SearchableUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.StringTextBox);
            this.Controls.Add(this.CaptionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "SearchableUserControl";
            this.Size = new System.Drawing.Size(150, 70);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox StringTextBox;
        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}
