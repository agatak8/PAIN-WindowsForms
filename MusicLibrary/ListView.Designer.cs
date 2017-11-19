namespace MusicLibrary
{
    partial class ListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ListView));
            this.listViewToolStrip = new System.Windows.Forms.ToolStrip();
            this.addSongButton = new System.Windows.Forms.ToolStripButton();
            this.editSongButton = new System.Windows.Forms.ToolStripButton();
            this.deleteSongButton = new System.Windows.Forms.ToolStripButton();
            this.listViewBase = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnGenre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ListViewFilterButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.noFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notAfter2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.after2000ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ElementCountLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.listViewToolStrip.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewToolStrip
            // 
            this.listViewToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addSongButton,
            this.editSongButton,
            this.deleteSongButton,
            this.ListViewFilterButton});
            this.listViewToolStrip.Location = new System.Drawing.Point(0, 0);
            this.listViewToolStrip.Name = "listViewToolStrip";
            this.listViewToolStrip.Size = new System.Drawing.Size(341, 25);
            this.listViewToolStrip.TabIndex = 0;
            this.listViewToolStrip.Text = "toolStrip1";
            this.listViewToolStrip.Visible = false;
            // 
            // addSongButton
            // 
            this.addSongButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.addSongButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addSongButton.Name = "addSongButton";
            this.addSongButton.Size = new System.Drawing.Size(33, 22);
            this.addSongButton.Text = "Add";
            this.addSongButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.addSongButton.Click += new System.EventHandler(this.addSongButton_Click);
            // 
            // editSongButton
            // 
            this.editSongButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.editSongButton.Image = ((System.Drawing.Image)(resources.GetObject("editSongButton.Image")));
            this.editSongButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editSongButton.Name = "editSongButton";
            this.editSongButton.Size = new System.Drawing.Size(31, 22);
            this.editSongButton.Text = "Edit";
            this.editSongButton.Click += new System.EventHandler(this.editSongButton_Click);
            // 
            // deleteSongButton
            // 
            this.deleteSongButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.deleteSongButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteSongButton.Image")));
            this.deleteSongButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.deleteSongButton.Name = "deleteSongButton";
            this.deleteSongButton.Size = new System.Drawing.Size(44, 22);
            this.deleteSongButton.Text = "Delete";
            this.deleteSongButton.Click += new System.EventHandler(this.deleteSongButton_Click);
            // 
            // listViewBase
            // 
            this.listViewBase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewBase.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnAuthor,
            this.columnDate,
            this.columnGenre});
            this.listViewBase.Location = new System.Drawing.Point(0, -3);
            this.listViewBase.Name = "listViewBase";
            this.listViewBase.Size = new System.Drawing.Size(341, 347);
            this.listViewBase.TabIndex = 1;
            this.listViewBase.UseCompatibleStateImageBehavior = false;
            this.listViewBase.View = System.Windows.Forms.View.Details;
            this.listViewBase.Enter += new System.EventHandler(this.listViewBase_Enter);
            this.listViewBase.Leave += new System.EventHandler(this.listViewBase_Leave);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            // 
            // columnAuthor
            // 
            this.columnAuthor.Text = "Author";
            // 
            // columnDate
            // 
            this.columnDate.Text = "Date";
            // 
            // columnGenre
            // 
            this.columnGenre.Text = "Genre";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ElementCountLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 325);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(341, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // ListViewFilterButton
            // 
            this.ListViewFilterButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListViewFilterButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noFilterToolStripMenuItem,
            this.notAfter2000ToolStripMenuItem,
            this.after2000ToolStripMenuItem});
            this.ListViewFilterButton.Image = ((System.Drawing.Image)(resources.GetObject("ListViewFilterButton.Image")));
            this.ListViewFilterButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ListViewFilterButton.Name = "ListViewFilterButton";
            this.ListViewFilterButton.Size = new System.Drawing.Size(46, 22);
            this.ListViewFilterButton.Text = "Filter";
            // 
            // noFilterToolStripMenuItem
            // 
            this.noFilterToolStripMenuItem.Name = "noFilterToolStripMenuItem";
            this.noFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.noFilterToolStripMenuItem.Text = "No filter";
            this.noFilterToolStripMenuItem.Click += new System.EventHandler(this.noFilterToolStripMenuItem_Click);
            // 
            // notAfter2000ToolStripMenuItem
            // 
            this.notAfter2000ToolStripMenuItem.Name = "notAfter2000ToolStripMenuItem";
            this.notAfter2000ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.notAfter2000ToolStripMenuItem.Text = "Not After 2000";
            this.notAfter2000ToolStripMenuItem.Click += new System.EventHandler(this.notAfter2000ToolStripMenuItem_Click);
            // 
            // after2000ToolStripMenuItem
            // 
            this.after2000ToolStripMenuItem.Name = "after2000ToolStripMenuItem";
            this.after2000ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.after2000ToolStripMenuItem.Text = "After 2000";
            this.after2000ToolStripMenuItem.Click += new System.EventHandler(this.after2000ToolStripMenuItem_Click);
            // 
            // ElementCountLabel
            // 
            this.ElementCountLabel.Name = "ElementCountLabel";
            this.ElementCountLabel.Size = new System.Drawing.Size(13, 17);
            this.ElementCountLabel.Text = "0";
            // 
            // ListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 347);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.listViewBase);
            this.Controls.Add(this.listViewToolStrip);
            this.Name = "ListView";
            this.Text = "ListView";
            this.Load += new System.EventHandler(this.ListView_Load);
            this.listViewToolStrip.ResumeLayout(false);
            this.listViewToolStrip.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip listViewToolStrip;
        private System.Windows.Forms.ToolStripButton addSongButton;
        private System.Windows.Forms.ListView listViewBase;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnAuthor;
        private System.Windows.Forms.ColumnHeader columnDate;
        private System.Windows.Forms.ColumnHeader columnGenre;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton editSongButton;
        private System.Windows.Forms.ToolStripButton deleteSongButton;
        private System.Windows.Forms.ToolStripDropDownButton ListViewFilterButton;
        private System.Windows.Forms.ToolStripMenuItem noFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notAfter2000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem after2000ToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel ElementCountLabel;
    }
}