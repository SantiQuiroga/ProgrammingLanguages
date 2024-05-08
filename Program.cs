namespace LanguagesTask;

public static class Program
{
  public static void Main(string[] args)
  {
    ComplexNum a = new ComplexNum(3, 4);
    ComplexNum b = new ComplexNum(5, 6);

    ComplexNum sum = a + b;
    ComplexNum difference = a - b;
    bool areEqual = a.Equals(b);

    Console.WriteLine("Complex number: ");
    Console.WriteLine("Sum: " + sum.ToString());
    Console.WriteLine("Difference: " + difference.ToString());
    Console.WriteLine("Are 'a' and 'b' equal? " + areEqual);
      
    int[] array = {1, 2, 3, 4, 5};
    int positions = 2;
    int[] rotatedArray = Rotation.RotateArray(array, positions);

    Console.WriteLine(" ");
    Console.WriteLine("Rotated array: ");
    Console.WriteLine(string.Join(", ", rotatedArray));

    Coordinates coords = new Coordinates(40.7128, -74.0060);

    Console.WriteLine(" ");
    Console.WriteLine("Coordinates: ");
    Console.WriteLine(coords.ToString());

    Dictionary<string, object> user1 = new Dictionary<string, object>
    {
      { "Id", 1 },
      { "Name", "John" },
      { "LastName", "Doe" },
      { "Birthday", new DateTime(1980, 1, 1, 0, 0, 0, DateTimeKind.Utc) },
      { "Address", "123 Main St" }
    };
    
    Dictionary<string, object> account1 = new Dictionary<string, object>
    {
        { "Id", 1 },
        { "Amount", 1000m },
        { "Status", "Active" },
        { "Currency", "USD" }
    };

    Dictionary<string, object> account2 = new Dictionary<string, object>
    {
        { "Id", 2 },
        { "Amount", 2000m },
        { "Status", "Active" },
        { "Currency", "EUR" }
    };

    Dictionary<Dictionary<string, object>, List<Dictionary<string, object>>> userAccounts = 
        new Dictionary<Dictionary<string, object>, List<Dictionary<string, object>>>
    {
        { user1, new List<Dictionary<string, object>> { account1, account2 } }
    };
    
    Console.WriteLine(" ");
    Console.WriteLine("User accounts:");

    foreach (var userAccount in userAccounts)
    {

        Console.WriteLine("User:");
        Console.WriteLine(" ");

        foreach (var userDetail in userAccount.Key)
        {
            Console.WriteLine($"{userDetail.Key}: {userDetail.Value}");
        }

        Console.WriteLine(" ");
        Console.WriteLine("Accounts:");
        Console.WriteLine(" ");

        foreach (var account in userAccount.Value)
        {
            foreach (var accountDetail in account)
            {
                Console.WriteLine($"{accountDetail.Key}: {accountDetail.Value}");
            }
            Console.WriteLine(" ");
        }
    }
  }
}
