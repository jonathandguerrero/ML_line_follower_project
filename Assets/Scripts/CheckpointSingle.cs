using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSingle : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        //if (other.CompareTag("Player"))
        if (other.TryGetComponent<ControllerDiferentialRobot>(out ControllerDiferentialRobot player))
        {
            Debug.Log("Checkpoint!");
        }
    }
}
