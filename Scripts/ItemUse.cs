using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemUse : MonoBehaviour
{
    public Item item; // The item to use

    public void Use()
    {
        // Apply the item's effect
        // Remove the item from the inventory
        InventoryManager inventoryManager = GetComponent<InventoryManager>();
        if (inventoryManager != null)
        {
            inventoryManager.RemoveItem(item);
            Debug.Log("Item used");
        }
    }
}

