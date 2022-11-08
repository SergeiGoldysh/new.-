
using System.Data;
using System.Runtime.InteropServices;
using System.Xml.Linq;

bool name = false;
string nameHero = "";

do
{
    Console.WriteLine("Enter your desired character name:");
    string enterName = Console.ReadLine();

    try
    {
        if (enterName != "Artur")
        {
            throw new Exception("The name of the hero does not match the lore" +
                " of the game.According to the story," +
                " the hero's name is Artur");

        }
        else
        {
            nameHero = enterName;
            name = true;
        }
    }
    catch (Exception heroName)
    {
        Console.WriteLine(heroName);
    }
} while (name == false);

double count = 0;
double hpHero = 0;

do
{
    Console.WriteLine("Enter the hero's health");
    
    while (!double.TryParse(Console.ReadLine(), out count))
    {
        Console.WriteLine("Enter health in numbers. According to the rules of the game," +
            " the amount of health of the hero must be 100.");
    }

    try
    {
        if (count != 100)
        {
            throw new Exception("The health of the hero does not correspond" +
                " to the conditions of the game. Should be 100");
        }

        else
        {
            hpHero = count;
            Console.WriteLine($"Congratulations you have created a character {nameHero} with health {hpHero}.");
        }
    }
    catch (Exception heroHp)
    {
        Console.WriteLine(heroHp);
    }
} while (hpHero != count);


//Dragon

bool nameDr = false;
string nameDragon = "";

do
{
    Console.WriteLine("Enter the name of the Evil Dragon:");
    string enterName1 = Console.ReadLine();

    try
    {
        if (enterName1 != "Sapfiron")
        {
            throw new Exception("According to the story of the game, " +
                "the dragon the hero fights is called Sapfiron");

        }
        else
        {
            nameDragon = enterName1;
            nameDr = true;
        }
    }
    catch (Exception drName)
    {
        Console.WriteLine(drName);
    }
} while (nameDr == false);

double count1 = 0;
double hpDragon = 0;

do
{
    Console.WriteLine("Enter the amount of dragon health:");

    while (!double.TryParse(Console.ReadLine(), out count1))
    {
        Console.WriteLine("Enter health in numbers. By the rules of the game" +
            "Dragon health should be 500");
    }

    try
    {
        if (count1 != 500)
        {
            throw new Exception("The health of the dragon does not match the " +
                "conditions of the game. Should be 500");
        }

        else
        {
            hpDragon = count1;
            Console.WriteLine($"Congratulations, you have created the " +
                $"dragon villain {nameDragon} with health {hpDragon}.");
            
        }
    }
    catch (Exception drHp)
    {
        Console.WriteLine(drHp);
    }
} while (hpDragon != count1);








Hero artur = new Hero(nameHero, hpHero);
Dragon sapfiron = new Dragon(nameDragon, hpDragon);

Console.WriteLine(artur.Name);
Console.WriteLine(artur.HP);
Console.WriteLine(sapfiron.Name);
Console.WriteLine(sapfiron.HP);

Weapon e = new Weapon();
e.Name = "Excalibur";
e.Damage = e.Excalibur();

artur.Inventory.Add(e);

double ex = artur.Inventory.Where(x => x.Name == "Excalibur").First().Damage;

artur.Bite(sapfiron);

sapfiron.Incinerate(artur);

artur.Swordstrike(sapfiron);

sapfiron.Eat(artur);