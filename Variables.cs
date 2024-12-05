using System;
using System.Collections.Generic;
using System.Linq;

public class Background
{
    public string Ans = "Test";
    public int room = 0;
    public int roomselect;
    //Doors Reference: Foyer, Closet, Lobby, Hallway, The Core's Chamber, Outside.
    public string[] DoorsOpen = ["Foyer", "???", "???", "???", "???"];
    public string filepath = "Savefile.csv";
    public bool puzzle = false;
    public List<Item> Backpack = new List<Item>();
    public void CheckInventory()
    {
        Console.WriteLine($"You check your bag, Inside is:\n{string.Join(", ", Backpack)}");
    }
    public void UseNitric()
    {
        //Tossing Nitric Acid.
        bool Hasitem = false;
        foreach (Item item in Backpack)
        {
            if (item.Name == "Nitric Acid") { Hasitem = true;
            break; }
            else { Hasitem = false; }
        }
        if (Hasitem)
        {
            Console.WriteLine("What would you like to use it on?");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOOR" || Ans == "LOCK" || Ans == "COPPER")
            {
                Console.WriteLine("You Pour the Nitric Acid into the Lock, the process is slow, as the Acid sizzles away the copper stopper in the lock. The smell must be terrible, and potentially dangerous. But you're not organic, so it's none of your concern.");
                puzzle = true;
            }
            else { Console.WriteLine("You Consider pouring the acid there, but something tells you it's not the best idea."); }
        }
        else
        {
            Console.WriteLine("You pat your pockets, Doesn't seem like you have one of those.");
        }
    }
    public void UseCitric()
    {
        //Tossing Citric Acid.
        bool Hasitem = false;
        foreach (Item item in Backpack)
        {
            if (item.Name == "Citric Acid") { Hasitem = true; }
            else { Hasitem = false; }
        }
        if (Hasitem)
        {
            Console.WriteLine("What would you like to use it on?");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOOR" || Ans == "LOCK" || Ans == "COPPER")
            {
                Console.WriteLine("You Pour the Citric Acid into the Lock, Nothing seems to happen, and after a few seconds you see the acid pooling on the floor, having ran through the mechanism.");
            }
            else { Console.WriteLine("You Consider pouring the acid there, but something tells you it's not the best idea."); }
        }
        else
        {
            Console.WriteLine("You pat your pockets, Doesn't seem like you have one of those.");
        }
    }
    public void UseAcetic()
    {
        //Tossing Acetic Acid.
        bool Hasitem = false;
        foreach (Item item in Backpack)
        {
            if (item.Name == "Acetic Acid") { Hasitem = true; }
            else { Hasitem = false; }
        }
        if (Hasitem)
        {
            Console.WriteLine("What would you like to use it on?");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOOR" || Ans == "LOCK" || Ans == "COPPER")
            {
                Console.WriteLine("You Pour the Acetic Acid into the Lock, Nothing seems to happen, and after a few seconds you see the acid pooling on the floor, having ran through the mechanism.");
            }
            else { Console.WriteLine("You Consider pouring the acid there, but something tells you it's not the best idea."); }
        }
        else
        {
            Console.WriteLine("You pat your pockets, Doesn't seem like you have one of those.");
        }
    }
    public void SAVEGAME() 
    {
        if (!File.Exists(filepath)) 
        {
            Console.WriteLine("Creating New Save, One Moment...");
            using (StreamWriter writer = new StreamWriter(filepath)) 
            {
                writer.WriteLine("GolemCore SaveFile");
            }
        }
        else {Console.WriteLine("Saving to File...");}
        using (StreamWriter writer = new StreamWriter(filepath)) 
        {
            writer.WriteLine("GolemCore Savefile");
            writer.WriteLine(room);
            writer.WriteLine(puzzle);
            writer.WriteLine("BACKPACK");
            writer.WriteLine(string.Join("\n", Backpack));
            writer.WriteLine("BACKPACK END");
            writer.WriteLine(string.Join(", ", DoorsOpen));
        }

    }
}