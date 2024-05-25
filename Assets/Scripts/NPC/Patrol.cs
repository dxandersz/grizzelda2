using System.Diagnostics;
using System.Security.AccessControl;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Debug = UnityEngine.Debug;


public class Patrol : MonoBehaviour
{
  public float speed = 1.0f;
  public List<Transform> listOfWaypoints = new List<Transform>();
  private int currentIndexOfWaypoint;

  void Start()
  {
    currentIndexOfWaypoint = 0;
  }

  void Update()
  {
    if (Vector3.Distance(transform.position, listOfWaypoints[currentIndexOfWaypoint].position) < 0.001f)
    {
      //Debug.Log("Coordinates: " + listOfWaypoints[currentIndexOfWaypoint].position);
      currentIndexOfWaypoint++;
      

      if(currentIndexOfWaypoint == listOfWaypoints.Count)
      {
        currentIndexOfWaypoint = 0;
      }
    }
    
    var step =  speed * Time.deltaTime;
    transform.position = Vector3.MoveTowards(transform.position, listOfWaypoints[currentIndexOfWaypoint].position, step);
  }
}
