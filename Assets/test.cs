using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
class test {
    static void Main (string[] args){
        Bandit ally = new Bandit();
        Bandit enemy = new Bandit();
        Character[] allyList = new Character[1];
        Character[] enemyList = new Character[1];
        allyList[1] = ally;
        enemyList[1] = enemy;
        ally.Attack(0, allyList, enemyList, 0, 0);
        Console.WriteLine(enemy.get_hp());
    }
}