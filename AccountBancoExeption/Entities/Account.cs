using AccountBancoExeption.Entities.Exceptions;

namespace AccountBancoExeption.Entities
{
    public class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double  Balance { get; set; }
        public double WithdrawLimit { get; set; }

        public Account() { }

        public Account(int number, string holder, double balance, double withdrawLimit)
        {
            if( number <0 || number == 0 )
            {
                throw new DomainException("Error number must be greater than zero ");
            }
            if(balance < 0 || balance == 0 )
            {
                throw new DomainException("Error balance must be greater than zero");
            }
            Number = number;
            Holder = holder;
            Balance = balance;
            WithdrawLimit = withdrawLimit;
        }

        public  void Deposit(double amount)
        {
            Balance += amount;
        }
        public void WithDraw(double amount)
        {
            if (amount > WithdrawLimit)
            {
                throw new DomainException("Withdraw error: The amount exceeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainException("Withdraw error: Not enough balance");
            }
            Balance -= amount;
        }

    }
}
