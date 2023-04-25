using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour
{

    public static InventoryManager Instance; // bus singleton


    public List<Item> Items = new List<Item>(); // A list of items in the inventory
    public int maxInventorySize = 14; // The maximum number of items that can be held in the inventory

    public Transform ItemContent;
    public GameObject InventoryItem;


    public void Awake()
    {
        Instance = this;
    }

    // This method adds an item to the inventory
    public void AddItem(Item item)
    {
        if (Items.Count < maxInventorySize)
        {
            Items.Add(item);
            // Update the UI to show the new item in the inventory
            // You can implement this method yourself, or use a third-party UI library like Inventory Pro or uGUI-Inventory
        }
        else
        {
            Debug.Log("Inventory is full!");
        }
    }

    // This method removes an item from the inventory
    public void RemoveItem(Item item) {
        Items.Remove(item);
        // Update the UI to remove the item from the inventory
        // You can implement this method yourself, or use a third-party UI library like Inventory Pro or uGUI-Inventory
    }

    public void ListItems()   {
        foreach (var item in Items)      {

            GameObject obj = Instantiate(InventoryItem, ItemContent);
            var itemName = obj.transform.Find("ItemName").GetComponent<TextMeshProUGUI>();
            var itemIcon = obj.transform.Find("ItemIcon").GetComponent<Image>();

            itemName.text = item.itemName;
            itemIcon.sprite = item.icon;
        }

    }

}
