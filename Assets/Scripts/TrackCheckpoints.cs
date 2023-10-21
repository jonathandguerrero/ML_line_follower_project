using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("CheckPoints");

        foreach (Transform checkpointsSingleTransform in checkpointsTransform)
        {
            Debug.Log(checkpointsSingleTransform);
        }
    }
}
