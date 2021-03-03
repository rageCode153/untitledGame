using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public PlayerStats playerStats;

    private void Start()
    {
        slider.maxValue = playerStats.health;
        slider.value = playerStats.health;
    }

    public void SetHealth(int health)
    {
        slider.value = health;
    }    
}
