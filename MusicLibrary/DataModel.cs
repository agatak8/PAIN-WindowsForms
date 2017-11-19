using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicLibrary
{
    public class Song
    {
        public event EventHandler RaiseEditEvent;

        // this event informs subscribers that a field was edited
        protected virtual void OnRaiseEditEvent()
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            EventHandler handler = RaiseEditEvent;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Use the () operator to raise the event.
                handler(this, null);
            }
        }
        private String title;
        private String author;
        private DateTime date;
        private String genre;

        public String Title
        {
            get { return title; }
        }
        public String Author
        {
            get { return author; }
        }
        public DateTime Date
        {
            get { return date; }
        }
        public String Genre
        {
            get { return genre; }
        }

        public void SetValues(String title, String author, DateTime date, String genre)
        {
            this.title = title;
            this.author = author;
            this.date = date;
            this.genre = genre;
            OnRaiseEditEvent();
        }

        public Song(String title, String author, DateTime date, String genre)
        {
            this.title = title;
            this.author = author;
            this.date = date;
            this.genre = genre;
        }

    }

    public class SongEventArgs : EventArgs
    {
        private Song song;
        public SongEventArgs(Song song)
        {
            this.song = song;
        }
        public Song Song
        {
            get
            {
                return this.song;
            }
        }
    }

    public class SongList : IEnumerable<Song>
    {
        public delegate void SongEventHandler(object sender, SongEventArgs args);
        public event SongEventHandler RaiseAddEvent;
        public event SongEventHandler RaiseDeleteEvent;
        public event SongEventHandler RaiseEditEvent;

        private List<Song> data;

        public SongList()
        {
            data = new List<Song>();
        }
        public void AddSong(String title, String author, DateTime date, String genre)
        {
            Song s = new MusicLibrary.Song(title, author, date, genre);
            s.RaiseEditEvent += HandleElementEditEvent;
            data.Add(s);
            OnRaiseSongEvent(s, RaiseAddEvent);
        }

        public Song this[int i]
        {
            get { return data[i]; }
        }

        public void Remove(Song item)
        {
            OnRaiseSongEvent(item, RaiseDeleteEvent);
            data.Remove(item);
        }

        // the SongList subscribes to every Song element
        // when the Song element sends an edit event
        // we send our own edit element with the Song as an arg
        void HandleElementEditEvent(object sender, EventArgs e)
        {
            Song s = (Song)sender;
            OnRaiseSongEvent(s, RaiseEditEvent);
        }

        // method for sending all 3 types of events
        // SongEventHandler should be RaiseAddEvent, RaiseEditEvent or RaiseDeleteEvent
        protected virtual void OnRaiseSongEvent(Song song, SongEventHandler h)
        {
            // Make a temporary copy of the event to avoid possibility of
            // a race condition if the last subscriber unsubscribes
            // immediately after the null check and before the event is raised.
            SongEventHandler handler = h;

            // Event will be null if there are no subscribers
            if (handler != null)
            {
                // Use the () operator to raise the event.
                handler(this, new SongEventArgs(song));
            }
        }

        public IEnumerator<Song> GetEnumerator()
        {
            return data.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
