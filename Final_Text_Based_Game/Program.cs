using System;
namespace Final_Text_Based_Game
{
    internal static class Program
    {
        public const int HealthElixir = 50;
        public static void Main()
        {
            Title();
        }

        private static void Title() // This is Where Players Get introduced to the game
        {
            Console.WriteLine("********************************");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*  Welcome To The Dark Times   *");
            Console.WriteLine("*     Press enter to start     *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("*                              *");
            Console.WriteLine("********************************");
            Console.ReadLine();
            Console.Clear();
            GameStart(); //and calls the GameStart Function
        }

        private static void GameStart() // Here PLayers get to pick there Characters and Start Playing
        {
            Console.WriteLine("There are 3 Characters Each with there own Unique Abilities And Missions");
            Console.WriteLine("The Characters are:" + "\n" + "Hugh Powers" + "\n" + "Emily Strange" + "\n" +
                              "Cindy Strong");
            Console.WriteLine("Pick a Character..");
            var cs = Console.ReadLine()?.ToLower() ?? throw new ArgumentNullException($"Console.ReadLine()?.ToLower()");

            switch (cs)
            {
                case "Hugh Powers" or "hugh powers":
                    HughPowers();
                    break;
                case "Emily Strange" or "emily strange":
                    //EmilyStrange();
                    break;
                case "Cindy Strong" or "cindy strong":
                    //CindyStrong();
                    break;
                default:
                    Console.WriteLine("Selection invalid Please try Again....");
                    Console.Clear();
                    GameStart();
                    break;
            }

            Console.Clear();
        }

        private static void HughPowers() //Each Character has there own Story line and Class
        {
            Console.Clear();
            const string name1 = "Hugh Powers";
            const int hughPowerAttack = 50;
            const string power = "Strength of 10 Lions" + "\n" + "Speed Faster than any Animal" + "\n" +
                                 "Agility Better then any Cat";
            const string weapons = "Sword of Might" + "\n" + "Dagger of Betrayal";
            Console.WriteLine("Your Attack Power is: " + hughPowerAttack);
            const int health1 = 100;
            Console.WriteLine("You have the Following Abilities" + "\n" + power);
            Console.WriteLine("You have the Following Weapons with you" + "\n" + weapons);
            Console.WriteLine("Your Current Health" + "\n" + health1);
            Console.WriteLine("Please Select your Mission" + name1);
            Console.WriteLine("1.Slay the Dragon in the Dungeon");
            Console.WriteLine("2.Slay the Ogres in the Haunted Forest");
            Console.WriteLine("3.Take the Day Off and Hunt Some Wolves");
            var missionChoice = Console.ReadLine()?.ToLower();

            switch (missionChoice)
            {
                case "1" or "first":
                    HughPowerStory1();
                    break;
                case "2" or "second":
                    //HughPowerStory2();
                    break;
                case "3" or "third":
                    //HughPowerStory3();
                    break;
                default:
                    Console.WriteLine("Selection invalid Please try Again....");
                    Console.Clear();
                    HughPowers();
                    break;
            }
        }

        private static void HughPowerStory1()
        {
            Console.Clear();
            Console.WriteLine("Welcome To the First Mission Hugh Powers");
            Console.WriteLine("Are you Ready To slay the dragon ?..");
            var readyUp = Console.ReadLine()?.ToLower();
            if (readyUp is "yes" or "Yes")
            {
                const int health = 100;
                const int hughpowerSwordAttack = 50;
                const int hughPowerDaggerAttack = 20;
                const string weapons = "Sword of Might" + "\n" + "Dagger of Betrayal";
                Console.WriteLine("Enter your Nick Name..");
                var nickname = Console.ReadLine();
                Console.WriteLine("Thank you " + nickname);
                Console.WriteLine(nickname + " Just to recap your character has the following abilities and weapons");
                Console.WriteLine("Character Health is..." + health + "\n" + "Sword attack Damage Points..." + hughpowerSwordAttack + "\n" +
                                  "Dagger Attack Damage points..." + hughPowerDaggerAttack + "Your Weapons are..." + "\n" + 
                                  weapons);
                Console.WriteLine("Let Us leave on our journey to the dragons cave ");
                Console.WriteLine("As we set out on the journey to slay the dragon and save the Castle");
                Start();
            }
            else
            {
                HughPowers();
            }

            static void Start()
            {
                Console.WriteLine(" You see a shiny item on the ground do you want to inspect the item ?");
                var item1 = Console.ReadLine();
                switch (item1)
                {
                    case "Yes" or "yes":
                        Route1();
                        break;
                    case "No" or "no":
                        Route2();
                        break;
                }
            }

            static void Route1()
            {
                Console.Clear();
                Console.WriteLine("You have found an a Empty Bottle guess it was nothing after all..");
                Console.WriteLine("we'll we are going to keep heading towards the Cave");
                Route3();
            }

            static void Route2()
            {
                Console.Clear();
                Console.WriteLine("You Stepped on a empty glass bottle...");
                Console.WriteLine("we'll we are going to keep heading towards the Cave");
                Route3();
            }

            static void Route3()
            {
                Console.WriteLine("We have to just pass the trough the forest then we are there...");
                Console.WriteLine(
                    "You see what looks like swords handle do you wish to inspect the sword or move along through the forest");
                var choice2 = Console.ReadLine();
                Console.Clear();
                switch (choice2)
                {
                    case "Yes" or "yes":
                        RouteElvesSword();
                        break;
                    case "No" or "no":
                        Route4();
                        break;
                    default:
                        Console.WriteLine("I did not Understand please try again...");
                        Route3();
                        break;
                }
            }

            static void RouteElvesSword() // Route of victory Reason Being is the sword that has been collected will ensure victory... 
            {
                while (true)
                {
                    const int health = 100;
                    const int healthPotion = 50;
                    const int hughpowerSwordAttack = 50;
                    const int hughPowerDaggerAttack = 20;
                    const int swordOfElvesAttack = 100;
                    const string weapons = "Sword of Might" + "\n" + "Dagger of Betrayal";
                    const string newWeapon = "Sword of the Elves";
                    Console.WriteLine("Upon approaching the sword you start smiling....");
                    Console.WriteLine("You see what seems to be an ancient sword from the elves");
                    Console.WriteLine("You grab the handle of the sword and you can just feel the power the sword holds");
                    Console.WriteLine(newWeapon + "...Has been added to your inventory... Attack Damage is..." + swordOfElvesAttack);
                    Console.WriteLine("As we Approach the end of the forest you see the dragons den nearing...");
                    Console.WriteLine("This is the time to save the people of the Kingdom and Slay the dragon");
                    Console.WriteLine("You have the following weapons available to you..." + newWeapon + "\n" + weapons);
                    Console.WriteLine("The Damage for each Weapon is as Follows..." + "\n" + "Sword of Might.." + hughpowerSwordAttack + "\n" + "The Dagger of Betrayal..." + hughPowerDaggerAttack + "\n" + "Sword of the Elves..." + swordOfElvesAttack);
                    Console.WriteLine("Your Health is...." + health);
                    Console.WriteLine("Are you ready to Slay the Dragon...");
                    var battle = Console.ReadLine();

                    if (battle is "yes" or "Yes")
                    {
                        Console.Clear();
                        Console.WriteLine("As we Start Getting Closer and Closer to the Dragons Den....");
                        Console.WriteLine("You See A glimpse of the massive and powerful dragon, but you are ready to slay the dragon");
                        Console.WriteLine("As you start preparing yourself for the battle ahead there is something...Hidden");
                        Console.WriteLine("Just before the dragons den is a bottle of Health elixir if you can solve a Riddle the potion is yours");
                        Console.WriteLine("The health elixir is Worth..." + healthPotion + "...In health points");
                        Console.WriteLine("Do you want to solve the Riddle to obtain a Health Elixir ?");
                        var healthElixir = Console.ReadLine();

                        if (healthElixir is "yes" or "Yes")
                        {
                            Console.Clear();
                            Console.WriteLine("Solve the Following Riddle");
                            Console.WriteLine("Think of words ending in -GRY. Angry and hungry are two of them. " + "\n" + "There are only three words in the English language. What is the third word? " + "\n" + "The word is something that everyone uses every day. If you have listened carefully, " + "\n" + "I have already told you what it is.");
                            var riddleAnswer = Console.ReadLine();

                            if (riddleAnswer is "Language" or "language")
                            {
                                FinalBattleHe();
                            }
                            else
                            {
                                Console.WriteLine("That was incorrect do you wish to try again...?");
                                var retry = Console.ReadLine();
                                switch (retry)
                                {
                                    case "Yes" or "yes":
                                        continue;
                                    case "No" or "no":
                                        FinalBattle();
                                        break;
                                    default:
                                        Console.WriteLine("I did not Understand Please try again");
                                        break;
                                }
                            }
                        }
                        else
                        {
                            FinalBattle();
                        }
                    }
                    else if (battle is "No" or "no")
                    {
                        HughPowerStory1();
                    }
                    else
                    {
                        continue;
                    }

                    break;
                }
            }

            static void FinalBattleHe()//HE stands for Health Elixir if the player solved the riddle 
            {
                const int dragonHealth = 200;
                const int dragonAttack = 30;
                const int health = 100;
                const int healthPotion = 50;
                const int hughpowerSwordAttack = 50;
                const int hughPowerDaggerAttack = 20;
                const int swordOfElvesAttack = 100;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");

            }

            static void FinalBattle()//Final battle without the health elixir if the player did not solve the riddle or did not want to solve the riddle
            {
                const int dragonHealth = 200;
                const int dragonAttack = 30;
                const int health = 100;
                const int hughpowerSwordAttack = 50;
                const int hughPowerDaggerAttack = 20;
                const int swordOfElvesAttack = 100;
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("");
            }

            static void Route4()
            {
                Console.Clear();
                const int healthPotion = 50;
                Console.WriteLine("As we Start Getting Closer and Closer to the Dragons Den....");
                Console.WriteLine("You See A glimpse of the massive and powerful dragon, but you are ready to slay the dragon");
                Console.WriteLine("As you start preparing yourself for the battle ahead there is something...Hidden");
                Console.WriteLine("Just before the dragons den is a bottle of Health elixir if you can solve a Riddle the potion is yours");
                Console.WriteLine("The health elixir is Worth..." + healthPotion + "...In health points");
                Console.WriteLine("Do you want to solve the Riddle to obtain a Health Elixir ?");
                var healthElixir = Console.ReadLine();
                if (healthElixir is "yes" or "Yes")
                {
                    Console.Clear();
                    Console.WriteLine("Solve the Following Riddle");
                    Console.WriteLine("Think of words ending in -GRY. Angry and hungry are two of them. " + "\n" + "There are only three words in the English language. What is the third word? " + "\n" + "The word is something that everyone uses every day. If you have listened carefully, " + "\n" + "I have already told you what it is.");
                    var riddleAnswer = Console.ReadLine();

                    if (riddleAnswer is "Language" or "language")
                    {
                        FinalBattleHe();
                    }
                    else
                    {
                        Console.WriteLine("That was incorrect do you wish to try again...?");
                        var retry = Console.ReadLine();
                        switch (retry)
                        {
                            case "Yes" or "yes":
                                Route4();
                                break;
                            case "No" or "no":
                                FinalBattle();
                                break;
                            default:
                                Console.WriteLine("I did not Understand Please try again");
                                break;
                        }
                    }
                }
                
            }
        }
    }
}