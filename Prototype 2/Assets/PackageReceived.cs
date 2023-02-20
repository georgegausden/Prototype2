using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PackageReceived : MonoBehaviour
    
{
    public GameObject particleReceived;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.gameObject.CompareTag("Package"))
        {
            

            

           

           // this.GetComponent<AudioSource>().Play();

            Debug.Log("received");
            Debug.Log("boom");
            GameObject.Instantiate(particleReceived, collision.collider.gameObject.transform.position, Quaternion.identity);
        }
    }
}
