using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opened : Collectable
{
    public Sprite openChest;
    //public int coinAmount = 10; nereikia cia 
    private bool LootPickedUp;

    //protected override void OnCollect()
    //{
    //    //if (!collected)
    //    //{
    //    //    collected = true;
    //    //    GetComponent<SpriteRenderer>().sprite = openChest;      
    //    //}
    //    collected = false;
    //    GetComponent<SpriteRenderer>().sprite = openChest;
    //}

    //protected virtual void PickUpLoot()
    //{
    //    LootPickedUp = false;
    //}
}
