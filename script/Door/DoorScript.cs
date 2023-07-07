using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorScript : MonoBehaviour
{
    public bool open = false;
    public float DoorOpenAngel = 0f;
    public float DoorCloseAngel = 0f;
    public AudioClip DoorOpenSound;


    public void ChangeDoorState()
    {
        open = !open;
        GetComponent<AudioSource>().PlayOneShot(DoorOpenSound);
    }
    void Update()
    {
        if (open)
        {
            Quaternion targetRotation = Quaternion.Euler(0, DoorOpenAngel, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, DoorCloseAngel, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, Time.deltaTime);
        }
    }
}
