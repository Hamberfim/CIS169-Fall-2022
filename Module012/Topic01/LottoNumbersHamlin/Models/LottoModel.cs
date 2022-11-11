using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
/***************************************************************
* Name         : LottoNumbersHamlin
* Author       : Anthony Hamlin
* Created      : 11/10/2022
* Course       : CIS 169 - C#
* Version      : 1.0
* OS           : Windows 10
* IDE          : Visual Studio 2019 Community
* Copyright    : This is my own original work based on
*                      specifications issued by our instructor
* Description  : This program is the data model
*                      Input :  numbers from a html form
*                      Output:  matching numbers
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/
namespace LottoNumbersHamlin.Models
{
    public class LottoModel
    {
        // no magic numbers
        private const int RNDNUM_LOW = 1;
        private const int RNDNUM_HIGH = 72;
        private const int ARRAY_LENGTH = 4;

        // field members
        private string _firstNumberStr;
        private int _firstNumber;

        private string _secondNumberStr;
        private int _secondNumber;

        private string _thirdNumberStr;
        private int _thirdNumber;

        private string _fourthNumberStr;
        private int _fourthNumber;

        private int _matchingNumbers = 0;

        // generate random numbers
        Random rndnum = new Random();

        // array to hold generated numbers
        // private int[] lottoNumsArr = { 1, 2, 3, 4 };  // test array
        private int[] lottoNumsArr = new int[ARRAY_LENGTH];


        // constructor that generates the random lotto Winning Numbers
        public LottoModel()
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _thirdNumber = 0;
            _fourthNumber = 0;

            for (int i = 0; i < ARRAY_LENGTH; i++)
            {
                lottoNumsArr[i] = rndnum.Next(RNDNUM_LOW, RNDNUM_HIGH);
            }
        }
        public LottoModel(string _firstNumberStr, string _secondNumberStr, string _thirdNumberStr, string _fourthNumberStr)
        {
            _firstNumber = 0;
            _secondNumber = 0;
            _thirdNumber = 0;
            _fourthNumber = 0;


            // first num
            if (_firstNumberStr == string.Empty)
            {
                _firstNumber = 0;
            }
            else
            {
                _firstNumber = Convert.ToInt32(_firstNumberStr);
            }

            // second num
            if (_secondNumberStr == string.Empty)
            {
                _secondNumber = 0;
            }
            else
            {
                _secondNumber = Convert.ToInt32(_secondNumberStr);
            }

            // third num
            if (_thirdNumberStr == string.Empty)
            {
                _thirdNumber = 0;
            }
            else
            {
                _thirdNumber = Convert.ToInt32(_thirdNumberStr);
            }

            // fourth num
            if (_fourthNumberStr == string.Empty)
            {
                _fourthNumber = 0;
            }
            else
            {
                _fourthNumber = Convert.ToInt32(_fourthNumberStr);
            }

            for (int i = 0; i < ARRAY_LENGTH; i++)
            {
                lottoNumsArr[i] = rndnum.Next(RNDNUM_LOW, RNDNUM_HIGH);
            }
        }

        // setters/getters
        [Required(ErrorMessage = "Please enter your first number.")]
        [Range(RNDNUM_LOW, RNDNUM_HIGH, ErrorMessage = "First number must be between 1 and 72")]
        public int FirstNumber { get => _firstNumber; set => _firstNumber = value; }

        [Required(ErrorMessage = "Please enter your second number.")]
        [Range(RNDNUM_LOW, RNDNUM_HIGH, ErrorMessage = "Second number must be between 1 and 72")]
        public int SecondNumber { get => _secondNumber; set => _secondNumber = value; }

        [Required(ErrorMessage = "Please enter your third number.")]
        [Range(RNDNUM_LOW, RNDNUM_HIGH, ErrorMessage = "Third number must be between 1 and 72")]
        public int ThirdNumber { get => _thirdNumber; set => _thirdNumber = value; }

        [Required(ErrorMessage = "Please enter your fourth number.")]
        [Range(RNDNUM_LOW, RNDNUM_HIGH, ErrorMessage = "Fourth number must be between 1 and 72")]
        public int FourthNumber { get => _fourthNumber; set => _fourthNumber = value; }
        public int MatchingNumbers { get => _matchingNumbers; set => _matchingNumbers = value; }

        public int? CompareTicketToInput()
        {
            MatchingNumbers = 0;  // reset on each call
            if (FirstNumber == lottoNumsArr[0] || FirstNumber == lottoNumsArr[1] || FirstNumber == lottoNumsArr[2] || FirstNumber == lottoNumsArr[3])
            {
                MatchingNumbers += 1;
            }

            if (SecondNumber == lottoNumsArr[0] || SecondNumber == lottoNumsArr[1] || SecondNumber == lottoNumsArr[2] || SecondNumber == lottoNumsArr[3])
            {
                MatchingNumbers += 1;
            }

            if (ThirdNumber == lottoNumsArr[0] || ThirdNumber == lottoNumsArr[1] || ThirdNumber == lottoNumsArr[2] || ThirdNumber == lottoNumsArr[3])
            {
                MatchingNumbers += 1;
            }

            if (FourthNumber == lottoNumsArr[0] || FourthNumber == lottoNumsArr[1] || FourthNumber == lottoNumsArr[2] || FourthNumber == lottoNumsArr[3])
            {
                MatchingNumbers += 1;
            }

            return MatchingNumbers;
        }

        public string Message()
        {
            string message = ($"<p class='notificationColor'><strong>Your numbers:</strong>  {FirstNumber}, {SecondNumber}, {ThirdNumber}, {FourthNumber}.</p><p class='warning'><strong>Winning Numbers:</strong>  {lottoNumsArr[0]}, {lottoNumsArr[1]}, {lottoNumsArr[2]}, {lottoNumsArr[3]}</p>");
            return message;
        }
    }
}
