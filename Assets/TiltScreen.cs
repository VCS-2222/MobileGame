using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScreen : MonoBehaviour
{
    private void Start()
    {
        Input.gyro.enabled = true; //enables gyro
    }

    private void FixedUpdate()
    {
        this.transform.rotation = GyroToUnity(Input.gyro.attitude); //test the swings' Z rotation to the gyro's rotation
    }

    Quaternion GyroToUnity(Quaternion gyroInput)
    {
        return new Quaternion(0, 0, gyroInput.z, gyroInput.w); //this returns a quaternion with the raw axis inputs of the phone's gyro rotations
    }
}
