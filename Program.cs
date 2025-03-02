Console.Write("Enter the account holder's name: ");
string holder = Console.ReadLine();

Console.Write("Enter the initial balance: ");
decimal initBalance = Convert.ToDecimal(Console.ReadLine());

Account bank = new Account(holder, initBalance);

while (true)
{
  Console.WriteLine("\n1 - Deposit\n2 - Withdraw\n3 - View Balance\n4 - View History\n5 - Exit");
  string option = Console.ReadLine();

  switch (option)
  {
    case "1":
      Console.Write("Deposit amount: ");
      decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
      bank.Deposit(depositAmount);
      break;
    case "2":
      Console.Write("Withdrawal amount: ");
      decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
      bank.Withdraw(withdrawAmount);
      break;
    case "3":
      bank.ShowBalance();
      break;
    case "4":
      bank.ShowHistory();
      break;
    case "5":
      Console.WriteLine("Exiting the program...");
      return;
    default:
      Console.WriteLine("Invalid option.");
      break;
  }
}