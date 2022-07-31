using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToiletDoorMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    public void OpenDoor()
    {
        print("OpenDoor");
        StopAllCoroutines(); //add to stop previously running coroutines
        StartCoroutine(DoorMove(-40f));
    }

    public void CloseDoor()
    {
        print("CloseDoor");
        StopAllCoroutines();
        StartCoroutine(DoorMove(40f));
    }

    IEnumerator DoorMove(float endRot)
    {

        Quaternion startRotation = transform.rotation;
        float duration = 2f;
        float t = 0;

        while (t < 1f)
        {
            t = Mathf.Min(1f, t + Time.deltaTime / duration);
            Vector3 newEulerOffset = - Vector3.down * (endRot * t);
            print(newEulerOffset.ToString());
            // global z rotation
            transform.rotation = Quaternion.Euler(newEulerOffset) * startRotation;
            // local z rotation
            // transform.rotation = startRotation * Quaternion.Euler(newEulerOffset);
            yield return null;
        }
    }
}
