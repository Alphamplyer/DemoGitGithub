using System;
using System.Collection.Generic;

public abstract class Weapon
{
    public abstract bool IgnoreArmor; 

    public abstract void GetDamage(Personnage personnage)
}