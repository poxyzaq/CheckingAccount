using System.Security.Cryptography;

namespace CheckingAccount.ConsoleApp
{
    class Program
    {
        static void Main()
        {
            CheckingAccount account1 = new();
            account1.id = Convert.ToHexString(RandomNumberGenerator.GetBytes(20))
                .Substring(0, 7)
                .ToLower();
            account1.name = "Apollo";
            account1.debitLimit = 200;
            account1.totalBalance = 400;

            CheckingAccount account2 = new();
            account2.id = Convert.ToHexString(RandomNumberGenerator.GetBytes(20))
                .Substring(0, 7)
                .ToLower();
            account2.name = "Luna";
            account2.debitLimit = 40;
            account2.totalBalance = 1200;

            do 
            {
                MainScreen mainScreen = new();
                string menuOption = mainScreen.DisplayMenuOptions(account1);

                switch (menuOption)
                {
                    case "1":
                        mainScreen.DisplayWithdrawOperation(account1);
                        break;

                    case "2":
                        mainScreen.DisplayDepositOperation(account1);
                        break;

                    case "3":
                        mainScreen.DisplayTransferOperation(account1, account2);
                        break;

                    case "4":
                        mainScreen.DisplayGetAmountsOperation(account1);
                        break;
                }

            } while (true);
        }
    }
}

