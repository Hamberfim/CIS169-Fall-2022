using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankAccount.Models
{
    public class BankAccount
    {
        [Required(ErrorMessage = "Enter a numeric balance between 1 - 100000.")]
        [Range(1, 100000)]
        private decimal? _balance = 0;

        [Required(ErrorMessage = "Enter a numeric amount between 1 - 10000.")]
        [Range(1, 10000)]
        private decimal? _amount = 0;

        [Required(ErrorMessage = "Enter a numeric account number.")]
        private int AccountNumber = 0;

        public decimal Balance { get => _balance.Value; set => _balance = value; }
        public decimal Amount { get => _amount.Value; set => _amount = value; }
        public int AccountNumber1 { get => AccountNumber; set => AccountNumber = value; }

        public void Withdraw()
        {
            _balance = (_balance - _amount);
        }

        public void Deposit()
        {
            _balance = (_balance + _amount);
        }

    }
}
