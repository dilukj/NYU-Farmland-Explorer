using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorBehavior : MonoBehaviour
{
    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered the trigger zone");
            gameObject.BroadcastMessage("OpenDoor");
        }
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has exited the trigger zone");
            gameObject.BroadcastMessage("CloseDoor");
        }
    }
}
