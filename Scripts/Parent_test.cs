using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Parent_test : MonoBehaviour
{
    protected int hp = 10;
    //// Start is called before the first frame update
    //void Start()
    //{

    //}

    //// Update is called once per frame
    //void Update()
    //{

    //}
    public abstract void Abstraktusmetodas();
    

    

    protected virtual void Calculatee(int a)
    {
        int galutinis = hp + a;
        Debug.Log(galutinis);
    }
}
