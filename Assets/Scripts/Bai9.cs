using UnityEngine;

public class Bai9 : MonoBehaviour
{
    [SerializeField] private Transform aPoint, bPoint;
    [SerializeField] private float duration;
    
    private float progress;
    private bool isEndPoint = false;

    private void Update()
    {
        Move();
    }

    private void Move()
    {
        Vector2 startPoint;
        Vector2 endPoint;


        if (progress >= duration)
        {
            progress = 0f;
            isEndPoint = !isEndPoint;
        }

        if (isEndPoint)
        {
            startPoint = bPoint.position;
            endPoint = aPoint.position;
        }
        else
        {
            startPoint = aPoint.position;
            endPoint = bPoint.position;
        }

        float delay = progress / duration;
        progress += Time.deltaTime;
        
        transform.position = Vector2.Lerp(startPoint, endPoint, delay);
    }
}
