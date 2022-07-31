using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTrigger : MonoBehaviour
{
    public AudioSource audioSource;

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        audioSource.Play();
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        audioSource.Stop();
    }

}
