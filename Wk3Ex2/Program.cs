using System;

class DiceRoller
{
    // Method to simulate rolling two dice
    public static int[] RollDice()
    {
        Random rand = new Random();
        // Generating two random numbers between 1 and 6
        int die1 = rand.Next(1, 7); // die1 is between 1 and 6
        int die2 = rand.Next(1, 7); // die2 is between 1 and 6
        return new int[] { die1, die2 }; // Returning the results in an array
    }

    // Main method to interact with the user
    public static void Main()
    {
        Console.WriteLine("Welcome to the Dice Roller!");

        while (true)
        {
            // Ask the user if they want to roll the dice
            Console.Write("Do you want to roll the dice? (y/n): ");
            string userResponse = Console.ReadLine().ToLower();

            if (userResponse == "y")
            {
                // Call the RollDice method and get the result
                int[] diceResult = RollDice();
                // Display the result of the roll
                Console.WriteLine($"You rolled: {diceResult[0]} and {diceResult[1]}");
            }
            else if (userResponse == "n")
            {
                // Exit the loop if the user doesn't want to roll anymore
                Console.WriteLine("Thanks for playing! Goodbye.");
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter 'y' to roll or 'n' to quit.");
                Console.ReadLine();
            }
        }
    }
}
