using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleSingleton : MonoBehaviour
{
    public static SimpleSingleton instance;

    void Awake()
    {
        instance = this;
    }
    public void DoSomething()
    {
        Debug.Log("I'm a singleton! Hiya!");
    }
    void Start()
    {
        SimpleSingleton.instance.DoSomething();
    }

    //SimpleSingleton.instance.DoSomething();
}
