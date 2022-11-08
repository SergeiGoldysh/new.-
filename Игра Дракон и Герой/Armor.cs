using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Armor
{
    public string Name { get; set; }
    public double PhDefence { get; set; }
    public double MagDefence { get; set; }


    public double DragonScales()
    {
        Random rand = new Random();
        double damage = rand.Next(5, 20);
        return damage;

    }

    public double ShieldOfHeaven()
    {
        Random rand = new Random();
        double magdefence = rand.Next(190, 280);
        return magdefence;
    }


}
