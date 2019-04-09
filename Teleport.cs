
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

[RequireComponent(typeof(AudioSource))]

public class Teleport : MonoBehaviour
{
    public Transform destination;
    private AudioSource sound;

    void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Door")
        {
            sound = GetComponent<AudioSource>();
            sound.Play();
            Debug.Log("Sound played.");
            
        }
        other.transform.position = destination.transform.position;

    }
}