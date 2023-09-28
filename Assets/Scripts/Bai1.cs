using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai1 : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("A");
        }

        if (Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("B");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("C");
        }
    }
}
