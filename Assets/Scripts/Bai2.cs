using UnityEngine;

public class Bai2 : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform aPoint, bPoint;
    [SerializeField] private float speed;
    private Vector3 target;
    

    [SerializeField] private bool doTranslateMove;
    [SerializeField] private bool doVelocityMove;
    [SerializeField] private bool doMoveTowards;

    private void Start()
    {
        transform.position = aPoint.position;
    }

    private void Update()
    {
        if (doTranslateMove)
        {
            DoTranslateMove();
        }

        if (doVelocityMove)
        {
            DoVelocityMove();
        }

        if(doMoveTowards)
        {
            DoMoveTowards();
        }


    }

    private void DoTranslateMove()
    {
        //Move
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        //Flip
        if (Vector2.Distance(transform.position, bPoint.position) < 0.1f)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
        }
        else if (Vector2.Distance(transform.position, aPoint.position) < 0.1f)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }

    private void DoVelocityMove()
    {
        if (Vector2.Distance(transform.position, bPoint.position) < 0.1f)
        {
            rb.velocity = new Vector2(-speed, rb.velocity.y);
        }
        else if (Vector2.Distance(transform.position, aPoint.position) < 0.1f)
        {
            rb.velocity = new Vector2(speed, rb.velocity.y);
        }
    }

    private void DoMoveTowards()
    {
        
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);

        if (Vector2.Distance(transform.position, bPoint.position) < 0.1f)
        {
            target = aPoint.position;
        }
        else if (Vector2.Distance(transform.position, aPoint.position) < 0.1f)
        {
            target = bPoint.position;
        }
    }
}
