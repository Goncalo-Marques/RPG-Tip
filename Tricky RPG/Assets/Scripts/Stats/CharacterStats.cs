using System;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int CurrentHealth { get; private set; }

    public Stat damage;
    public Stat armor;

    public Action<int, int> OnHealthChanged;

    private void Awake()
    {
        CurrentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        CurrentHealth -= damage;

        if (OnHealthChanged != null)
        {
            OnHealthChanged(maxHealth, CurrentHealth);
        }

        if (CurrentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {

    }
}
