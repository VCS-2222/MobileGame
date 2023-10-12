using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject circle;

    private void Start()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        for (int i = 0; i < 300; i++)
        {
            Instantiate(circle, this.transform.position, this.transform.rotation);
            yield return new WaitForSeconds(2);
        }
    }
}
