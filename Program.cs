using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
class Program
{
    static void Main()
    {
        //The Golem Knows how to handle all the values.
        Room GolemKnow = new Room();
        string filepath = "Savefile.csv";
        //SEALING CLAY! You don't have HP anymore, so this doesn't do anything. But since it's near the holidays it's a Stocking Stuffer from me to you. Happy Holidays!
        GolemKnow.Backpack.Add(new Item("SEALING CLAY", 1));
        //Win Con
        bool CoreGot = false;
        //Titlecard
        Console.WriteLine("\nGOLEM CORE\n");
        Console.WriteLine("Press Any Key to Start...");
        // Console.ReadKey();
        //Some Sort of "Would you Like to Load a Save" here. Probably setting Golem Know to all the saved variables.
        if (File.Exists(filepath))
        {
            Console.WriteLine("Would you like to load a save? Y/N");
            while (GolemKnow.Ans != "Y" && GolemKnow.Ans != "YES" && GolemKnow.Ans != "NO" && GolemKnow.Ans != "N")
            {
                GolemKnow.Ans = Console.ReadLine().ToUpper();
                if (GolemKnow.Ans == "Y" || GolemKnow.Ans == "YES")
                {
                    //Save load here
                    using (StreamReader reader = new StreamReader(GolemKnow.filepath))
                    {
                        string line;
                        bool backpack = false;
                        bool update = false;
                        bool doors = false;
                        while ((line = reader.ReadLine()) != null)
                        {
                            if (line == "GolemCore Savefile")
                            {
                                update = true;
                            }
                            else if (update)
                            {
                                try
                                {
                                    GolemKnow.room = Convert.ToInt32(line);
                                }
                                catch
                                {
                                    if (line == "True" || line == "False")
                                    {
                                        GolemKnow.puzzle = Convert.ToBoolean(line);
                                    }
                                    else if (line == "BACKPACK END")
                                    {
                                        backpack = false;
                                        doors = true;
                                    }
                                    else if (backpack)
                                    {
                                        string[] Itemmaker = [];
                                        Itemmaker = line.Split("|");
                                        Item item = new Item (Itemmaker[0], Convert.ToInt32(Itemmaker[1]));
                                        GolemKnow.Backpack.Add(item);
                                    }
                                    else if (doors) 
                                    {
                                        GolemKnow.DoorsOpen = line.Split(',');
                                    }
                                    else if (line == "BACKPACK") { backpack = true; }
                                    

                                }
                            }
                            Console.WriteLine(line);
                        }
                        Console.WriteLine("File Loaded");
                    }
                }
                else if (GolemKnow.Ans == "N" || GolemKnow.Ans == "NO")
                {
                    Console.WriteLine("Got it, Starting new file!");
                }
                else
                {
                    Console.WriteLine("Please Enter Either Y or N");
                }
            }
        }
        if (GolemKnow.Ans != "Y" || GolemKnow.Ans != "YES") {
        Console.WriteLine("The ancient door behind you creaks shut.\n If the rumors are true, this manor holds the last fragment of the GOLEM CORE, An artifact as old as time itself, with the power to grant true life to any golem it inhabits.");
        Console.WriteLine("You; A golem made of Porcelain, and a rather good adventurer if you'd say so yourself, have trekked across the shattered world outside, risking everything for a chance at the most covetted of Prizes;\n Humanity.");}
        //You are In the House (like carpet)
        while (GolemKnow.room >= 0)
        {
            switch (GolemKnow.room)
            {
                //Foyer
                case 0:
                    GolemKnow.Foyer();
                    break;
                //Closet
                case 1:
                    Console.WriteLine("You enter the Closet, it seems to have been well maintained in it's time, there isn't much to do here now...");
                    while (GolemKnow.room == 1) { GolemKnow.Closet(); }
                    break;
                //Lobby
                case 2:
                    Console.WriteLine("You Enter the Lobby, A large sprawling Center to the manor. It seems to be practically glowing with the amount of care and effort that has been put into this room. Everything is Spotless.");
                    while (GolemKnow.room == 2) { GolemKnow.Lobby(); }
                    break;
                case 3:
                    //unsubtle Feet of Clay reference.
                    Console.WriteLine("You enter the Grand chamber, Designed with the Sole Purpose of Holding the Golem Core. In the center of the room is a Podium, roughly chest high, with a small coil of paper floating inches above.\nThis is it. The Core of every golem is a list of words and parameters, defining what you are and how you exist.\n Most cores are rather simple, with the occasional lucky golem having more human like function.\n\nYou take the core, it's glimmering fading as it leaves the Podium, and place it with your own. And then you leave, Ready to Experience the World anew.");
                    CoreGot = true;
                    GolemKnow.room = -1;
                    break;
                //Core room
                default:
                    break;
            }
        }
        //outside
        if (CoreGot)
        {
            Console.WriteLine("Thanks For playing my Final Project: Golem Core! - Hoover");
            Console.WriteLine("Game End");
        }
        else
        {
            Console.WriteLine("You leave, while the risks might have been worth it at first, after the journey you had just to get to the Core, You're not sure you would survive the trip back. Especially with a renown artifact on your person. \n You head home, You'll return with friends, You don't have to do this alone.");
            Console.WriteLine("Game End");
        }
    }
}