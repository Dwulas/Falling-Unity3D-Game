using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightModif : MonoBehaviour
{
    private float multiplier = 1.2f;
    public Light myLight;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Powerup"))
        {
            Pickup(other);
            myLight.intensity *= multiplier;
        }
    }

    void Pickup(Collider collider)
    {
        Destroy(GameObject.FindWithTag("Powerup"));
    }
}
