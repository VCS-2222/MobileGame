using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterTime : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(kill()); //starts timer till death
    }

    IEnumerator kill()
    {
        yield return new WaitForSeconds(50f); //waits 50 seconds then dies

        Destroy(gameObject);
    }
}
