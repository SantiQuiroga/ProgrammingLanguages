namespace LanguagesTask;

public class UserManager
{
    private readonly Dictionary<string, User> users = new Dictionary<string, User>();
    private readonly Dictionary<User, List<Account>> userAccounts = new Dictionary<User, List<Account>>();

    public void AddUser(string id, User user)
    {
        users[id] = user;
    }

    public void AddAccountToUser(string userId, Account account)
    {
        User user = users[userId];

        if (userAccounts.ContainsKey(user))
        {
            userAccounts[user].Add(account);
        }
        else
        {
            userAccounts[user] = new List<Account> { account };
        }
    }

    public List<Account> GetUserAccounts(string userId)
    {
        User user = users[userId];

        if (userAccounts.ContainsKey(user))
        {
            return userAccounts[user];
        }
        else
        {
            return new List<Account>();
        }
    }
}
