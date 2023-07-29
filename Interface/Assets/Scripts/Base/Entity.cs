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
