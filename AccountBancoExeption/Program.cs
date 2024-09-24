using AccountBancoExeption.Entities;
using AccountBancoExeption.Entities.Exceptions;
using System.Globalization;

namespace AccountBancoExeption
{
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter account data ");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double balance = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Withdraw limiti: ");
                double withdrawLimit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Account acc = new Account(number, holder, balance, withdrawLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
                acc.WithDraw(withdraw);
            }
            catch (DomainException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
