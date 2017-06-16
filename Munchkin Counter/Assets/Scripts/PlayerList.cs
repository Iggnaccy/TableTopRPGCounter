using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class PlayerList
{
    public static int playerCount = 2;
    public static List<string> names;
    public static List<int> level, power;
    public static int activePlayer = 0;

    public static void CreatePlayer(string name)
    {
        if(names == null)
        {
            names = new List<string>();
            level = new List<int>();
            power = new List<int>();
        }
        names.Add(name);
        level.Add(1);
        power.Add(0);
    }
}
