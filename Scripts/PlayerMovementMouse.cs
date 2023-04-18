using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class PlayerMovementMouse : MonoBehaviour
{
    private const float DOUBLE_CLICK_TIME = .35f;
    public float speed = 10f;
    Vector2 lastClickedPos;
    //pakeitimai doubleclickui
    private float lastClickTime;
    bool moving;
    float timeSinceLastClick;
    bool doubleClickas;

    //testing kad nesokinetu prie colliderio, jei nesufixinsiu istrink
    public Rigidbody2D rb; 

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            moving = true;
            
            //Debug.Log("last clicked at : " + lastClickTime);
            timeSinceLastClick = Time.time - lastClickTime;
            //Debug.Log("time since last click : " + timeSinceLastClick);

            // ivesk dar first click mouse pos, ir jei antras click nenutoles pakankamai tada vykdyk actiona
            if (timeSinceLastClick <= DOUBLE_CLICK_TIME)
            {
                // Double Click!
                Debug.Log("double click");
                doubleClickas = true;
            }
            else
            {
                // Normal Click!
                Debug.Log("normal click");
                doubleClickas = false;
            }

        lastClickTime = Time.time;
        }



        if (moving && (Vector2)transform.position != lastClickedPos && doubleClickas )
        {
            float step = speed * Time.deltaTime;
            transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
          //  rb.velocity = new Vector2(transform.position, lastClickedPos);//, step);
        }
        else
        {
            moving = false;
        }
    }
    
}

