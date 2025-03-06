public class Account
{
  public string Holder { get; private set; }
  public decimal Balance { get; private set; }
  private List<string> History = new List<string>();

  public Account(string initHolder, decimal initBalance)
  {
    Holder = initHolder;
    Balance = initBalance;
    History.Add($"Account created for {Holder} with initial balance of R{Balance:C} \n");
  }

  public void Deposit(decimal value)
  {
    if (value <= 0)
    {
      Console.WriteLine("The deposit amount must be positive. \n");
    }
    else
    {
      Balance += value;
      History.Add($"Deposit: R{value:C} \n");
      Console.Clear();
      Console.WriteLine($"Deposit of {value:C} successful! \n");
    }
  }

  public void Withdraw(decimal value)
  {
    if (value <= 0)
    {
      Console.WriteLine("The withdrawal amount must be positive. \n");
    }
    else if (value > Balance)
    {
      Console.WriteLine("Insufficient balance for withdrawal. \n");
    }
    else
    {
      Balance -= value;
      History.Add($"Withdrawal: R{value:C}\n");
      Console.Clear();
      Console.WriteLine($"Withdraw of {value:C} successful! \n");
    }
  }

  public void ShowBalance()
  {
    Console.WriteLine("\n---------------------------------------------------------\n");
    Console.WriteLine($"Current balance: R{Balance:C} \n");
    Console.WriteLine("---------------------------------------------------------\n");
  }

  public void ShowHistory()
  {
    Console.WriteLine("\n---------------------------------------------------------\n");
    Console.WriteLine("Transaction history: \n");
    foreach (var item in History)
    {
      Console.WriteLine(item);
    }
    Console.WriteLine("---------------------------------------------------------\n");
  }
}
