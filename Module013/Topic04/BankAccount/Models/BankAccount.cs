using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BankAccount.Models
{
    public class BankAccount
    {
        private int _accountNumber = 0;
        private decimal _balance = 0;
        private decimal _amount = 0;

        [Required(ErrorMessage = "Enter a numeric account number.")]
        [Display(Name = "Account Number")]
        [Range(1, 999999)]
        public int AccountNumber { get => _accountNumber; set => _accountNumber = value; }

        [Required(ErrorMessage = "Enter a numeric balance between 1 - 100000.")]
        [Display(Name = "Account Balance")]
        [Range(1, 100000)]
        public decimal Balance
        {
            get { return _balance; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }

                _balance = value;
            }
        }

        [Required(ErrorMessage = "Enter a numeric withdraw amount between 1 - 10000.")]
        [Display(Name = "Withdraw Amount")]
        [Range(1, 10000)]
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException($"{nameof(value)} must be positive.");
                }
                _amount = value;
            }
        }

        public void Withdraw()
        {
            if (_amount > _balance)
            {
                throw new ArgumentOutOfRangeException($"The Amount of {nameof(_amount)}  will overdraft your account");
            }
            else
            {
                _balance = (_balance - _amount);
            }

        }

        public void Deposit()
        {
            _balance = (_balance + _amount);
        }

    }
}
