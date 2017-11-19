using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicLibrary
{
    public partial class GenrePicker : PictureBox
    {
        private static Image rockImage = Resource1.rock, popImage = Resource1.pop, rapImage = Resource1.rap;
        private static Image[] genres = { rockImage, popImage, rapImage };
        public enum genre { rock, pop, rap };
        public event EventHandler RaiseEditEvent;

        protected virtual void OnRaiseEditEvent()
        {
            EventHandler handler = RaiseEditEvent;
            if (handler != null)
            {
                handler(this, null);
            }
        }

        private genre CurrentGenre;
        [Editor(typeof(GenreEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [Category("Genre")]
        [Browsable(true)]
        public genre Genre
        {
            get { return CurrentGenre; }
            set
            {
                this.CurrentGenre = value;
                this.Image = genres[(int)this.CurrentGenre];
                OnRaiseEditEvent();
            }
        }

        public GenrePicker(genre g)
        {
            InitializeComponent();
            this.Size = new Size(64, 64);
            this.Genre = g;
            this.Click += GenrePickerClicked;
        }

        public GenrePicker() : this(genre.rock) { }
        

        private void GenrePickerClicked(object sender, EventArgs e)
        {
            this.Genre = (genre)(((int)this.Genre + 1) % 3);
        }

        public override string ToString()
        {
            return Genre.ToString();
        }

        public void Set(String genreString)
        {
            genre result;
            if(Enum.TryParse<genre>(genreString, out result))
            {
                this.Genre = result;
            }
            
        }
    }
}
