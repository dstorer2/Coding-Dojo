// See https://aka.ms/new-console-template for more information
namespace WizNinSam
{
    class Program
    {
        static void Main(string[] args) 
        {
            Wizard sbeve = new Wizard("Sbeve");
            Samuri jack = new Samuri("Jack");
            Ninja jeffery = new Ninja("Jeffery");
            jeffery.GetInfo();
            jack.Attack(sbeve);
            sbeve.Attack(jeffery);
            jeffery.Steal(jack);
            jack.Attack(sbeve);
            sbeve.Attack(jeffery);
            jeffery.Steal(jack);
            jack.Attack(sbeve);
            sbeve.Attack(jeffery);
            jeffery.Steal(jack);
        }
    }
}

