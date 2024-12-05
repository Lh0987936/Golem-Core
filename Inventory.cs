using System;
using System.Collections.Generic;
using System.Linq;
//Controls how Items work, Inventory list is in Variables.
public class Item
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public Item(string name, int amount)
    {
        Name = name;
        Amount = amount;
    }

    public override string ToString()
    {
        return $"{Name}|{Amount}";
    }
}
