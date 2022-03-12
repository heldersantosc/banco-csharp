using System;
using Banco.Entities;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //não é possivel criar um instância a partir da classe abstrata
            //Account acc = new Account(1001, "Helder Santos", 500.0);

            BusinessAccount baccount = new BusinessAccount(8010, "Helder", 100.5, 500.5);

            Console.WriteLine(baccount.Balance);

            //UPCASTING
            Account acc1 = baccount;
            Account acc2 = new BusinessAccount(8010, "Santos", 100.5, 500.5);
            Account acc3 = new SavingsAccount(8010, "Santos", 100.5, 500.5);

            //DOWNCASTING
            BusinessAccount acc4 = (BusinessAccount)acc1;


            if (acc3 is BusinessAccount)
            {
                BusinessAccount acc5 = (BusinessAccount)acc3;
            }

            acc4.WithdrawWithDiscount(10);
            Console.WriteLine(acc4.Balance);

            Console.ReadLine();
        }
    }
}
