using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : IItem
{
    public string Name { get; private set; }

    public int ID { get; private set; }

    public int HealAmount { get; private set; }

    public HealthPotion(string name, int id, int healAmount)
    {
        this.Name = name;
        this.ID = id;
        this.HealAmount = healAmount;
    }

    public void Use()
    {
        Debug.Log($"Using Item {Name} with damage {HealAmount}");
    }
}
