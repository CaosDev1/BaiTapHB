using System.Collections;
using UnityEngine;

public class Bai4 : MonoBehaviour
{

    [SerializeField] private Transform aPoint, bPoint;

    [SerializeField] private AnimationCurve curve;

    [SerializeField] private float duration = 4f;
    [SerializeField] private float heightY = 4f;
    
    private Vector2 startPoint;
    private Vector2 endPoint;
    

    private bool isEndPoint = false;
    private float timePassed;

    private void Update()
    {
        ChangeMovePoint();

        StartCoroutine(Curve(startPoint, endPoint));
    }

    private void ChangeMovePoint()
    {
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
    }

    public IEnumerator Curve(Vector2 start, Vector2 target)
    {

        Vector2 end = target;

        if (timePassed >= duration)
        {
            timePassed = 0;
            isEndPoint = !isEndPoint;
        }

        float linearT = timePassed / duration;
        float heightT = curve.Evaluate(linearT);
        float height = Mathf.Lerp(0f, heightY, heightT);

        timePassed += Time.deltaTime;
        transform.position = Vector2.Lerp(start, end, linearT) + new Vector2(0f, height);

        yield return null;
    }
}
