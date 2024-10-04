/*public class Bandit : Character{
    Ability[] abilities = new  Ability[2];
    BanditBlaster a = new BanditBlaster();
    BanditBlaster b = new BanditBlaster();
    abilities[0] = a;
    abilities[1] = b;
    public Bandit : base("Bandit", 1000.0, 100, 10, 10, true, .3, .5, abilities, .05){

    }
}*/
public class Bandit : Character
{
    Ability[] abilities;
    BanditBlaster a;
    BanditBlaster b;

    public Bandit() : base("Bandit", 1000.0, 100, 10, 10, true, 0.3, 0.5, null, 0.05)
    {
        // Initialize abilities array and abilities here
        abilities = new Ability[2];
        a = new BanditBlaster();
        b = new BanditBlaster();
        abilities[0] = a;
        abilities[1] = b;

        // Pass the abilities to the base constructor
        base.set_abilitylist(abilities);
    }
}