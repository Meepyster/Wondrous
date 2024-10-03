using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditBlaster : Ability {
    public BanditBlaster(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex){
        Console.WriteLine("ORAAAAA BANDIT BLASTER!!! EAT DIRT LIL' ****");
        foreach (Character ch in enemyListList){
            ch.set_hp(ch.get_hp - 10000000);
        }
    }
}