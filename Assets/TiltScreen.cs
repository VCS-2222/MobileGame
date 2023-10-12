using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltScreen : MonoBehaviour
{
    private void Start()
    {
        Input.gyro.enabled = true;
    }

    private void Update()
    {
        this.transform.rotation = GyroToUnity(Input.gyro.attitude);
    }

    Quaternion GyroToUnity(Quaternion gyroInput)
    {
        return new Quaternion(0, 0, gyroInput.z, gyroInput.w);
    }
}
