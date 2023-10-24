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
    public TrackCheckpoints trackCheckpoints;

   
    //called once at the start
    
    public override void Initialize()
    {
        _controllerDiferentialRobot = GetComponent<ControllerDiferentialRobot>();
    }

    public override void OnEpisodeBegin()
    {
        trackCheckpoints.ResetCheckpoints();
        _controllerDiferentialRobot.MoveCar(1, 0);
    }


    //Recopila observaciones del entorno que el agente utilizará para tomar decisiones
    public override void CollectObservations(VectorSensor sensor)
    {
        Vector3 CheckpoinForward = trackCheckpoints.nextCheckPointToReach.transform.forward;
        float dirrectionCar = Vector3.Dot(transform.forward, CheckpoinForward);
        sensor.AddObservation(dirrectionCar);

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

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Walls") 
        {
            AddReward(-0.5f);

        }

    }




}
