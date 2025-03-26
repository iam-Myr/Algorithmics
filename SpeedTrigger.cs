using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedTrigger : MonoBehaviour
{
    public float speedFactor = 2.5f;

    //When collider is entered
    public void OnTriggerEnter(Collider other)
    {
        //Increases run speed 
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
        Debug.Log("Speed increased!");
    }

    // When collider is exited
    public void OnTriggerExit(Collider other)
    {
        // Decrease run speed
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
        Debug.Log("Speed decreased!");
    }

}
