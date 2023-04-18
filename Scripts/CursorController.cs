using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{

    public Texture2D cursor;
    public Texture2D cursorClicked;
   

    private CursorControls controls;

    private Camera mainCamera;

    private void Awake()
    {
        controls = new CursorControls();
        ChangeCursor(cursor);
        //Cursor.lockState = CursorLockMode.Confined; //cursor liks on screen visa laika, kol kas kol kuriu nereikalingas. ctrl+P to stop game
        mainCamera = Camera.main;
    }

    private void OnEnable()
    {
        controls.Enable();
    }

    private void OnDisable()
    {
        controls.Disable();
    }

    // Start is called before the first frame update
    private void Start()
    {
        controls.Mouse.Click.started += _ => StartedClick();
        controls.Mouse.Click.performed += _ => EndedClick();
    }

    private void StartedClick()
    {
        ChangeCursor(cursorClicked);
    }

    private void EndedClick()
    {
        ChangeCursor(cursor);
        DetectObject();
    }

    private void DetectObject()
    {
        
        Ray ray = mainCamera.ScreenPointToRay(controls.Mouse.Position.ReadValue<Vector2>());
        RaycastHit2D hits2D = Physics2D.GetRayIntersection(ray);
        if (hits2D.collider != null)
        {
            IClick click = hits2D.collider.GetComponent<IClick>(); //testing pagal video
            if (click != null)
                click.onClickAction();
            Debug.Log("Hit 2D Collider" + hits2D.collider.tag);
        }
        //pries tai ray sustodavo ties pirmu gameobject, sitas castins ray toliau
        RaycastHit2D[] hits2DAll = Physics2D.GetRayIntersectionAll(ray);
        for (int i = 0; i < hits2DAll.Length; i++)
        {
            if (hits2DAll[i].collider != null)
            {
                Debug.Log("2D Hit All:" + hits2DAll[i].collider.tag);
            }
        }

        RaycastHit2D[] hits2DAllNonAlloc = new RaycastHit2D[1];
            int numberOfHits2D =  Physics2D.GetRayIntersectionNonAlloc(ray, hits2DAllNonAlloc);
        for (int i = 0; i < hits2DAllNonAlloc.Length; i++)
        {
            if (hits2DAllNonAlloc[i].collider != null)
            {
                Debug.Log("2D Hit Non Alloc All:" + hits2DAllNonAlloc[i].collider.tag);
            }
        }
    }

	

	

    private void ChangeCursor(Texture2D cursorType)
    {
        Cursor.SetCursor(cursorType, Vector2.zero, CursorMode.Auto);
    }




    // Update is called once per frame
    void Update()
    {
        
    }
}
