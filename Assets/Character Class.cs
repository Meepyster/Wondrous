using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace wonderouse {

    public class Character : MonoBehaviour
    {
        string name;
        double hp;
        double atk;
        double def;
        double spd;
        bool is_alive;
        double c_rate;
        double c_dmg;
        Ability[] ability;
        double ev_rate;
        static int ov_counter = 0;
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
                this.name = "Bandit" + ov_counter;
                ov_counter += 1;
            }
        }
        public Character(): this("", 1000, 100, 10, 10, true, 10, 10, new Ability[1], 10)
        {
            // overload to default when there are no arguments
        }
        // Setters
        public void set_hp(double hp) { this.hp = hp; }
        public void set_atk(double atk) { this.atk = atk; }
        public void set_def(double def) { this.def = def; }
        public void set_spd(double spd) { this.spd = spd; }
        public void set_c_rate(double c_rate) { this.c_rate = c_rate; }
        public void set_c_dmg(double c_dmg) { this.c_dmg = c_dmg; }
        public void set_ev_rate(double ev_rate) { this.ev_rate = ev_rate; }

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
}