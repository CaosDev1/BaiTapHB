using UnityEngine;

public class Bai8 : MonoBehaviour
{
    [SerializeField] private Transform aPoint, bPoint;
    [SerializeField] private float speed;
    [SerializeField] private float delayTime;

    private float progress;
    private float timer;
    private bool canMove;
    private bool isEndPoint = false;

    private void Update()
    {
        DoDelayTime();

        if(canMove)
        {
            Move();
        }
    }

    private void DoDelayTime()
    {
        timer += Time.deltaTime;

        if (timer != 0 && timer > delayTime)
        {
            timer = 0;
            canMove = !canMove;
        }
    }

    private void Move()
    {
        Vector2 startPoint;
        Vector2 endPoint;
        
        progress += Time.deltaTime * speed;

        if(progress >= 1f)
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

        transform.position = Vector2.Lerp(startPoint, endPoint, progress);
    }
}
