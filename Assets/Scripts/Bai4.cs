using System.Collections;
using UnityEngine;

public class Bai4 : MonoBehaviour
{

    [SerializeField] private Transform aPoint, bPoint;
    
    [SerializeField] private AnimationCurve curve;

    [SerializeField] private float duration = 4f;
    [SerializeField] private float heightY = 4f;

    private void Update()
    {
        StartCoroutine(Curve(aPoint.position, bPoint.position));
    }

    public IEnumerator Curve(Vector3 start, Vector2 target)
    {
        float timePassed = 0f;
        Vector2 end = target;

        while (timePassed < duration)
        {
            timePassed += Time.deltaTime;
            float linearT = timePassed / duration;
            float heightT = curve.Evaluate(linearT);
            float height = Mathf.Lerp(0f, heightY, heightT);

            transform.position = Vector2.Lerp(start, end, linearT) + new Vector2(0f, height);

            yield return null;
        }

    }

}
