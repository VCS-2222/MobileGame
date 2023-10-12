using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject circle; //ball prefab to spawn

    private void Start()
    {
        StartCoroutine(spawn()); //starts loop to spawn balls
    }

    IEnumerator spawn()
    {
        for (int i = 0; i < 300; i++) //till it gets to 300, spawn balls
        {
            Instantiate(circle, this.transform.position, this.transform.rotation); //spawns balls
            yield return new WaitForSeconds(2); //waits for 2 seconds before it can spawn balls again
        }
    }
}
