using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropPackage : MonoBehaviour
{
    public GameObject woodCratePrefab;
    

 
    public int maxPackages = 10;
    public float yOffset = 5f;

    public int numPackages = 0;

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && numPackages < maxPackages)
        {
            // Get the position of the player object
            Vector3 playerPosition = transform.position;

            // Instantiate the prefab asset slightly below the player position
            Vector3 spawnPosition = new Vector3(playerPosition.x, playerPosition.y - yOffset, playerPosition.z);
            Instantiate(woodCratePrefab, spawnPosition, Quaternion.identity);


            numPackages++;
        }
    }
}
