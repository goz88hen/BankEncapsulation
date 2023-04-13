namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
           var Henryaccount = new BankAccount { };
            Console.WriteLine("How much woulld you like to deposit?");

            double amountToDeposit = double.Parse(Console.ReadLine());

            Henryaccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank You! Your balance is now {Henryaccount.GetBalance()}");
            //account.Balance = 300;

            //Console.WriteLine(account.Balance);

        }
    }
}
