using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script increases an object's running speed when it enters the collision area 
 * and descreases it when it leaves the collision area.*/

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    //Runs when collider is entered
    public void OnTriggerEnter(Collider other)
    {
        //Increases run speed 
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        Debug.Log("Speed increased!");
    }

    // Runs when collider is exited
    public void OnTriggerExit(Collider other)
    {
        // Decrease run speed
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        Debug.Log("Speed decreased!");
    }

}
