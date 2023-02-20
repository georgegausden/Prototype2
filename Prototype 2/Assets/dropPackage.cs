using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropPackage : MonoBehaviour
{

    public GameObject WoodCrate;
    public float yOffset = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Check if the left mouse button was clicked
        if (Input.GetMouseButtonDown(0))
        {
            // Get the position of the player object
            Vector3 playerPosition = transform.position;

            // Instantiate the prefab asset slightly below the player position
            Vector3 spawnPosition = new Vector3(playerPosition.x, playerPosition.y - yOffset, playerPosition.z);
            Instantiate(WoodCrate, spawnPosition, Quaternion.identity);
        }


    }


}