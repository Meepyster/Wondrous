using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditBlaster : Ability {
    // Character[] allyList;
    // Character[] enemyList;
    // int castIndex;
    // int targetIndex;
    public BanditBlaster() : base()
    {
        // this.allyList = allyList;
        // this.enemyList = enemyList;
        // this.castIndex = castIndex;
        // this.targetIndex = targetIndex;
    }
    public override void Cast(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex)
    {
        foreach (Character ch in enemyList){
            ch.set_hp(ch.get_hp() - 10000000);
        }
    }
}