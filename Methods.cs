using System;
using System.Collections.Generic;
using System.Linq;

namespace heist
{


    public class Methods
    {
        public static void Heist() {
        // Phase 2 step 1
            List<TeamMember> HeistTeam = new List<TeamMember>();
            
            // User Enters Bank difficulty
            Console.WriteLine("Choose a difficulty level for the Bank");
            int bank = int.Parse(Console.ReadLine());


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
            int teamSkill = HeistTeam.Sum(heistMember => heistMember.SkillLevel);

            //collect user input for amount of trial runs
            Console.WriteLine("How many trial runs would you like to perform?");
            int trialRuns = int.Parse(Console.ReadLine());

            //Teams combined skill level
            Console.WriteLine($"Heist Report");
            int wins = 0;
            int losses = 0;
            for(int i = 0; i < trialRuns; i++)
            {
            int luck = new Random().Next(-10, 11); // creates a number between -10 and 10.

            bank += luck;

            Console.WriteLine($"-------------");
            Console.WriteLine($"The teams total skill level is {teamSkill}");           
            Console.WriteLine($"the banks skill level is {bank}");
            Console.WriteLine($"-------------------------------");
            // Random luck 
            
            if (teamSkill >= bank)
            {
                Console.WriteLine("Great Job. Go buy a yacht.");
                wins++;
            }
            else
            {
                Console.WriteLine("You got caught. See ya in 25.");
                losses++;

            }


            }
            Console.WriteLine($"************************************");
            Console.WriteLine($"Final Totals:");
            Console.WriteLine($"Heist was successful {wins} times.");
            Console.WriteLine($"Heist was failed {losses} times.");




            //     Console.WriteLine($"Here's The Crew ({HeistTeam.Count})");
            //     HeistTeam.ForEach(heistBuddy =>
            //     {
            //         Console.WriteLine("----------------");
            //         Console.WriteLine($"Name: {heistBuddy.Name}");
            //         Console.WriteLine($"Skill Level: {heistBuddy.SkillLevel}");
            //         Console.WriteLine($"Courage Factor: {heistBuddy.Courage}");

            //     }
            //    );


    }


    }
}