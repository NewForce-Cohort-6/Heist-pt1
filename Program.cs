using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            Methods newHeist = new Methods();
            Console.WriteLine("Heist the Game");
            Methods.Heist();
        }

    }

}

// Phase Six
// The program should be updated to...

// 1) At the beginning of the program, prompt the user to enter the difficulty level of the bank.
// 2) At the end of the program, display a report showing the number of successful runs and the number of failed runs.

// Phase Five
// The program should be updated to...

// 1) Run the scenario multiple times.
// 2) After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
// 3) Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.


// Phase Four
// The program should be updated to...

// 1) Create a random number between -10 and 10 for the heist's luck value.
// 2) Add this number to the bank's difficulty level.
// 3) Before displaying the success or failure message, display a report that shows.
//  * The team's combined skill level
//  * The bank's difficulty level


// Phase Three
// The program should be updated to...

// 1) Stop displaying each team member's information.
// 2) Store a value for the bank's difficulty level. Set this value to 100.
// 3) Sum the skill levels of the team. Save that number.
// 4) Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.


// Phase Two
// The program should be updated to...

// 1) Create a way to store several team members.
// 2) Collect several team members' information.
// 3) Stop collecting team members when a blank name is entered.
// 4) Display a message containing the number of members of the team.
// 5) Display each team member's information.


// Phase One
// The program should...

// 1) Print the message "Plan Your Heist!". 
// 2) Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
// 3) Prompt the user to enter a team member's name and save that name.
// 4) Prompt the user to enter a team member's skill level and save that skill level with the name.
// 5) Prompt the user to enter a team member's courage factor and save that courage factor with the name.
// 6) Display the team member's information.

