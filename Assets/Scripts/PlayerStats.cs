using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    [Range(0, 100)]
    public int health = 100;
    [Range(0, 100)]
    public int armor = 0;

    public HealthBar healthBar;

    void Update()
    {        
        healthBar.SetHealth(health);
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        healthBar.SetHealth(health);
    }
}
