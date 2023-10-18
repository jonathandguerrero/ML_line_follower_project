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

    //called once at the start
    public override void Initialize()
    {
        _controllerDiferentialRobot = GetComponent<ControllerDiferentialRobot>();
    }

    //Recopila observaciones del entorno que el agente utilizará para tomar decisiones
    public override void CollectObservations(VectorSensor sensor)
    {

    }

    //Procesa las acciones que el agente ha decidido tomar en función de las observaciones recopiladas
    public override void OnActionReceived(ActionBuffers actions)
    {
        var input = actions.ContinuousActions;

        _controllerDiferentialRobot.MoveCar(input[0], input[1]);

    }

    //Pruebas manuales con entrada humana, Las acciones definidas aquí se envían a OnActionRecieved
    public override void Heuristic(in ActionBuffers actionsOut)
    {
        var action = actionsOut.ContinuousActions;

        action[0] = Input.GetAxis("Vertical"); // Traccion
        action[1] = Input.GetAxis("Horizontal"); // Direccion
    }


    private void Update()
    {
        // Access the DetectedSensorTag property and use it.
        string detectedTag = lineScript.DetectedSensorTag;

        Debug.Log("Detected Sensor Tag: " + detectedTag);
        // You can use detectedTag in your logic here.
    }



}
