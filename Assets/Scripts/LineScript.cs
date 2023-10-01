using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("Se ha detectado una colisión");

        switch (other.tag)
        {
            case "Sensor 1":
                Debug.Log("Sensor 1");
                break;
            case "Sensor 2":
                Debug.Log("Sensor 2");
                break;
            case "Sensor 3":
                Debug.Log("Sensor 3");
                break;
            case "Sensor 4":
                Debug.Log("Sensor 4");
                break;
            case "Sensor 5":
                Debug.Log("Sensor 5");
                break;
        }
    }
}
