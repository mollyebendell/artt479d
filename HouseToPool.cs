using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HouseToPool : MonoBehaviour {

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
    void OnTriggerEnter (Collider other) {

        if(other.tag == "Player"){
            SceneManager.LoadScene("Scenes/MagicPool");
        }
		
	}
}
