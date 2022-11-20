using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healh : IHealth
{
    private const int minDamage = 1;
    public Healh(int health)
    {
        Health = health;
    }

    public int Health { get; set; }

    public void GetDamage(int damage)
    {
        Health -= damage;
    }

    public void GetDamage()
    { 
        if (Health <= 0)
        {
           // Destroy(gameObject); - ???
        }
        else
        {
            Health -= minDamage;
        }
    }
}
