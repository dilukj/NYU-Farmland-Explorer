using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBehavior : MonoBehaviour
{
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerExit is called when the Collider other has stopped touching the trigger
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("Eat", false);
            anim.SetBool("Turn Head", true);
        }
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("Turn Head", false);
            anim.SetBool("Eat", true);
        }
    }
}
