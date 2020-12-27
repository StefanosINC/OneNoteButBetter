using System;

[Serializable]
public class Note 
{
    //Every note should be able to store a title, date, message content, and date created
    public Guid ID { get; set; }
    public String title;
    public DateTime date;
    public DateTime date_created;
    public String message;
    
	public Note()
	{
        title = "Note Title";
        message = "";
        date = DateTime.Now;
        date_created = DateTime.Now;
        ID = System.Guid.NewGuid();
	}
    public Note(String title, String message, DateTime date, DateTime date_created)
    {
        this.title = title;
        this.message = message;
        this.date = date;
        this.date_created = date_created;
        ID = System.Guid.NewGuid();
    }

    public String get_title()
    {
        return this.title; 
    }
    public void set_title(String title)
    {
        this.title = title;
    }
    public String get_message()
    {
        return this.message;
    }
    public void set_message(String message)
    {
        this.message = message;
    }
    public DateTime get_date()
    {
        return this.date;
    }
    public void set_date(DateTime date)
    {
        this.date = date;
    }
    public DateTime get_date_created()
    {
        return this.date_created;
    }
    public void set_date_created(DateTime date_created)
    {
        this.date_created = date_created;
    }

    public override string ToString()
    {
        return this.title;
    }

}
