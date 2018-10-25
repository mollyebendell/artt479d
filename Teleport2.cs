using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Teleport2 : MonoBehaviour
{
    public Transform destination;

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Door")
        {
            FindObjectOfType<AudioManager1>().Play("DoorSound");
        }
        other.transform.position = destination.transform.position;

    }
}