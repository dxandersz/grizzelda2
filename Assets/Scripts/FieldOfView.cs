using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float radius;
    public float angle;

    public GameObject playerRef;
    
    public LayerMask targetMask;
    public LayerMask obstructionMask;

    public bool canSeePlayer;

    private void Start() {
        playerRef = GameObject.FindGameObjectWithTag("Player");
    }
}
