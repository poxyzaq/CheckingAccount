namespace CheckingAccount.ConsoleApp
{
    class MainScreen
    {
        public string DisplayMenuOptions(CheckingAccount loggedAccount)
        {
            Console.Clear();
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Conta Corrente #{loggedAccount.id} de {loggedAccount.name}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1 - Withdrawal");
            Console.WriteLine("2 - Deposit");
            Console.WriteLine("3 - Transfer");
            Console.WriteLine("4 - Check balance");
            Console.WriteLine("E - Exit");
            Console.WriteLine("-------------------------------------");
            Console.Write("Enter a valid option > ");
            string menuOption = Console.ReadLine()?.ToUpper();

            return menuOption;
        }

        public void DisplayWithdrawOperation(CheckingAccount loggedAccount)
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("Enter the amout to be withdrawn (U$) > ");
            decimal withdrawalAmount= Convert.ToDecimal(Console.ReadLine());

            bool withdrew = loggedAccount.Withdraw(withdrawalAmount);

            if (!withdrew)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("The debit limit has been exceeded!");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("The amount was succesfully withdrawn!");
            }

            Console.WriteLine("-------------------------------------");
            Console.Write("Press RETURN to continue...");
            Console.ReadLine();
        }

        public void DisplayDepositOperation(CheckingAccount loggedAccount)
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("Enter the value to be deposited (U$) > ");
            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());

            loggedAccount.Deposit(depositAmount);

            Console.WriteLine("-------------------------------------");
            Console.WriteLine("The amount was succesfully deposited!");
            Console.WriteLine("-------------------------------------");
            Console.Write("Press RETURN to continue...");
            Console.ReadLine();
        }

        public void DisplayTransferOperation(CheckingAccount loggedAccount, CheckingAccount targetAccount)
        {
            Console.WriteLine("-------------------------------------");
            Console.Write("Enter the value to be transfered (U$) > ");
            decimal transferAmount = Convert.ToDecimal(Console.ReadLine());

            bool didTransfer = loggedAccount.TransferTo(targetAccount, transferAmount);

            if (!didTransfer)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"We were unable to transfer the amount of U${transferAmount}!");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine($"The amount of U${transferAmount} was succesfully transfered");
            }

            Console.WriteLine("-------------------------------------");
            Console.Write("Press RETURN to continue...");
            Console.ReadLine();
        }

        public void DisplayGetAmountsOperation(CheckingAccount loggedAccount)
        {
            decimal currentBalance = loggedAccount.GetBalance();
            decimal currentLimit = loggedAccount.GetLimit();

            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"The account balance is U${currentBalance}");
            Console.WriteLine($"The account limit is U${currentLimit}");
            Console.WriteLine("-------------------------------------");
            Console.Write("Press RETURN to continue...");
            Console.ReadLine();
        }
    }
}
