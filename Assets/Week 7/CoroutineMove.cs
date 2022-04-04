using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoroutineMove : MonoBehaviour
{
    public Transform pointA, pointB, pointC, pointD;
    public float speed = 3.0f;

    public bool startMove;

    public static bool moveB, moveC, moveD, moveA;

    public int currCour = 0;

    public Vector2 targetPos;

    float duration;
    bool flag;

    float t = 0f;
    Color color1 = Color.red, color2 = Color.blue;

    SpriteRenderer sp;

    private void Awake()
    {
        sp = GetComponent<SpriteRenderer>();
    }
    void MoveToPoint(Transform target)
    {
        targetPos = new Vector2(target.position.x, target.position.y);
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);
    }

    private void FixedUpdate()
    {
        if (startMove)
        {
            speed = 3.0f;
            if (moveB)
            {
                Debug.Log("Moving to B");
                MoveToPoint(pointB);

                transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
                color1 = Color.red;
                color2 = Color.blue;

                Color color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time/10, 1));

                sp.color = color;

                if (transform.position.x == targetPos.x && transform.position.y == targetPos.y)
                {
                    if (currCour == 0)
                    {
                        StartCoroutine(CoroutineTwo());
                        startMove = false;

                    }
                    else if (currCour == 1)
                    {
                        StartCoroutine(CoroutineSix());
                        startMove = false;
                    }
                }
            }

            if (moveC)
            {
                Debug.Log("Moving to C");
                MoveToPoint(pointC);


                transform.localScale -= new Vector3(0.007f, 0.007f, 0.007f);
                color1 = Color.blue;
                color2 = Color.yellow;

                Color color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time/10, 1));

                sp.color = color;

                if (transform.position.x == targetPos.x && transform.position.y == targetPos.y)
                {
                    if (currCour == 0)
                    {
                        StartCoroutine(CoroutineThree());
                        startMove = false;
                    } else if (currCour == 1)
                    {
                        StartCoroutine(CoroutineFive());
                        startMove = false;
                    }
                }
            }

            if(moveD)
            {
                Debug.Log("Moving to D");

                MoveToPoint(pointD);

                transform.localScale += new Vector3(0.004f, 0.004f, 0.004f);
                color1 = Color.yellow;
                color2 = Color.red;

                Color color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time/10, 1));

                sp.color = color;

                if (transform.position.x == targetPos.x && transform.position.y == targetPos.y)
                {
                    StartCoroutine(CoroutineFour());
                    startMove = false;
                }
            }

            if (moveA)
            {
                Debug.Log("Moving to A");

                MoveToPoint(pointA);

                transform.localScale -= new Vector3(0.005f, 0.005f, 0.005f);
                color1 = Color.red;
                color2 = Color.green;

                Color color = Color.Lerp(color1, color2, Mathf.PingPong(Time.time/10, 1));

                sp.color = color;

                if (transform.position.x == targetPos.x && transform.position.y == targetPos.y)
                {
                    StartCoroutine(CoroutineOne());
                    startMove = false;
                }
            }
        }
        else
        {
            speed = 0.0f;
        }

    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            StartCoroutine(CoroutineOne());
        }
    }

    IEnumerator CoroutineOne()
    {
        Debug.Log("ONE START");

        yield return new WaitForSeconds(0.0f);
        moveB = true;
        moveA = false;
        startMove = true;

        Debug.Log("ONE STOP");
    }

    IEnumerator CoroutineTwo()
    {
        Debug.Log("TWO START");

        yield return new WaitForSeconds(1.0f);
        moveC = true;
        moveB = false;
        startMove = true;

        Debug.Log("TWO STOP");
    }

    IEnumerator CoroutineThree()
    {
        Debug.Log("THREE START");

        yield return new WaitForSeconds(1.0f);
        moveD = true;
        moveC = false;
        startMove = true;

        Debug.Log("THREE STOP");
    }

    IEnumerator CoroutineFour()
    {
        Debug.Log("FOUR START");

        yield return new WaitForSeconds(1.0f);
        moveC = true;
        moveD = false;
        startMove = true;
        currCour = 1;

        Debug.Log("FOUR STOP");
    }

    IEnumerator CoroutineFive()
    {
        Debug.Log("FIVE START");

        yield return new WaitForSeconds(1.0f);
        moveB = true;
        moveC = false;
        startMove = true;

        Debug.Log("FIVE STOP");
    }

    IEnumerator CoroutineSix()
    {
        Debug.Log("SIX START");

        yield return new WaitForSeconds(1.0f);
        moveA = true;
        moveB = false;
        startMove = true;

        Debug.Log("SIX STOP");
    }
}
