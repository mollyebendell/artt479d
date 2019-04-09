using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DimTheLights : MonoBehaviour
{
    public Transform player;
    public Transform target;
    public float maxDistance = 5.0f;
    public float maxIntensity = 5.0f;
    private Light lightToDim;
    private bool dim = true;
    private float currentTime = 0.0f;
    public float howLong = 800f;
    public bool getBrighter = true;
    // Start is called before the first frame update
    void Start()
    {
        lightToDim = GetComponent<Light>();
        if (getBrighter == true)
        {
        lightToDim.intensity = 0.0f;
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(player.position, target.position) < maxDistance)
        //"if the distance between the player and the light is less than the max distance then:"
        {
            if (dim == true)
            {
                if (currentTime <= howLong)
                {
                    currentTime += Time.deltaTime;
                    lightToDim.intensity = Mathf.Lerp(lightToDim.intensity, maxIntensity, currentTime / howLong);
                }
                else
                {
                    lightToDim.intensity = maxIntensity;
                    currentTime = 0f;
                    dim = false;
                }
            }
        }

    }
}
