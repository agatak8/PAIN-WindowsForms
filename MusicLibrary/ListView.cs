using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class ListView : Form
    {
        private SongList model;
        private delegate bool Filter(Song song);
        private Filter _filter;
        private Filter filter
        {
            get
            {
                return this._filter;
            }
            set
            {
                this._filter = value;
                this.RefreshAll();
            }
        }
        private bool NoFilter(Song song)
        {
            return true;
        }
        private bool FilterBefore2000(Song song)
        {
            return (song.Date.Year <= 2000);
        }
        private bool FilterAfter2000(Song song)
        {
            return (song.Date.Year > 2000);
        }
        public ToolStrip toolStrip
        {
            get { return this.listViewToolStrip; }
        }
        public ListView(SongList model)
        {
            InitializeComponent();
            this._filter = NoFilter;
            this.model = model;
            model.RaiseAddEvent += HandleAddEvent;
            model.RaiseDeleteEvent += HandleDeleteEvent;
            model.RaiseEditEvent += HandleEditEvent;
        }

        private void RefreshAll()
        {
            this.listViewBase.Items.Clear();
            foreach(Song song in this.model)
            {
                if(filter(song))
                {
                    AddSongItem(song);
                }
            }
            this.ElementCountLabel.Text = this.listViewBase.Items.Count.ToString();
        }

        private void UpdateItem(ListViewItem item)
        {
            Song song = (Song)item.Tag;
            while (item.SubItems.Count < 4)
                item.SubItems.Add(new ListViewItem.ListViewSubItem());
            item.SubItems[0].Text = song.Title;
            item.SubItems[1].Text = song.Author;
            item.SubItems[2].Text = song.Date.ToShortDateString();
            item.SubItems[3].Text = song.Genre;
        }

        private void AddSongItem(Song song)
        {
            ListViewItem item = new ListViewItem();
            item.Tag = song;
            UpdateItem(item);
            this.listViewBase.Items.Add(item);
            this.ElementCountLabel.Text = this.listViewBase.Items.Count.ToString();
        }

        private ListViewItem FindListViewItem(Song s)
        {
            foreach(ListViewItem item in this.listViewBase.Items)
            {
                if((Song)item.Tag == s)
                {
                    return item;
                }
            }
            return null;
        }

        private void HandleAddEvent(object sender, SongEventArgs e)
        {
            if(filter(e.Song))
            {
                AddSongItem(e.Song);
            }
        }

        private void HandleEditEvent(object sender, SongEventArgs e)
        {
            ListViewItem item = FindListViewItem(e.Song);
            if(filter(e.Song))
            {
                if(item != null)
                {
                    UpdateItem(item);
                }
                else
                {
                    AddSongItem(e.Song);
                }
            }
            else
            {
                if(item != null)
                {
                   this.listViewBase.Items.Remove(item);
                }
            }
            
        }

        private void HandleDeleteEvent(object sender, SongEventArgs e)
        {
            ListViewItem item = FindListViewItem(e.Song);
            if(item != null)
            {
               this.listViewBase.Items.Remove(item);
               this.ElementCountLabel.Text = this.listViewBase.Items.Count.ToString();
            }
        }

        private void addSongButton_Click(object sender, EventArgs e)
        {
            MDIForm parent = (MDIForm)this.MdiParent;
            parent.AddSong();
        }

        private void editSongButton_Click(object sender, EventArgs e)
        {
            if (this.listViewBase.SelectedItems.Count == 1)
            {
                MDIForm parent = (MDIForm)this.MdiParent;
                Song s = (Song)this.listViewBase.SelectedItems[0].Tag;
                parent.EditSong(s);
            }
        }

        private void deleteSongButton_Click(object sender, EventArgs e)
        {
            if (this.listViewBase.SelectedItems.Count == 1)
            {
                MDIForm parent = (MDIForm)this.MdiParent;
                Song s = (Song)this.listViewBase.SelectedItems[0].Tag;
                parent.DeleteSong(s);
            }
        }

        private void ListView_Load(object sender, EventArgs e)
        {
            foreach(Song song in this.model)
            {
                ListViewItem item = new ListViewItem();
                item.Tag = song;
                UpdateItem(item);
                this.listViewBase.Items.Add(item);
            }
        }

        private void listViewBase_Enter(object sender, EventArgs e)
        {
            ToolStripManager.Merge(this.toolStrip, ((MDIForm)this.MdiParent).toolStrip);
            ToolStripManager.Merge(this.statusStrip1, ((MDIForm)this.MdiParent).statusStrip);
        }

        private void listViewBase_Leave(object sender, EventArgs e)
        {
            ToolStripManager.RevertMerge(((MDIForm)this.MdiParent).toolStrip, this.toolStrip);
            ToolStripManager.RevertMerge(((MDIForm)this.MdiParent).statusStrip, this.statusStrip1);
        }


        private void noFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.filter = NoFilter;
        }

        private void notAfter2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.filter = FilterBefore2000;
        }

        private void after2000ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.filter = FilterAfter2000;
        }
    }
}
