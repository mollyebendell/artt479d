using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//the purpose of this script is to make the apples fall
//when the player gets within a certain distance of the trees

[RequireComponent(typeof(Rigidbody))] 
//"Make sure a rigidbody component is added to the apple"
//declaring something a Rigidbody tells Unity that the object needs to obey game physics

public class FallingApples : MonoBehaviour {

    public Transform player; //this creates a slot in the inspector to add a player
    //public meaning "anyone can access without looking at the code"
    //Transform meaning "the X, Y, and Z position of the player"
    //player meaning "a placeholder for the player you intend to add"

    public float maxDistance = 5f;
    //variable to change the distance at which the apple falls

    private Rigidbody apple;
    //the object that will fall
    //Rigidbody meaning "gravity and other game physics will effect this component"

	// Use this for initialization
    // "Initialization" meaning, this block of code will run only once, at the start of the game
	void Start () {
        apple = GetComponent<Rigidbody>();
        //look into the Rigidbody component to change an option from that menu
        apple.useGravity = false; 
        // "don't let the apples fall out of the tree yet"
	}
	
	// Update is called once per frame
    // aka, this code runs on a loop
	void Update () {
        if (Vector3.Distance(player.position, transform.position) < maxDistance) 
            //"if the distance between the player and the apple is less than the max distance then:"
        {
            apple.useGravity = true;
            //"turn on gravity so the apples fall out of the tree"
        }
	}
}
