using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Opened, IClick
{
    public Sprite emptyChest;
    public int coinAmount = 10;

    //protected override void OnCollect()
    //{
    //    if (!collected)
    //    {
    //        collected = true;
    //        //GetComponent<SpriteRenderer>().sprite = emptyChest;
    //        Debug.Log("You found " + coinAmount + "coins!");
    //    }
    //}

    public void onClickAction()
    {
        Debug.Log("Atsidaro Loot window");
        // GetComponent<SpriteRenderer>().sprite = emptyChest;
        Destroy(gameObject);
    }
}
