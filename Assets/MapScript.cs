using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapScript : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("MapBoundary")) // Assuming you've tagged the map boundary collider appropriately
        {
            // Call Die function from PlayerStats script
            GetComponent<PlayerStats>().Die();
        }
    }

}
