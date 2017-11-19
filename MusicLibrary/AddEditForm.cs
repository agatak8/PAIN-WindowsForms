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
    public partial class AddEditForm : Form
    {
        private void genrePickerEdited(object sender, EventArgs e)
        {
            this.genreTextBox.Text = this.genrePicker1.ToString();
        }

        public AddEditForm()
        {
            InitializeComponent();
            this.genreTextBox.Text = this.genrePicker1.ToString();
            this.genrePicker1.RaiseEditEvent += genrePickerEdited;
        }

        public void setValues(String title, String author, DateTime date, String genre)
        {
            this.titleTextBox.Text = title;
            this.authorTextBox.Text = author;
            this.datePicker.Value = date;
            this.genrePicker1.Set(genre);
        }

        public void setToSong(Song song)
        {
            this.titleTextBox.Text = song.Title;
            this.authorTextBox.Text = song.Author;
            this.datePicker.Value = song.Date;
            this.genrePicker1.Set(song.Genre);
        }

        private void enterSongCancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void enterSongOKButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren()) this.DialogResult = DialogResult.OK;
        }

        private void titleTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.titleTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(titleTextBox, "Title can't be empty");
            }
        }

        private void authorTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (this.authorTextBox.Text.Length == 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(authorTextBox, "Author can't be empty");
            }
        }

        private void datePicker_Validating(object sender, CancelEventArgs e)
        {
            if (this.datePicker.Value > DateTime.Now)
            {
                e.Cancel = true;
                errorProvider1.SetError(datePicker, "Date can't be in the future");
            }
        }

        private void titleTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(titleTextBox, "");
        }

        private void authorTextBox_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(authorTextBox, "");
        }

        private void datePicker_Validated(object sender, EventArgs e)
        {
            errorProvider1.SetError(datePicker, "");
        }
    }
}
