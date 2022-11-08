using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

public class Hero
{
    public string Name { get; set; }
    public double HP { get; set; }
    public double Mana { get; set; }
    public List<Weapon> Inventory = new List<Weapon>();
    
    public List<Armor> Armor { get; set; }

    public Hero(string name, double hp)
    {
        Name = name;
        HP = hp;
    }

    

    public double Bite(Dragon saph)
    {
        Console.WriteLine($"{Name} bites {saph.Name}");
        Random rand = new Random();
        double damage = rand.Next(5, 15);
        saph.HP -= damage;
        Console.WriteLine($"The dragon has {saph.HP} health left");
        return saph.HP;
        

    }
    public void TakeDamage(double dmg, Dragon Sapfiron)
    {
        Sapfiron.HP -= dmg;


        if (Sapfiron.HP <= 0)
        {
            Console.WriteLine($"{Sapfiron.Name} died");
            Console.WriteLine("You have won!\nOur congratulations!");
            Process.GetCurrentProcess().Kill();
        }
        else
        {
            Console.WriteLine($"The dragon has {Sapfiron.HP} health"); 
        }
        
    }
   

    public void Swordstrike(Dragon saph)
    {
        Console.WriteLine($"Arthur draws a sword!! SWORD???" +
            $"\n If he has a sword why did he bite the dragon?!" +
            $"\n This is the legendary Excalibur!{Name} crushes {saph.Name}!!!");
        Weapon exc = new Weapon();
        double swordattack = exc.Excalibur();
        
        TakeDamage(swordattack, saph);
        


    }
}
