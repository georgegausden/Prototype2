using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkPackageStatus : MonoBehaviour
{
    public float colorSwitchTime = 1.0f;

    private Renderer renderer;
    private float timeLeft = 0.0f;
    private bool isRed = true;

    void Start()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
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
                isRed = true;
            }

            timeLeft = colorSwitchTime;
        }
    }
}