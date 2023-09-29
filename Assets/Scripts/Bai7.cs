using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai7 : MonoBehaviour
{
    [SerializeField] private Transform[] movePoint;
    [SerializeField] private float speed;

    private int index;

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, movePoint[index].position, speed * Time.deltaTime);

        if(Vector2.Distance(transform.position, movePoint[index].position) < 0.1f)
        {
            index = Random.Range(0, movePoint.Length);
        }
    }
}
