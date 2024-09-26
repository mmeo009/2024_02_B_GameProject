using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IItem
{
    string Name { get; }
    int ID { get; }
    void Use();
}

public class Inventory<T> where T : IItem
{
    private List<T> items = new List<T>();

    public void AddItem(T item)
    {
        items.Add(item);
        Debug.Log($"Add {item.Name} to inventory");
    }

    public void UseItem(int Index)
    {
        if (Index >= 0 && Index < items.Count)
        {
            items[Index].Use();
        }
        else
        {
            Debug.Log("Invalid item index");
        }
    }

    public void ListItem()
    {
        foreach (var item in items)
        {

            Debug.Log($"Item : {item.Name}, ID : {item.ID}");
        }
    }
}
