namespace LanguagesTask;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public DateTime Birthday { get; set; }
    public string Address { get; set; }
    
    public User(int id, string name, string lastName, DateTime birthday, string address)
    {
        Id = id; //int
        Name = name; //string
        this.LastName = lastName; //string
        this.Birthday = birthday; //DateTime
        this.Address = address; //string
    }
}
