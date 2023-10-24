using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
    private TrackCheckpoints trackCheckpoints;
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        if (other.TryGetComponent<ControllerDiferentialRobot>(out ControllerDiferentialRobot player))
        {
            trackCheckpoints.PlayerThroughCheckpoint(this);
        }
    }

    public void SetTrackChecpoints( TrackCheckpoints trackCheckpoints)
    {
        this.trackCheckpoints = trackCheckpoints;
    }
}
