using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/***************************************************************
* Name         : Console App: Inheritance - StudentWorker
* Author       : Anthony Hamlin
* Created      : 10/21/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is about inheritance. Utilizing a base class, a class that inherits from that bases, with methods and overrides.
*                      Input :  Student name, id, DOB
*                      Output: Student name, id, DOB, age
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace InheritanceConsoleApp
{
    class StudentWorker : Student
    {
        private decimal _pay;
        private double _hours;

        public StudentWorker() : base()
        {
            _pay = 0.0m;
            _hours = 0;
        }

        public StudentWorker(decimal pay, double hours, string fname2, string lname2, DateTime dob2, int id2) : base(fname2, lname2, dob2, id2)
        {
            _pay = pay;
            _hours = hours;
        }

        public decimal Pay { get => _pay; set => _pay = value; }
        public double Hours { get => _hours; set => _hours = value; }


        public override string MakeNamePlate()
        {
            return base.MakeNamePlate();
        }

        public override int CalculateAge()
        {
            return base.CalculateAge();
        }

        public virtual decimal CalcuatePay()
        {
            return Pay * Convert.ToDecimal(Hours);
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
