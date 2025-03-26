using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This script increases player speed when they step on arrow 

public class SpeedTrigger : MonoBehaviour
{
    public int speedIncrease = 10;

    void OnTriggerEnter(Collider player)
    {
        //object.GetComponent<component>().property 
        player.GetComponent<FirstPersonMovement>().speed += speedIncrease;
        print("Player speed increased!");
    }

    void OnTriggerExit(Collider player)
    {
        //object.GetComponent<component>().property 
        player.GetComponent<FirstPersonMovement>().speed -= speedIncrease;
        print("Player speed decreased!");
    }

}
