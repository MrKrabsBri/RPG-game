using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public List<Item> inventory = new List<Item>(); // A list of items in the inventory
    public int maxInventorySize = 14; // The maximum number of items that can be held in the inventory

    // This method adds an item to the inventory
    public void AddItem(Item item)
    {
        if (inventory.Count < maxInventorySize)
        {
            inventory.Add(item);
            // Update the UI to show the new item in the inventory
            // You can implement this method yourself, or use a third-party UI library like Inventory Pro or uGUI-Inventory
        }
        else
        {
            Debug.LogWarning("Inventory is full!");
        }
    }

    // This method removes an item from the inventory
    public void RemoveItem(Item item)
    {
        inventory.Remove(item);
        // Update the UI to remove the item from the inventory
        // You can implement this method yourself, or use a third-party UI library like Inventory Pro or uGUI-Inventory
    }
}
