using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/***************************************************************
* Name         : FinalHamlin
* Author       : Anthony Hamlin
* Created      : 11/28/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is an MVC Web Application with a StudentWorkerModel that inherits from Student
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace FinalHamlin.Models
{
    // inherit from the Student Model
    public class StudentWorkerModel : StudentModel
    {
        // properties
        private decimal _pay = 0.0m;
        private decimal _hours = 0m;

        // constructor
        public StudentWorkerModel()
        {
            _pay = 0.0m;
            _hours = 0;
        }

        // constructor
        public StudentWorkerModel(decimal pay, decimal hours, string firstName2, string lastName2, int studentID2) : base(firstName2, lastName2, studentID2)
        {
            _pay = pay;
            _hours = hours;
        }

        // setters/getters - validate form input
        [Required(ErrorMessage = "Enter a pay rate. Must be between 7.25 - 14.75.")]
        [Display(Name = "Pay Rate")]
        [Range(7.25, 14.75)]
        public decimal? Pay
        {
            get { return _pay; }
            set
            {
                if (value < 7.25m || value > 14.75m)
                {
                    _pay = 0.0m;
                }
                _pay = Convert.ToDecimal(value);
            }
        }

        [Required(ErrorMessage = "Enter hours worked. Must be between 1 - 15.")]
        [Display(Name = "Hours Worked")]
        [Range(1, 15)]
        public decimal? Hours
        {
            get { return _hours; }
            set
            {
                if (value < 1 || value > 15)
                {
                    _hours = 0m;
                }
                _hours = Convert.ToDecimal(value);
            }
        }

        // overloaded/override the StudentModel
        public override decimal WeeklySalary()
        {
            return Convert.ToDecimal(Pay) * Convert.ToDecimal(Hours);
        }

        // override the ToString in theStudentModel
        public override string ToString()
        {
            return base.ToString() + " Weakly Salary: " + WeeklySalary();
        }
    }
}
