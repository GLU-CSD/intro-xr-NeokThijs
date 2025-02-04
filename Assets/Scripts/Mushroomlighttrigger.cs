using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroomlighttrigger : MonoBehaviour
{
    [SerializeField] private Light mushroomLight;

    // Start is called before the first frame update
    void ONtTiggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        { // Geef de XR Rig de tag "Player"
            mushroomLight.enabled = true;
            Debug.Log("Licht aan");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
