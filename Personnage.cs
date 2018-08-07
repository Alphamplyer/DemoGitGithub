using System;
using System.Collection.Generic;

public class Personnage {

    private int hp;
    private int damage;
    private float moveSpeed;

    public int HP { get => hp ; set => hp = value; }

    public void Attack(Personnage personnage)
    {
        personnage.HP -= damage;
    }
}