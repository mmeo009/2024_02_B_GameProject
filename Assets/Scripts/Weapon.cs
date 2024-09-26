using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Weapon : IItem
{
        public string Name { get;private set; }
        public int ID { get; private set; }

        public int Damage {  get; private set; }

        public Weapon(string name, int id, int damage)
        {
            this.Name = name;
            this.ID = id;
            this.Damage = damage;
        }
        public void Use()
        {
            Debug.Log($"Using Item {Name} with damage {Damage}");
        }
}
