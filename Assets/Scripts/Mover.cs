using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    public Vector3 direction = Vector3.up;
    float speed = 0.1f;

    // Update is called once per frame
    void Update()
    {
        var movement = direction * speed;
        movement *= Time.deltaTime;
        this.transform.Translate(movement);
    }
}
