using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLCMilestone
{
    public partial class DeleteConfirmation : Form
    {
        //Note and NoteService classes 
        private Note note;
        private NoteService service;

        public DeleteConfirmation(NoteService service, Note note)
        {
            InitializeComponent();
            //use the passed in note and note service
            this.note = note;
            this.service = service;


        }

        private void DeleteConfirmation_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            //Event handler for the note being deleted


            service.remove_note(note);
            service.save_notes();
            //MessageBox.Show("Note Deleted");
            this.Hide();


            // Direct to Main note page
            MainNotePage DirectToMainNotePage = new MainNotePage(service);
            DirectToMainNotePage.Show();
            this.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            MainNotePage DirectToMainNotePage2 = new MainNotePage(service);
            DirectToMainNotePage2.Show();
            this.Visible = false;
        }
    }
}

