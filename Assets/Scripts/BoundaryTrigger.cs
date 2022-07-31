using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryTrigger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Color oldColor = gameObject.GetComponent<Renderer>().material.color;
            Color color = new Color(oldColor.r, oldColor.g, oldColor.b, 0.5f);
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Color oldColor = gameObject.GetComponent<Renderer>().material.color;
            Color color = new Color(oldColor.r, oldColor.g, oldColor.b, 0.0f);
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", color);
        }
    }


}
