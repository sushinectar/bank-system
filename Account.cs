public class Account
{
  public string Holder { get; private set; }
  public decimal Balance { get; private set; }
  private List<string> History = new List<string>();

  public Account(string initHolder, decimal initBalance)
  {
    Holder = initHolder;
    Balance = initBalance;
    History.Add($"Account created for {Holder} with initial balance of R{Balance:C}");
  }

  public void Deposit(decimal value)
  {
    if (value <= 0)
    {
      Console.WriteLine("The deposit amount must be positive.");
    }
    else
    {
      Balance += value;
      History.Add($"Deposit: R{value:C}");
    }
  }

  public void Withdraw(decimal value)
  {
    if (value <= 0)
    {
      Console.WriteLine("The withdrawal amount must be positive.");
    }
    else if (value > Balance)
    {
      Console.WriteLine("Insufficient balance for withdrawal.");
    }
    else
    {
      Balance -= value;
      History.Add($"Withdrawal: R{value:C}");
    }
  }

  public void ShowBalance()
  {
    Console.WriteLine($"Current balance: R{Balance:C}");
  }

  public void ShowHistory()
  {
    Console.WriteLine("\nTransaction history:");
    foreach (var item in History)
    {
      Console.WriteLine(item);
    }
  }
}