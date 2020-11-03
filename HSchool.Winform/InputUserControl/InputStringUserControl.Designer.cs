namespace HSchool.Winform.InputUserControl
{
    partial class InputStringUserControl
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
            this.CaptionLabel = new System.Windows.Forms.Label();
            this.StringTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CaptionLabel
            // 
            this.CaptionLabel.AutoSize = true;
            this.CaptionLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.CaptionLabel.Location = new System.Drawing.Point(0, 0);
            this.CaptionLabel.Name = "CaptionLabel";
            this.CaptionLabel.Size = new System.Drawing.Size(48, 13);
            this.CaptionLabel.TabIndex = 0;
            this.CaptionLabel.Text = "Caption";
            // 
            // StringTextBox
            // 
            this.StringTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.StringTextBox.Location = new System.Drawing.Point(3, 16);
            this.StringTextBox.Name = "StringTextBox";
            this.StringTextBox.Size = new System.Drawing.Size(144, 22);
            this.StringTextBox.TabIndex = 1;
            // 
            // InputStringUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StringTextBox);
            this.Controls.Add(this.CaptionLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "InputStringUserControl";
            this.Size = new System.Drawing.Size(150, 42);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CaptionLabel;
        private System.Windows.Forms.TextBox StringTextBox;
    }
}
