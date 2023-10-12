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
        var eulerRotation = gyroInput.eulerAngles;
        return Quaternion.Euler(0, 0, eulerRotation.z - 90);
    }
}
