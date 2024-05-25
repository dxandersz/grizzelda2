using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResourceState : MonoBehaviour
{

    public string effect = null;
    public int charges = 3;
    public string ingredientName;
    // Start is called before the first frame update
    void Start()
    {
        string objectName = gameObject.name;
        Debug.Log("Object Name: " + objectName + " \nObject Effect: " + effect + " \nObject Charges: " + charges);
        //Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
