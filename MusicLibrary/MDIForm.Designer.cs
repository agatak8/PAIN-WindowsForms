namespace MusicLibrary
{
    partial class MDIForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIForm));
            this.MDIStatusStrip = new System.Windows.Forms.StatusStrip();
            this.songCountStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MDIToolStrip = new System.Windows.Forms.ToolStrip();
            this.newViewButton = new System.Windows.Forms.ToolStripButton();
            this.MDIStatusStrip.SuspendLayout();
            this.MDIToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // MDIStatusStrip
            // 
            this.MDIStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.songCountStatusLabel});
            this.MDIStatusStrip.Location = new System.Drawing.Point(0, 446);
            this.MDIStatusStrip.Name = "MDIStatusStrip";
            this.MDIStatusStrip.Size = new System.Drawing.Size(611, 22);
            this.MDIStatusStrip.TabIndex = 1;
            this.MDIStatusStrip.Text = "statusStrip1";
            // 
            // songCountStatusLabel
            // 
            this.songCountStatusLabel.Name = "songCountStatusLabel";
            this.songCountStatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // MDIToolStrip
            // 
            this.MDIToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newViewButton});
            this.MDIToolStrip.Location = new System.Drawing.Point(0, 0);
            this.MDIToolStrip.Name = "MDIToolStrip";
            this.MDIToolStrip.Size = new System.Drawing.Size(611, 25);
            this.MDIToolStrip.TabIndex = 2;
            this.MDIToolStrip.Text = "toolStrip1";
            // 
            // newViewButton
            // 
            this.newViewButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.newViewButton.Image = ((System.Drawing.Image)(resources.GetObject("newViewButton.Image")));
            this.newViewButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newViewButton.Name = "newViewButton";
            this.newViewButton.Size = new System.Drawing.Size(95, 22);
            this.newViewButton.Text = "Open New View";
            this.newViewButton.Click += new System.EventHandler(this.newViewButton_Click);
            // 
            // MDIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 468);
            this.Controls.Add(this.MDIToolStrip);
            this.Controls.Add(this.MDIStatusStrip);
            this.IsMdiContainer = true;
            this.Name = "MDIForm";
            this.Text = "Music Library";
            this.Load += new System.EventHandler(this.MDIForm_Load);
            this.MDIStatusStrip.ResumeLayout(false);
            this.MDIStatusStrip.PerformLayout();
            this.MDIToolStrip.ResumeLayout(false);
            this.MDIToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip MDIStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel songCountStatusLabel;
        private System.Windows.Forms.ToolStrip MDIToolStrip;
        private System.Windows.Forms.ToolStripButton newViewButton;
    }
}

