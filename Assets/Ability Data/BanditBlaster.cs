using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BanditBlaster : Ability {
    Character[] allyList;
    Character[] enemyList;
    int castIndex;
    int targetIndex;
    public BanditBlaster(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex){
        this.allyList = allyList;
        this.enemyList = enemyList;
        this.castIndex = castIndex;
        this.targetIndex = targetIndex;
    }
    public void cast (){
        foreach (Character ch in enemyListList){
            ch.set_hp(ch.get_hp - 10000000);
        }
    }
}