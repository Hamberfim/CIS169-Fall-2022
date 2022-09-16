using System;

namespace InputValidationPratice
{
    class Program
    {
        /* Write a Console App that builds a character sheet for gaming...print out a paragraph about the generated character.
         * Business Logic - Include the following characteristics: 
         *      Character Name,: 
         *      Charm - Charm is a number in the range of 10 to 20.
         *      Strength - Strength is a number in the range of 0 and 40. 
         *      Shield - Shield is a number in the range of 1 to 10.
         *      
         * For character building, individuals roll dice to set values (eventually Randon Number Generate)
         *      1.) The code will first prompt the user for their character name. 
         *      2.) Next, it will ask the user for their character information from the assumed dice roll - charm, strength and shield. 
         *      (Later when you learn about random numbers and loops, 
         *      you'll remove this part of user input and generate the character numbers with simulating the roll of the dice.)
         * 
         * NOTES: 
         *  Your program must use TryParse and compound conditionals to validate the input. 
         *      When you run the code, you can select random numbers in the appropriate value range to test your code.
         *      If the user input range is incorrect, select/assign a valid value for the user (the lowest of the range, or median, or any number).
         *  Don't forget to also select/test improper input to test the validation.
         */
        static void Main(string[] args)
        {
            String characterName;
            int charm;
            int strength;
            int shield;

            // prompt the user for their character name
            Console.WriteLine("Enter your characters name: ");
            characterName = Console.ReadLine();
            if(!String.IsNullOrEmpty(characterName))
            {
                Console.WriteLine($"Welcome, {characterName}!");
            } else
            {
                characterName = "Young Warrior";
                Console.WriteLine($"Default Character name set. Welcome, {characterName}!");

            }

            // ask the user for their character information from the assumed dice roll - charm, strength and shield.
            Console.WriteLine("Enter a charm number (10 to 20): ");
            String charmString = Console.ReadLine();
            if(int.TryParse(charmString, out charm))
            {
                if(charm >= 10 && charm <= 20)
                {
                    Console.WriteLine($"{charm} will be used for charm number value.");
                } else
                {
                    charm = 10;  // set to lowest default range
                    Console.WriteLine($"Charm number value must be between 10 and 20. Setting your charm value to {charm}.");
                }
            } else
            {
                charm = 10;  // set to lowest default range
                Console.WriteLine($"Charm number value must be between 10 and 20 and an integer. Setting your charm value to {charm}.");
            }

            Console.WriteLine("Enter a strength number (0 to 40): ");
            String strengthString = Console.ReadLine();
            if (int.TryParse(strengthString, out strength))
            {
                //strength = strength;
                if (strength >= 0 && strength <= 40)
                {
                    Console.WriteLine($"{strength} will be used for strength number value.");
                }
                else
                {
                    strength = 0;  // set to lowest default range
                    Console.WriteLine($"Strength number value must be between 0 and 40. Setting your strength value to {strength}.");
                }
            }
            else
            {
                strength = 0;  // set to lowest default range
                Console.WriteLine($"Strength number value must be between 0 and 40 and an integer. Setting your strength value to {strength}.");
            }

            Console.WriteLine("Enter a shield number (1 to 10): ");
            String  shieldString = Console.ReadLine();
            if (int.TryParse(shieldString, out shield))
            {
                //shield = shield;
                if (shield >= 1 && shield <= 10)
                {
                    Console.WriteLine($"{shield} will be used for shield number value.");
                }
                else
                {
                    shield = 1;  // set to lowest default range
                    Console.WriteLine($"Shield number value must be between 1 and 10. Setting your shield value to {shield}.");
                }
            }
            else
            {
                shield = 1;  // set to lowest default range
                Console.WriteLine($"Shield number value must be between 1 and 10 and an integer. Setting your shield value to {shield}.");
            }

            Console.WriteLine("\n======= Character Built =======");
            Console.WriteLine($"Character Name: {characterName}");
            Console.WriteLine($"Charm: {charm}");
            Console.WriteLine($"Strength: {strength}");
            Console.WriteLine($"Shield: {shield}");
            Console.WriteLine("Time for battle!");

        }
    }
}
