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
    public partial class Home : Form
    {
        NoteService service = new NoteService();
        public Home()
        {
            InitializeComponent();
            service.load_notes();
            //Console.WriteLine(System.Guid.NewGuid());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_calandar_Click(object sender, EventArgs e)
        {
            MainNotePage notesHome = new MainNotePage(service);
            //this.Hide();
            notesHome.Show();
        }

        private void btn_calendar_Click(object sender, EventArgs e)
        {
          //  btn_calendar1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            ViewCalender calender = new ViewCalender(service);
            calender.Show();
            this.Visible = false;
        }

        private void btn_calendar_Click_1(object sender, EventArgs e)
        {
          //  btn_calendar1.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            ViewCalender calender = new ViewCalender(service);
            calender.Show();
            this.Visible = false;
        }

        private void btn_calandar_Click_1(object sender, EventArgs e)
        {
            MainNotePage notesHome = new MainNotePage(service);
            //this.Hide();
            notesHome.Show();
            this.Visible = false;
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            Note new_note = new Note();
            NewNote note_page = new NewNote(service, new_note);
            note_page.Show();
            this.Visible = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
