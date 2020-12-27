using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

public class NoteService
{
    public List<Note> notes { get; set; }
	public NoteService()
	{
        notes = new List<Note>();
	}
    public NoteService(List<Note> notes)
    {
        this.notes = notes;
    }

    public void load_notes()
    {
        string jsonFile = File.ReadAllText("notes.json");
        notes = JsonConvert.DeserializeObject<List<Note>>(jsonFile);

    }

    public void save_notes()
    {
        //serialize notes
        string jsonFile = JsonConvert.SerializeObject(notes);
        //save the notes
        Console.WriteLine(notes);
        File.WriteAllText("notes.json", jsonFile);
    }

    public void add_note(Note note)
    {
        if (notes != null)
        {
            foreach (Note i in notes)
            {
                //if the ID's are the same, it replaces the info from the 
                if (i.ID.Equals(note.ID))
                {
                    notes.Remove(i);
                    break;
                }

            }
            notes.Add(note);
        }
        else
        {
            notes = new List<Note>();
            notes.Add(note);
        }
    }

    public void remove_note(Note note)
    {
        if (notes != null)
        {
            foreach (Note i in notes)
            {
                //if the ID's are the same, it replaces the info from the 
                if (i.ID.Equals(note.ID))
                {
                    notes.Remove(i);
                    break;
                }

            }
        }
        else
        {
        }
    }
}
