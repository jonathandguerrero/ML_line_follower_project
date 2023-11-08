using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerDiferentialRobot : MonoBehaviour
{
    [System.Serializable]
    public class AxleInfo
    {
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;
        public bool motor; // is this wheel attached to motor?
        public bool steering; // does this wheel apply steer angle?
    }

    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public float maxSteeringAngle; // maximum steer angle the wheel can have

    public void MoveCar(float traction, float address)
    {
 
        float motor = maxMotorTorque * traction;
        float steering = maxSteeringAngle * address;
        // Debug.Log(traction);
        // Debug.Log(address);

        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                if (steering > 0)
                {
                    axleInfo.leftWheel.steerAngle = 0;
                    axleInfo.rightWheel.steerAngle = steering;
                }
                else if (steering < 0)
                {
                    axleInfo.leftWheel.steerAngle = steering;
                    axleInfo.rightWheel.steerAngle = 0;
                }
                else {
                    axleInfo.leftWheel.steerAngle = 0;
                    axleInfo.rightWheel.steerAngle = 0;
                }

            }
            if (axleInfo.motor)
            {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }

}



