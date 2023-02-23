using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPackageStatus : MonoBehaviour
{
    public float maxColorSwitchTime = 10.0f;
    public PackageReceived packageReceivedScript;
    public GameObject player;
    private float timeLeft = 0.0f;

    private Renderer renderer;
    private float colorSwitchTime = 1.0f;
    private bool isRed = true;

    // Store the AudioSources in an array
    private AudioSource[] audioSources;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        // Get all AudioSources on this object
        audioSources = GetComponents<AudioSource>();
    }

    void Update()
    {
        if (packageReceivedScript.packageReceived)
        {
            renderer.material.SetColor("_EmissionColor", Color.green);
            return; // return early to prevent the rest of the code from executing
        }

        // Calculate the distance between the player and the object
        float distance = Vector3.Distance(player.transform.position, transform.position);



        // Calculate the color switch time based on the distance
        colorSwitchTime = distance/1000; 

        Debug.Log(colorSwitchTime);
        timeLeft -= Time.deltaTime;

        if (timeLeft <= 0.0f)
        {


            if (isRed)
            {
                renderer.material.SetColor("_EmissionColor", Color.black);
                isRed = false;
            }
            else
            {
                renderer.material.SetColor("_EmissionColor", Color.red);
                // Play the second AudioSource
                audioSources[1].Play();
                isRed = true;
            }

            timeLeft = colorSwitchTime;
        }
    }
}
