using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditBlaster : Ability
{       
    // Constructor that passes the name to the base class
    public BanditBlaster(string Name) : base(Name)
    {
        
    }

    // Properly overriding the abstract Cast method
    public override void Cast(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex)
    {
        foreach (Character ch in enemyList)
        {
            ch.set_hp(ch.get_hp() - 10000000); // Inflict massive damage
        }
    }
}