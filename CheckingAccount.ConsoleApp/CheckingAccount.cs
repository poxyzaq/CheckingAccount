namespace CheckingAccount.ConsoleApp
{
    public class CheckingAccount
    {
        public string id;
        public string name;
        public decimal totalBalance;
        public decimal debitLimit;

        public bool Withdraw(decimal amount)
        {
            decimal withdrawalLimit = 
                totalBalance + debitLimit;

            if (withdrawalLimit >= amount)
            {
                totalBalance -= amount;
                return true;
            }

            return false;
        }

        public void Deposit(decimal amount)
        {
            totalBalance += amount;
        }

        public decimal GetBalance()
        {
            return totalBalance;
        }

        public decimal GetLimit()
        {
            return debitLimit;
        }

        public bool TransferTo
            (CheckingAccount targetAccount, decimal amount)
        {
            bool withdrew = Withdraw(amount);
            if (!withdrew)
            {
                return false; 
            }

            targetAccount.Deposit(amount);
            return true;
        }
    }
}
