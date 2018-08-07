using System;
using System.Collection.Generic;

public class Personnage {

    private int hp;
    private int armor;
    private float moveSpeed;
    private Weapon firstWeapon;


    public int HP { get => hp ; set => hp = value; }
    public int Armor { get => armor ; set => armor = value; }
    public Weapon FirstWeapon { get => firstWeapon; set => firstWeapon = value; }

    public Personnage(int hp, int armor, int moveSpeed, Weapon firstWeapon)
    {
        this.hp = hp;
        this.armor = armor;
        this.moveSpeed = moveSpeed;
        this.firstWeapon = firstWeapon;
    }

    public void Attack(Personnage personnage)
    {
        if (armor < firstWeapon.GetDamage())
            personnage.HP -= firstWeapon.GetDamage() - armor;
    }
}