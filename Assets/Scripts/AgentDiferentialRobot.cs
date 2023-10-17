using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Actuators;
using Unity.MLAgents.Sensors;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class AgentDiferentialRobot : Agent
{
    public LineScript lineScript; //Referencia el script
    private ControllerDiferentialRobot _controllerDiferentialRobot;

    private void Update()
    {
        // Access the DetectedSensorTag property and use it.
        string detectedTag = lineScript.DetectedSensorTag;

        Debug.Log("Detected Sensor Tag: " + detectedTag);
        // You can use detectedTag in your logic here.
    }



}
