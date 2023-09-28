using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai3 : MonoBehaviour
{
    [SerializeField] private Transform[] movePoint;
    [SerializeField] private float speed;

    private int index;

    private void Start()
    {
        transform.position = movePoint[0].position;
    }
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, movePoint[index].position, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, movePoint[index].position) < 0.1f)
        {
            index++;

            if(index >= movePoint.Length)
            {
                index = 0;
            }
        }
    }
}
