using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public Inventory<IItem> playerInventory;

    private void Start()
    {
        playerInventory = new Inventory<IItem>();

        playerInventory.AddItem(new Weapon("Sword", 1, 10));
        playerInventory.AddItem(new Weapon("Small Potion", 2, 20));
    }

    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            playerInventory.ListItem();
        }

        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            playerInventory.UseItem(0);
        }
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            playerInventory.AddItem(new Weapon("Sword", 1, 10));
        }
    }
}
