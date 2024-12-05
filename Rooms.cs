using System;
using System.Collections.Generic;
using System.Linq;

public class Room : Background
{
    public void Foyer()
    {
        //Important Contents: Starting Location, Door to Outside.
        //Connects to: Lobby (N) Closet (E) Outside (S).
        Console.WriteLine("\nYou're in the foyer.\n To the North, is a ornate pair of DOORS, To the East is a simple WOOD DOOR, The West wall is lined with aged COATS, finally Behind you is the EXIT.");
        Console.Write("What Would you like to do?\n> ");
        Ans = Console.ReadLine().ToUpper();
        if (Ans == "APPROACH")
        {
            Console.Write("What Would You Like to APPROACH? > ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOORS")
            {
                Console.WriteLine("you Approach the Ornate Pair of Doors\n The golden finish has dimmed and chipped with time, What might have once been a halo leading you onwards into the Manor is now more like caution tape.\nLightly trying the gilded Handle, it seems to be unlocked.");
            }
            else if (Ans == "COATS")
            {
                Console.WriteLine("You Approach the Coats\nThe Coats are Coated in a fine layer of Dust, While they might once have been expensive, Luxury Items, You're not sure if they're much more than 'conversation starters' now.");
            }
            else if (Ans == "WOOD DOOR")
            {
                Console.WriteLine("You Approach the Wooden Door.\nDesigned to be overlooked, This door has no features other than it's handle, and almost blends into the darkness. It seems unlocked!");
            }
            else if (Ans == "EXIT")
            {
                Console.WriteLine("You Approach the Exit.\n It's not too late to leave, There's still time to head back home, and while Humanity is worth the risk, the journey has been tiring...");
            }
            else
            {
                Console.Write("You try to find That, but can't seem to... [Invalid Input. Please Input The CAPITALIZED words.]");
            }
        }
        else if (Ans == "USE" || Ans == "ACTIVATE")
        {
            Console.Write("What would you like to USE/ACTIVATE?\n> ");
            Console.ReadLine().ToUpper();
            //Lazy solution, nothing to use or be used on in here
            Console.WriteLine("It doesn't seem like you can use that here.");
        }
        else if (Ans == "OPEN")
        {
            Console.Write("What Would you Like to Open?\n> ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOORS")
            {
                Console.WriteLine("\nYou Open the Double doors, The creak of old hinges filling the large Lobby beyond, The room seems more cared for than the Foyer,\nSomething must still be home...");
                DoorsOpen[2] = "Lobby";
            }
            else if (Ans == "WOOD DOOR")
            {
                Console.WriteLine("\nYou Open the Door to the East, Inside is a Supply Closet, With a Assortment of Chemicals, Mops, and Brooms.\n it's a little claustrophobic.");
                DoorsOpen[1] = "Closet";
            }
            else if (Ans == "EXIT")
            {
                Console.WriteLine("You Look back at the Entrance and consider opening the Manor to the world beyond.\nAre you sure? Y/N");
                Ans = Console.ReadLine().ToUpper();
                if (Ans == "Y" || Ans == "YES")
                {
                    Console.WriteLine("You open the door, A draft of cool air from invites itself in, along with the steady sound of rain. \nIf you're looking to head home, nows your best chance.");
                    DoorsOpen[4] = "Outside";
                }
                else
                {
                    Console.WriteLine("You Reconsider, and step away from the door.");
                }
            }
            else { Console.WriteLine("You can't do that here."); }
        }
        else if (Ans == "MOVE" || Ans == "TRAVEL")
        {
            Console.WriteLine("Where Would you Like to go?");
            Console.WriteLine($"1. {DoorsOpen[0]}\n2. {DoorsOpen[1]}\n3. {DoorsOpen[2]}\n4. {DoorsOpen[3]}\n5. {DoorsOpen[4]}\n6. BACK");
            Console.Write("Your Selection: ");
            try
            {
                roomselect = Convert.ToInt32(Console.ReadLine());
                switch (roomselect)
                {
                    case 1:
                        room = 0;
                        break;
                    case 2:
                        if (DoorsOpen[1] == "Closet") { room = 1; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 3:
                        if (DoorsOpen[2] == "Lobby") { room = 2; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 4:
                        if (DoorsOpen[3] == "The Core's Chamber") { room = 3; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 5:
                        if (DoorsOpen[4] == "Outside") { room = 4; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
        else if (Ans == "INVENTORY") { CheckInventory(); }
        else if (Ans == "SAVE") {SAVEGAME();}
        else { Console.WriteLine("I don't understand your input, Please check the README File for a List of Commands.");}

    }
    public void Closet()
    {
        //1 = in inventory. Items: [Bucket, Nitric Acid, Citric Acid, Acetic Acid]

        //Important Contents: Chemicals for Puzzle later, Bucket for Puzzle later.
        //Connects to: Foyer (W)
        Console.WriteLine("\n You're in a supply closet. To the north is a wall of bottled chemicals. Among them, you see various ACIDS, to the East, ahead of you, is a Half filled BUCKET and Mop. To the South, is an shelf of chemicals. Behind you is the open door, leading into the Foyer.");
        Console.Write("What Would you like to do?\n> ");
        Ans = Console.ReadLine().ToUpper();
        //Approach
        if (Ans == "APPROACH")
        {
            Console.Write("What Would You Like to APPROACH? > ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "ACIDS")
            {
                Console.WriteLine("Taking a closer look at the shelf full of chemicals, a few bottles stand out. Nestled amongst the various cleaning agents, you see a vial of NITRIC ACID, a bottle of CITRIC ACID, and a jar of ACETIC ACID.");
            }
            else if (Ans == "CHEMICALS")
            {
                Console.WriteLine("Searching the Southern Shelf, you find the contents of most of the bottles to be already drained. All that remains is Two vials that's contents seem dubious at best.\nMight be best to leave these here. ");
            }
            else if (Ans == "BUCKET")
            {
                Console.WriteLine("Infront of you is a standard, multi-purpose bucket. And a mop!");
            }
            else
            {
                Console.Write("You try to find That, but can't seem to... [Invalid Input. Please Input The CAPITALIZED words.]");
            }
        }
        //USE/ACTIVATE
        else if (Ans == "USE" || Ans == "ACTIVATE")
        {
            Console.Write("What would you like to USE/ACTIVATE?\n> ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "BUCKET")
            {
                Item Bucket = new Item("Bucket", 1);
                //Picking up Bucket.
                bool Hasitem = false;
                foreach (Item item in Backpack)
                {
                    if (item.Name == "Bucket") { Hasitem = true; }
                }
                if (!Hasitem)
                {
                    Console.Write("The bucket in this room could be useful later, would you like to take it with you? Y/N  ");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You take the bucket.");
                        Backpack.Add(Bucket);
                    }
                    else { Console.WriteLine("You back away from the bucket."); }
                }
            }
            else if (Ans == "NITRIC ACID")
            {
                Item Nitric = new Item("Nitric Acid", 1);
                //Picking up Nitric Acid.
                bool Hasitem = false;
                foreach (Item item in Backpack)
                {
                    if (item.Name == "Nitric Acid") { Hasitem = true; }
                    else { Hasitem = false; }
                }
                if (!Hasitem)
                {
                    Console.Write("That Nitric Acid might be useful later, Do you take it with you? Y/N  ");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You pocket the Nitric Acid Vial");
                        Backpack.Add(Nitric);
                    }
                    else { Console.WriteLine("You back away from the shelf, Might be best to leave that here."); }
                }
                //Already Have Nitric Acid
                else
                {
                    Console.WriteLine("You Feel the Vial in your pocket, Would you Like to put it back? Y/N");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You put the vial back on the shelf, it'll be here later if you need it.");
                        Backpack.Remove(Nitric);
                    }
                }
            }
            else if (Ans == "CITRIC ACID")
            {
                Item Citric = new Item("Citric Acid", 1);
                //Picking up Citric Acid.
                bool Hasitem = false;
                foreach (Item item in Backpack)
                {
                    if (item.Name == "Citric Acid") { Hasitem = true; }
                    else { Hasitem = false; }
                }
                if (!Hasitem)
                {
                    Console.Write("That Citric Acid might be useful later, Do you take it with you? Y/N  ");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" && Ans == "YES")
                    {
                        Console.WriteLine("You pocket the Citric Acid Bottle");
                        Backpack.Add(Citric);
                    }
                    else { Console.WriteLine("You back away from the shelf, Might be best to leave that here."); }
                }
                //Already Have Citric Acid
                else
                {
                    Console.WriteLine("You Feel the Bottle in your pocket, Would you Like to put it back? Y/N");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You put the Bottle back on the shelf, it'll be here later if you need it.");
                        Backpack.Remove(Citric);
                    }
                }
            }
            else if (Ans == "ACETIC ACID")
            {
                Item Acetic = new Item("Acetic Acid", 1);
                //Picking up Acetic Acid.
                bool Hasitem = false;
                foreach (Item item in Backpack)
                {
                    if (item.Name == "Acetic Acid") { Hasitem = true; }
                    else { Hasitem = false; }
                }
                if (!Hasitem)
                {
                    Console.Write("That Acetic Acid might be useful later, Do you take it with you? Y/N  ");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You pocket the Acetic Acid Jar");
                        Backpack.Add(Acetic);
                    }
                    else { Console.WriteLine("You back away from the shelf, Might be best to leave that here."); }
                }
                //Already Have Acetic Acid
                else
                {
                    Console.WriteLine("You Feel the Jar in your pocket, Would you Like to put it back? Y/N");
                    Ans = Console.ReadLine().ToUpper();
                    if (Ans == "Y" || Ans == "YES")
                    {
                        Console.WriteLine("You put the Jar back on the shelf, it'll be here later if you need it.");
                        Backpack.Remove(Acetic);
                    }
                }
            }
            else { Console.WriteLine("It doesn't seem like you can use that here."); }
        }
        //OPEN
        else if (Ans == "Open")
        {
            Console.WriteLine("there aren't any doors to open here.");
        }
        //Move/TRAVEL
        else if (Ans == "MOVE" || Ans == "TRAVEL")
        {
            Console.WriteLine("Where Would you Like to go?");
            Console.WriteLine($"1. {DoorsOpen[0]}\n2. {DoorsOpen[1]}\n3. {DoorsOpen[2]}\n4. {DoorsOpen[3]}\n5. {DoorsOpen[4]}\n6. BACK");
            Console.Write("Your Selection: ");
            try
            {
                roomselect = Convert.ToInt32(Console.ReadLine());
                switch (roomselect)
                {
                    case 1:
                        room = 0;
                        break;
                    case 2:
                        if (DoorsOpen[1] == "Closet") { room = 1; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 3:
                        if (DoorsOpen[2] == "Lobby") { room = 2; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 4:
                        if (DoorsOpen[3] == "The Core's Chamber") { room = 3; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 5:
                        if (DoorsOpen[4] == "Outside") { room = 4; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
        else if (Ans == "INVENTORY") { CheckInventory(); }
        else if (Ans == "SAVE") {SAVEGAME();}
        else { Console.WriteLine("I don't understand your input, Please check the README File for a List of Commands."); }
    }
    public void Lobby()
    {
        //Important Contents: PUZZLE, Door to Core.
        //Connects to: Foyer (S) Hallway(L2 N)  (L1 N)
        Console.WriteLine("\n You're in the Lobby, Amidst the Marble columns and prestine tiled floor you see A STAIRCASE leading to a second floor along the northern wall, As well as a Large, Menacing DOOR, in the dead center of the northern wall. Along the Eastern wall is a large pile of RUBBLE, along the Western wall is a Standalone OPENING.");
        Console.Write("What Would you like to do?\n> ");
        Ans = Console.ReadLine().ToUpper();
        if (Ans == "APPROACH")
        {
            Console.Write("What Would You Like to APPROACH? > ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "STAIRCASE")
            {
                Console.WriteLine("You try to Climb the stairs to get a better view of whats at the top. But it seems the landing has collapsed, leaving the upper floors inaccesible.");
            }
            else if (Ans == "RUBBLE")
            {
                Console.WriteLine("You Look at the rubble, in the cleanliness of the surrounding room, it seems out of place. Beneath it you see the remains of a door. \n Whatever's keeping clean around here might be a new addition.");
            }
            else if (Ans == "DOOR")
            {
                Console.WriteLine("You look up at the Grand Door, Aside from it's bulk, the most notable feature would have to be the lock in the center. At first it seems like the keyhole is missing, but after a closer glance you can see a small, needle sized hole in the top of the lock. A Coppery sheen can be seen inside.\nThere's a PAPER on the ground nearby...");
            }
            else if (Ans == "OPENING")
            {
                Console.WriteLine("You peer into the Opening, Inside is a solid wall with a small recess, about a foot across in depth, width, and height.\nYou notice a faint circle pressed on the platforms base. Something must have sat here for a while to leave a mark");
            }
            else if (Ans == "PAPER")
            {
                Console.WriteLine("You pick up the paper by the Grand door, It seems to be notes on the lock. \"No Keys in this wretched place! If I didn't know any better I'd say the maker wanted the lock broken. Only thing is the shells too thick to crack it.\nMust be a liquid key, I'll-\" \nThe Notes cut off there.");
            }
            else
            {
                Console.Write("You try to find That, but can't seem to... [Invalid Input. Please Input The CAPITALIZED words.]");
            }
        }
        else if (Ans == "USE" || Ans == "ACTIVATE")
        {
            Console.Write("What would you like to USE/ACTIVATE?\n> ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "NITRIC ACID")
            {
                UseNitric();
            }
            else if (Ans == "CITRIC ACID")
            {
                UseCitric();
            }
            else if (Ans == "ACETIC ACID")
            {
                UseAcetic();
            }
            else { Console.WriteLine("It doesn't seem like you can use that here."); }
        }
        else if (Ans == "OPEN")
        {
            Console.Write("What Would you Like to Open?\n> ");
            Ans = Console.ReadLine().ToUpper();
            if (Ans == "DOOR")
            {
                if (puzzle == true)
                {
                    Console.WriteLine("You Push open the massive door, Inside you see the glow eminating off the core.");
                    DoorsOpen[3] = "The Core's Chamber";
                }
                else { Console.WriteLine("You try and force the Door. Something inside clicks agaist the pressure and holds fast. You'll have to get through that lock first."); }
            }
            else { Console.WriteLine("You can't do that here."); }
        }
        else if (Ans == "MOVE" || Ans == "TRAVEL")
        {
            Console.WriteLine("Where Would you Like to go?");
            Console.WriteLine($"1. {DoorsOpen[0]}\n2. {DoorsOpen[1]}\n3. {DoorsOpen[2]}\n4. {DoorsOpen[3]}\n5. {DoorsOpen[4]}\n6. BACK");
            Console.Write("Your Selection: ");
            try
            {
                roomselect = Convert.ToInt32(Console.ReadLine());
                switch (roomselect)
                {
                    case 1:
                        room = 0;
                        break;
                    case 2:
                        if (DoorsOpen[1] == "Closet") { room = 1; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 3:
                        if (DoorsOpen[2] == "Lobby") { room = 2; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 4:
                        if (DoorsOpen[3] == "The Core's Chamber") { room = 3; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    case 5:
                        if (DoorsOpen[4] == "Outside") { room = 4; }
                        else { Console.WriteLine("You Must Discover That Room First!"); }
                        break;
                    default:
                        break;
                }
            }
            catch
            {

            }
        }
        else if (Ans == "INVENTORY") { CheckInventory(); }
        else if (Ans == "SAVE") {SAVEGAME();}
        else { Console.WriteLine("I don't understand your input, Please check the README File for a List of Commands."); }
    }

    // private void template()
    // {
    //     //Important Contents:
    //     //Connects to:
    //     Console.WriteLine("Intro");
    //     Console.Write("What Would you like to do?\n> ");
    //     Ans = Console.ReadLine().ToUpper();
    //     if (Ans == "APPROACH")
    //     {
    //         Console.Write("What Would You Like to APPROACH? > ");
    //         Ans = Console.ReadLine().ToUpper();
    //         if (Ans == "DOORS")
    //         {
    //             Console.WriteLine("");
    //         }
    //         else if (Ans == "COATS")
    //         {
    //             Console.WriteLine("");
    //         }
    //         else
    //         {
    //             Console.Write("You try to find That, but can't seem to... [Invalid Input. Please Input The CAPITALIZED words.]");
    //         }
    //     }
    //     else if (Ans == "USE" && Ans == "ACTIVATE")
    //     {
    //         Console.Write("What would you like to USE/ACTIVATE?\n> ");
    //         Ans = Console.ReadLine().ToUpper();
    //         //Nothing to be used here
    //         Console.WriteLine("It doesn't seem like you can use that here.");
    //     }
    //     else if (Ans == "Open")
    //     {
    //         Console.Write("What Would you Like to Open?\n> ");
    //         Ans = Console.ReadLine().ToUpper();
    //         if (Ans == "DOORS")
    //         {
    //             Console.WriteLine();
    //             DoorsOpen[1] = "Lobby";
    //         }
    //         else if (Ans == "WOOD DOOR") { }
    //         else { Console.WriteLine("You can't do that here."); }
    //     }
    //     else if (Ans == "MOVE" && Ans == "TRAVEL")
    //     {
    //         Console.WriteLine("Where Would you Like to go?");
    //         Console.WriteLine($"1. {DoorsOpen[0]}\n2. {DoorsOpen[1]}\n3. {DoorsOpen[2]}\n4. {DoorsOpen[3]}\n5. {DoorsOpen[4]}\n6. {DoorsOpen[5]}\n7. BACK");
    //         Console.Write("Your Selection: ");
    //         try
    //         {
    //             roomselect = Convert.ToInt32(Console.ReadLine());
    //             switch (roomselect)
    //             {
    //                 case 1:
    //                     room = 1;
    //                     break;
    //                 case 2:
    //                     if (DoorsOpen[1] == "Closet") { room = 1; }
    //                     else { Console.WriteLine("You Must Discover That Room First!"); }
    //                     break;
    //                 case 3:
    //                     if (DoorsOpen[2] == "Lobby") { room = 2; }
    //                     else { Console.WriteLine("You Must Discover That Room First!"); }
    //                     break;
    //                 case 4:
    //                     if (DoorsOpen[3] == "Hallway") { room = 3; }
    //                     else { Console.WriteLine("You Must Discover That Room First!"); }
    //                     break;
    //                 case 5:
    //                     if (DoorsOpen[4] == "The Core's Chamber") { room = 4; }
    //                     else { Console.WriteLine("You Must Discover That Room First!"); }
    //                     break;
    //                 case 6:
    //                     if (DoorsOpen[5] == "Outside") { room = 5; }
    //                     else { Console.WriteLine("You Must Discover That Room First!"); }
    //                     break;
    //                 default:
    //                     break;
    //             }
    //         }
    //         catch
    //         {

    //         }
    //     }
    //     else if (Ans == "INVENTORY") { CheckInventory(); }
    //     else { Console.WriteLine("I don't understand your input, Please check the README File for a List of Commands."); }

    // }
}