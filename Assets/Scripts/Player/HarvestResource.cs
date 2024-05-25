using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HarvestResource : MonoBehaviour
{
    public float interactRange = 2f;
    public LayerMask resourceLayer;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.position, interactRange, resourceLayer);
            if (hit.collider != null)
            {
                Destroy(hit.collider.gameObject);
                Debug.Log("Interacted with: " + hit.collider.gameObject.name);
            }
        }
    }
}
