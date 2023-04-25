using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    public Item Item; // The item to add to the player's inventory

    void Pickup()
    {
        InventoryManager.Instance.AddItem(Item);
        Destroy(gameObject);
        Debug.Log("Item added to inventory");
    }

    private void OnMouseDown()
    {
        Pickup();
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        InventoryManager inventoryManager = other.GetComponent<InventoryManager>();
    //        if (inventoryManager != null)
    //        {
    //            inventoryManager.AddItem(item);
    //            Debug.Log("Item added to inventory");
    //            Destroy(gameObject); // Destroy the item pickup object
    //        }
    //    }
    //}
}
