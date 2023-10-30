using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LineScript : MonoBehaviour
{
    public string DetectedSensorTag { get; private set; } // Public property to store the detected sensor tag.
    public AgentDiferentialRobot agentDiferentialRobot;
    void Start()
    {
        // Initialize the detected sensor tag to an empty string.
        DetectedSensorTag = "";
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.tag)
        {
            case "Sensor 1":
                DetectedSensorTag = "Sensor 1";
                agentDiferentialRobot.AddReward(-5f);
                break;
            case "Sensor 2":
                DetectedSensorTag = "Sensor 2";
                agentDiferentialRobot.AddReward(-3f);
                break;
            case "Sensor 3":
                DetectedSensorTag = "Sensor 3";
                agentDiferentialRobot.AddReward(-1f);
                break;
            case "Sensor 4":
                DetectedSensorTag = "Sensor 4";
                agentDiferentialRobot.AddReward(+1f);
                break;
            case "Sensor 5":
                DetectedSensorTag = "Sensor 5";
                agentDiferentialRobot.AddReward(+1f);
                break;
            case "Sensor 6":
                DetectedSensorTag = "Sensor 6";
                agentDiferentialRobot.AddReward(-1f);
                break;
            case "Sensor 7":
                DetectedSensorTag = "Sensor 7";
                agentDiferentialRobot.AddReward(-3f);
                break;
            case "Sensor 8":
                DetectedSensorTag = "Sensor 8";
                agentDiferentialRobot.AddReward(-5f);
                break;
            default:
                DetectedSensorTag = ""; // Reset to an empty string if no sensor tag matches.
                break;
        }
    }
}