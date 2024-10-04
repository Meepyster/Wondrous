using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Ability : MonoBehaviour {
/*    Character[] allyList;
    Character[] enemyList;
    int castIndex;
    int targetIndex;
    public Ability (Character[] allyList, Character[] enemyList, int castIndex, int targetIndex){
        // This will then call the required ability from searching through each case
        // With the enum
        this.allyList = allyList;
        this.enemyList = enemyList;
        this.castIndex = castIndex;
        this.targetIndex = targetIndex; 
    }*/

    public Ability()
    {
        //why does this work???????????
    }

    public abstract void Cast(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex);

}
