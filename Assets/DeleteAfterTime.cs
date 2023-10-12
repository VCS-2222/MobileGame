using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteAfterTime : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(kill());
    }

    IEnumerator kill()
    {
        yield return new WaitForSeconds(50f);

        Destroy(gameObject);
    }
}
