using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public string name;
    public string flavorText;
    public int logs;
    public int rocks;
    public int stars;

    public Item CreateItem(string name, string flavorText, int logs, int rocks, int stars)
    {
        Item item = new Item();
        item.name = name;
        item.flavorText = flavorText;
        item.logs = logs;
        item.rocks = rocks;
        item.stars = stars;

        return item;
    }
}
