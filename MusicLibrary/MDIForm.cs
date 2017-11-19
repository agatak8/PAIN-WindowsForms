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
    public partial class MDIForm : Form
    {
        private List<ListView> views;
        private SongList model;
        public ToolStrip toolStrip
        {
            get { return this.MDIToolStrip; }
        }
        public StatusStrip statusStrip
        {
            get { return this.MDIStatusStrip; }
        }
        public MDIForm(SongList model)
        {
            this.model = model;
            views = new List<ListView>();
            InitializeComponent();
        }

        private void ChildFormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.views.Count <= 1 && e.CloseReason != CloseReason.MdiFormClosing) e.Cancel = true;
            else views.Remove((ListView)sender);
        }


        public void DeleteSong(Song song)
        {
            model.Remove(song);
        }

        public void AddSong()
        {
            AddEditForm f = new AddEditForm();
            if(f.ShowDialog() == DialogResult.OK)
            {
                model.AddSong(f.titleTextBox.Text, f.authorTextBox.Text, f.datePicker.Value, f.genrePicker1.ToString());
            }
        }

        public void EditSong(Song song)
        {
            AddEditForm f = new AddEditForm();
            f.setToSong(song);
            if(f.ShowDialog() == DialogResult.OK)
            {
                song.SetValues(f.titleTextBox.Text, f.authorTextBox.Text, f.datePicker.Value, f.genrePicker1.ToString());
            }
        }

        private void newViewButton_Click(object sender, EventArgs e)
        {
            ListView view = new ListView(model);
            view.MdiParent = this;
            view.FormClosing += ChildFormClosing;
            views.Add(view);
            view.Show();
        }

        private void MDIForm_Load(object sender, EventArgs e)
        {
            ListView view = new ListView(model);
            view.MdiParent = this;
            view.FormClosing += ChildFormClosing;
            views.Add(view);
            view.Show();
        }
    }
}
