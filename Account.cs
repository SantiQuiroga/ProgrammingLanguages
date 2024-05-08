namespace LanguagesTask;

public class Account
{
    
    public int Id { get; set; }
    public decimal Amount { get; set; }
    public string Status { get; set; }
    public string Currency { get; set; }
    
    public Account(int id, decimal amount, string status, string currency)
    {
        Id = id; //int
        Amount = amount; //decimal
        Status = status; //string
        Currency = currency; //string
    }
}
