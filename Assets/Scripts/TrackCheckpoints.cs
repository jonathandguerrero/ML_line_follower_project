using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCheckpoints : MonoBehaviour
{
    public AgentDiferentialRobot agentDiferentialRobot;
    public CheckpointSingle nextCheckPointToReach;
    
    private List<CheckpointSingle> checkpointSingleList;
    private int nextCheckpointSingleIndex;
    private void Awake()
    {
        Transform checkpointsTransform = transform.Find("CheckPoints");

        checkpointSingleList = new List<CheckpointSingle>();
        foreach (Transform checkpointsSingleTransform in checkpointsTransform)
        {
            CheckpointSingle checkpointSingle = checkpointsSingleTransform.GetComponent<CheckpointSingle>();
            checkpointSingle.SetTrackChecpoints(this);
            checkpointSingleList.Add(checkpointSingle);
        }

        nextCheckpointSingleIndex = 0;  
    }

    public void PlayerThroughCheckpoint(CheckpointSingle checkpointSingle) {
        if (checkpointSingleList.IndexOf(checkpointSingle) == nextCheckpointSingleIndex)
        {
            //Correcto
            Debug.Log("correcto");
            nextCheckpointSingleIndex = (nextCheckpointSingleIndex + 1) % checkpointSingleList.Count;
            agentDiferentialRobot.AddReward (+10f);
        }
        else 
        {
            // incorrecto
            //Debug.Log("incorrecto");
            //agentDiferentialRobot.AddReward(-1f);
        }
    }

    public void ResetCheckpoints()
    {
        nextCheckpointSingleIndex = 0;
    }

    public void SetNextCheckpoint()
    {
        if (checkpointSingleList.Count > 0)
        {
            nextCheckPointToReach = checkpointSingleList[nextCheckpointSingleIndex];

        }
    }
}
