using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPLookAt : MonoBehaviour
{    
    // Update is called once per frame
    void Update()
    {
        Camera camera = Camera.main;
        Transform camPosition = camera.transform;
        transform.LookAt(camPosition.position - camPosition.forward);
    }
}
