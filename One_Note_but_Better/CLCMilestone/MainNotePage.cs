using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLCMilestone
{
    public partial class MainNotePage : Form
    {

        public NoteService service;
        private List<String> sort_methods = new List<string>() { "None", "Title", "Date", "Date Created" };
        private List<Note> ordered_notes = new List<Note>();
        int indexNote = 0;
        public MainNotePage(NoteService service)
        {
            InitializeComponent();
            this.service = service;
            notes_list.DataSource = service.notes;
            notes_list.DisplayMember = "title";
            sort_type.DataSource = sort_methods;
            
         
        }

        private void btn_NewNote_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
        }
        void notes_list_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = this.notes_list.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                MessageBox.Show(index.ToString());
            }
        }

        private void notes_list_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index = this.notes_list.IndexFromPoint(e.Location);
            if (index != System.Windows.Forms.ListBox.NoMatches)
            {
                NewNote edit_note = new NewNote(service, service.notes[index]);
                edit_note.Show();
                this.Close();
            }
        }

        // Test to delete the note off a single click
        private void notes_list_MouseClick(object sender, MouseEventArgs e)
        {
            
            int indexNote= this.notes_list.IndexFromPoint(e.Location);
          
        }




       










        private void MainNotePage_Load(object sender, EventArgs e)
        {

        }

        private void Notepad_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_BackIcon_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            //this.Hide();
            home.Show();
            this.Visible = false;



        }

        private void NewNoteIconbtn_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
            this.Visible = false;
        }

        private void btn_DeleteNote_Click(object sender, EventArgs e)
        {
            //   DeleteConfirmation deletePage = new DeleteConfirmation(service);
            //    deletePage.Show();
            //     this.Visible = false;
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            // Organize the Lists from A-Z order

            //Console.WriteLine(sort_type.Text);

            //Sorting the list based on sort method
            switch (sort_type.Text)
            {

                case "Title":
                    ordered_notes = this.service.notes.OrderBy(o => o.title).ToList();
                    break;
                case "Date":
                    ordered_notes = this.service.notes.OrderBy(o => o.date).ToList();
                    break;
                case "Date Created":
                    ordered_notes = this.service.notes.OrderBy(o => o.date_created).ToList();
                    break;
                default:
                    ordered_notes = service.notes;
                    break;

            }
            notes_list.DataSource = ordered_notes;
            notes_list.DisplayMember = "title";
        }

        private void sort_type_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        // New delete
        private void iconButton1_Click(object sender, EventArgs e)
        {
            DeleteConfirmation deleteForm = new DeleteConfirmation(service, service.notes[indexNote]);
            this.Hide();
            deleteForm.Show();
        }

   
    }
}