using System;
using System.Collection.Generic;

public class Personnage {

    private int hp;
    private int damage;
    private int armor;
    private float moveSpeed;

    public int HP { get => hp ; set => hp = value; }
    public int Armor { get => armor ; set => armor = value; }

    public Personnage(int hp, int damage, int armor, int moveSpeed)
    {
        this.hp = hp;
        this.damage = damage;
        this.armor = armor;
        this.moveSpeed = moveSpeed;
    }

    public void Attack(Personnage personnage)
    {
        if (armor < damage)
            personnage.HP -= damage - armor;
    }
}