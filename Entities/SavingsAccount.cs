using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.Entities
{
    // sealed bloqueia a criação de subclasses a partir dessa classe
    internal sealed class SavingsAccount : Account
    {
        public double InterestRate { get; set; }

        public SavingsAccount()
        {
        }

        public SavingsAccount(int number, string holder, double balance, double interestRate)
            : base(number, holder, balance)
        {
            InterestRate = interestRate;
        }

        public void UpdateBalance()
        {
            Balance += Balance * InterestRate;
        }

        //sobrescreve o método da Account
        public override void Withdraw(double amount)
        {
            Balance -= amount;
        }

        //implementa o método principal e aplica a nova implementação
        // sela o método com sealed, para que não seja sobrescrita novamente
        public sealed override void WithdrawWithDiscount(double amount)
        {
            base.WithdrawWithDiscount(amount);
            Balance -= 2.0;
        }

    }
}
