public class Bandit : Character{
    Ability[] abilities = new  Ability[2];
    BanditBlaster a = new BanditBlaster();
    BanditBlaster b = new BanditBlaster();
    abilities[0] = a;
    abilities[1] = b;
    public Bandit : base("Bandit", 1000.0, 100, 10, 10, true, .3, .5, abilities, .05){

    }
}