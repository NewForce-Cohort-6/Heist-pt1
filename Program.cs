using System;
using System.Collections.Generic;

namespace heist
{
    class Program
    {
        static void Main(string[] args)
        {
            // Phase 2 step 1
            List<TeamMember> HeistTeam = new List<TeamMember>();

            Console.WriteLine("Plan Your Heist!");

            Console.WriteLine("Lets make a team");

            while (true)
            {

                Console.WriteLine("Name your teammate");

                string name = Console.ReadLine();

                if (name == "")
                {
                    break;
                }

                Console.WriteLine("Enter their skill level");

                int skill = int.Parse(Console.ReadLine());


                double courage = 0;

                while (true)
                {
                    Console.WriteLine("Enter their courage factor");

                    Console.WriteLine("0.0 - 2.0");

                    courage = double.Parse(Console.ReadLine());
                    if (courage >= 0 && courage <= 2)
                    {

                        break;
                    }
                    else
                    {
                        continue;
                    }
                }

                TeamMember heistBuddy = new TeamMember()
                {
                    Name = name,
                    SkillLevel = skill,
                    Courage = courage
                };
                // This will make both instances share the same name
                // TeamMember liabality = heistBuddy;

                // liabality.Name = "Tommy";

                HeistTeam.Add(heistBuddy);
                // HeistTeam.Add(liabality);
                //------------------------

            }
            Console.WriteLine($"Here's The Crew ({HeistTeam.Count})");
            HeistTeam.ForEach(heistBuddy =>
            {
                Console.WriteLine("----------------");
                Console.WriteLine($"Name: {heistBuddy.Name}");
                Console.WriteLine($"Skill Level: {heistBuddy.SkillLevel}");
                Console.WriteLine($"Courage Factor: {heistBuddy.Courage}");

            }
           );

        }
    }

}

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

