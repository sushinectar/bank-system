class Program
{
  static List<Account> accounts = new List<Account>();

  static void Main(string[] args)
  {
    while (true)
    {
      Console.Clear();
      Console.WriteLine("SUSHI BANK\n");
      Console.WriteLine("1 - Register Account\n2 - Manage Accounts\n3 - Exit");
      Console.Write("\nChoose an option: ");
      string menuOption = Console.ReadLine();
      Console.Clear();

      switch (menuOption)
      {
        case "1":
          RegisterAccount();
          break;

        case "2":
          ManageAccounts();
          break;

        case "3":
          Console.WriteLine("Exiting the program...");
          return;

        default:
          Console.WriteLine("Invalid option.");
          break;
      }
    }
  }

  static void RegisterAccount()
  {
    Console.Write("Enter the account holder's name: ");
    string holder = Console.ReadLine();
    Console.Write("Enter the initial balance: ");
    decimal initBalance = Convert.ToDecimal(Console.ReadLine());
    Console.Clear();

    Account newAccount = new Account(holder, initBalance);
    accounts.Add(newAccount);
    Console.WriteLine($"Account for {holder} registered successfully! \n");
  }

  static void ManageAccounts()
  {
    if (accounts.Count == 0)
    {
      Console.WriteLine("No accounts registered yet. \n");
      return;
    }

    Console.WriteLine("Registered Accounts: \n");
    for (int i = 0; i < accounts.Count; i++)
    {
      Console.WriteLine($"{i + 1} - {accounts[i].Holder}");
    }

    Console.Write("\nChoose an account to manage (enter the number): ");
    if (int.TryParse(Console.ReadLine(), out int choice) && choice > 0 && choice <= accounts.Count)
    {
      Account selectedAccount = accounts[choice - 1];
      ManageAccount(selectedAccount);
    }
    else
    {
      Console.WriteLine("Invalid choice.");
    }
  }

  static void ManageAccount(Account account)
  {
    Console.Clear();
    while (true)
    {
      Console.WriteLine($"Managing account of {account.Holder} \n");
      Console.WriteLine("1 - Deposit\n2 - Withdraw\n3 - Show Balance\n4 - Show History\n5 - Back to Main Menu");
      Console.Write("\nChoose an option: ");
      string option = Console.ReadLine();

      switch (option)
      {
        case "1":
          Console.Clear();
          Console.Write("Enter the deposit amount: ");
          decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
          account.Deposit(depositAmount);
          break;

        case "2":
          Console.Clear();
          Console.Write("Enter the withdrawal amount: ");
          decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
          account.Withdraw(withdrawAmount);
          break;

        case "3":
          Console.Clear();
          account.ShowBalance();
          break;

        case "4":
          Console.Clear();
          account.ShowHistory();
          break;

        case "5":
          Console.Clear();
          return;

        default:
          Console.Clear();
          Console.WriteLine("Invalid option.");
          break;
      }
    }
  }
}
