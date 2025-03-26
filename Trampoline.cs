using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampoline : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        // Increases jump strength
        other.GetComponent<Jump>().jumpStrength = 10;
        Debug.Log("Jump increased!");
    }

    // Runs when collider is exited
    void OnTriggerExit(Collider other)
    {
        // Resets jump strength
        other.GetComponent<Jump>().jumpStrength = 2;
        Debug.Log("Jump reset!");
    }
}
