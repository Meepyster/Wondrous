using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : MonoBehaviour
{
    public string Name;

    // Constructor that accepts a name
    public Ability(string Name)
    {
        this.Name = Name;
    }

    // Abstract method that derived classes must implement
    public abstract void Cast(Character[] allyList, Character[] enemyList, int castIndex, int targetIndex);
}
