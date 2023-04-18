using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private BoxCollider2D boxCollider;
    private Vector3 moveDelta;
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        // REset movedelta
       // moveDelta = Vector3.zero;

        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        //Debug.Log(x);
        //Debug.Log(y);

        moveDelta = new Vector3(x, y, 0);
        if (moveDelta.x > 0)
            transform.localScale = new Vector3(-1.5f, 1.5f, 0);
        else if (moveDelta.x < 0)
            transform.localScale = new Vector3(1.5f, 1.5f, 0);

        //move
        transform.Translate(moveDelta * Time.deltaTime);

    }
}
