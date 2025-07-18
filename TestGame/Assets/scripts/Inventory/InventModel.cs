using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventModel : MonoBehaviour
{
    public Dictionary<string,int> items = new();


    public event System.Action OnInventoryChanged;
    
    public void AddItem(string id, int count)
    {
        
        if (items.ContainsKey(id))
        {
            items[id] += count;
            return;
        }
        else
        {
            items.Add(id, count);
        }
        OnInventoryChanged?.Invoke();
    }

    public Dictionary<string, int> GetItems()
    {
        return items;
    }
    public void DeleteItem(string id, int count)
    {
        if (items.ContainsKey(id)) 
        {
            items[id] -= count;
            if (items[id] <= 0)
            {
                items.Remove(id);
            }
        }
        OnInventoryChanged?.Invoke();
    }




    
}
