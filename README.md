# Interface Practice 

This repository is meant for my personal use. I created it with the purpose of enhancing my coding skills and exploring game development.

Interface Script:

Note: I can use IEntity and include both of this.  But for the sake of practicing, I separate them.
``` c#
public interface IHeal
{
    void Heal(int healAmount);
}

public interface IDamage
{
    void Damage(int damageAmount);
}
````
Mono Script:
``` c#
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Entity : MonoBehaviour, IDamage, IHeal
{
    [SerializeField] int health = 100;
    [SerializeField] TextMeshProUGUI textUI;
    int currentHealth;
    private void Awake()
    {
        currentHealth = health;
    }
    private void Start()
    {
        textUI.text = $"Current health: {currentHealth}";
    }
    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        textUI.text = $"Current health: {currentHealth}";
        if (currentHealth <= 0)
        {
            textUI.text = "You're Dead !";
        }
    }
    public void Heal(int healAmount)
    {
        if (currentHealth == 100) return;
        currentHealth += healAmount;
        textUI.text = $"Current health: {currentHealth}";
    }

}
```
