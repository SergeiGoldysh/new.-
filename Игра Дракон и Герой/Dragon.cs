using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

public class Dragon
{
    public string Name { get; set; }
    public double HP { get; set; }
    public double Damage { get; set; }
    public double Mana { get; set; }
    public double Armor { get; set; }
    

    public Dragon(string name, double hp)
    {
        Name = name;
        HP = hp;
    }



 

    public void Incinerate(Hero Artur)
    {
        Console.WriteLine($"dragon applies Incinerate");
        Random rand = new Random();
        double damage = rand.Next(200, 300);

        Armor ar = new Armor();
        double sh = ar.ShieldOfHeaven();
        Console.WriteLine($"Artur uses shield of heaven");
        if (damage > sh)
        {
            damage -= sh;
        }
        else
        {
            damage = 0;
        }

        TakeDamage(damage, Artur);

    }

    public void TakeDamage(double dmg, Hero Artur)
    {
        
        
        Artur.HP -= dmg;


        if (Artur.HP <= 0)
        {
            Console.WriteLine($"{Artur.Name} fucking dies, because hi is a stupid bum!");
            Console.WriteLine("You lost.\nGame over!");
            Process.GetCurrentProcess().Kill();
        }
        else
        {
            Console.WriteLine($"Arthur survives, incredible!\nThe hero has {Artur.HP} health");
        }
        
    }

    public void Eat(Hero Artur)
    {
        Console.WriteLine("The dragon grabs Arthur in the mouth ooooh nooo!");
        Random rand = new Random();
        double damage = rand.Next(100, 200);
        Console.WriteLine("Death in the stomach of a dragon, what could be worse....");
        TakeDamage(damage, Artur);
    }
}



