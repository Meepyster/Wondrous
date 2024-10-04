using System;
class Main {
    static void Main (string[] args){
        Bandit ally = new Bandit();
        Bandit enemy = new Bandit();
        Character[] allyList = Character[1];
        Character[] enemyList = Character[1];
        allyList[1] = ally;
        enemyList[1] = enemy;
        ally.attack(0, allyList, enemyList, 0, 0);
        Console.WriteLine(enemy.get_hp);
    }
})