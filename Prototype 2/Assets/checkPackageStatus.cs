using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPackageStatus : MonoBehaviour
{
    public float maxColorSwitchTime = 1.0f;
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
