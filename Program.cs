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

    UserManager userManager = new UserManager();

    User user1 = new User(1, "John", "Doe", new DateTime(1980, 1, 1, 0, 0, 0, DateTimeKind.Utc), "123 Main St");
    userManager.AddUser("1", user1);
    Account account1 = new Account(1, 1000m, "Active", "USD");
    Account account2 = new Account(2, 3000m, "Active", "USD");
    userManager.AddAccountToUser("1", account1);
    userManager.AddAccountToUser("1", account2);
    List<Account> user1Accounts = userManager.GetUserAccounts("1");
    
    Console.WriteLine(" ");
    Console.WriteLine("User and account: ");
    Console.WriteLine($"User {user1.Name} has {user1Accounts.Count} account(s).");
  }
}
