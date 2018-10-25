using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeASplash : MonoBehaviour {

    public AudioClip splashSound; //define an audio clip and name it splashSound
    AudioSource audioSource; //define the audio source and name it audioSource

    void Start()
    {
        audioSource = GetComponent<AudioSource>(); //bring the audio source in so we can play sounds at any point
    }

    void Update()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (splashSound != null) { //if splashSound exists
            audioSource.PlayOneShot(splashSound, 0.7f); //play the sound inside the parenthesis (name of sound, volume)
        }
    }
}