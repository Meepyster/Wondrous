using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Character : MonoBehaviour
{
        private string name;
        private double hp;
        private double atk;
        private double def;
        private double spd;
        private bool is_alive;
        private double c_rate;
        private double c_dmg;
        private Ability[] ability;
        private double ev_rate;
        private static int ov_counter = 0;
        public Character(string name, double hp, double atk, double def,
                         double spd, bool is_alive, double c_rate,
                         double c_dmg, Ability[] ability, double ev_rate)
        {
            this.name = name;
            this.hp = hp;
            this.atk = atk;
            this.def = def;
            this.spd = spd;
            this.is_alive = is_alive;
            this.c_rate = c_rate;
            this.c_dmg = c_dmg;
            this.ability = ability;
            this.ev_rate = ev_rate;
            if (this.name == "")
            {
                this.name = "Default" + ov_counter;
                ov_counter += 1;
            }
        }
        // public Character() : this("", 1000, 100, 10, 10, true, 10, 10, new Ability[1], 10)
        // {
        //     // overload to default when there are no arguments
        // }
        
        // public Character(string name)
        // {
        //     if (name == "Bandit")
        //     {
        //     this.name = "Bandit";
        //     this.hp = 1000;
        //     this.atk = 100;
        //     this.def = 10;
        //     this.spd = 10;
        //     this.is_alive = true;
        //     this.c_rate = 10;
        //     this.c_dmg = 10;
        //     this.ability = new Ability[0];
        //     this.ev_rate = 10;
        //     }
        // }
        // Setters
        // 2 attack methods,
        // 1 for custom moves -> This must search and grab the move (slow xd)
        // another for moves that are hard coded into character
        public void Attack(AbilityName ability, Character[] allyList, Character[] enemyList,
                        int castIndex, int targetIndex){
            // class calls abiltiy
            // passes this into the class
            // the ability does thr ewo
        }
        public void Attack(int index, Character[] allyList, Character[] enemyList,
                        int castIndex, int targetIndex){
        ability[index].Cast(allyList, enemyList, castIndex, targetIndex);
        }
        public void set_hp(double hp) { this.hp = hp; }
        public void set_atk(double atk) { this.atk = atk; }
        public void set_def(double def) { this.def = def; }
        public void set_spd(double spd) { this.spd = spd; }
        public void set_c_rate(double c_rate) { this.c_rate = c_rate; }
        public void set_c_dmg(double c_dmg) { this.c_dmg = c_dmg; }
        public void set_ev_rate(double ev_rate) { this.ev_rate = ev_rate; }
        public void set_abilitylist(Ability[] abilities) { this.ability = abilities; }

        // Getters
        public double get_hp() { return this.hp; }
        public double get_atk() { return this.atk; }
        public double get_def() { return this.def; }
        public double get_spd() { return this.spd; }
        public double get_c_rate() { return this.c_rate; }
        public double get_c_dmg() { return this.c_dmg; }
        public double get_ev_rate() { return this.ev_rate; }
        // Start is called before the first frame update


        // Update is called once per frame
}