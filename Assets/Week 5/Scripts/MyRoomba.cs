using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyRoomba : MonoBehaviour
{
    public float speed = 3.0f;
    public float raycastDistance = 2.0f;
    public bool turnRight;
    public bool turnLeft;

    Vector2 dirLeft = Vector2.left;
    Vector2 dirRight = Vector2.right;
    Vector2 dirUp = Vector2.up;
    Vector2 dirDown = Vector2.down;

    Vector2 currDir = Vector2.left;
    Vector2 sideDir = Vector2.up;

    void MoveRoomba()
    {
        //if (movingLeft)
        //    direction = Vector2.left;

        //else if (!movingLeft)
        //    direction = Vector2.right;

        //direction = moving ? Vector2.left : Vector2.right;

        if (turnRight)
        {
            turnRight = false;
            if (currDir == dirLeft)
            {
                currDir = dirUp;
                sideDir = dirRight;
            }
            else if (currDir == dirUp)
            {
                currDir = dirRight;
                sideDir = dirDown;

            }
            else if (currDir == dirRight)
            {
                currDir = dirDown;
                sideDir = dirLeft;

            }
            else
            {
                currDir = dirLeft;
                sideDir = dirUp;
            }
        }

        if(turnLeft)
        {
            turnLeft = false;
            if (currDir == dirLeft)
            {
                currDir = dirDown;
                sideDir = dirLeft;
            }
            else if (currDir == dirUp)
            {
                currDir = dirLeft;
                sideDir = dirUp;

            }
            else if (currDir == dirRight)
            {
                currDir = dirUp;
                sideDir = dirRight;

            }
            else
            {
                currDir = dirRight;
                sideDir = dirDown;
            }
        }

        RaycastHit2D hitCurr = Physics2D.Raycast(transform.position, currDir, raycastDistance);
        RaycastHit2D hitSide = Physics2D.Raycast(transform.position, sideDir, raycastDistance);

        transform.Translate(currDir * speed * Time.deltaTime);

        if(hitCurr.collider != null && hitSide.collider != null)
        {
            turnLeft = true;
        } else if (hitCurr.collider != null)
        {
            turnRight = true;
        }

    }

    private void OnDrawGizmos()
    { 
        Gizmos.DrawRay(transform.position, currDir * raycastDistance);
        Gizmos.DrawRay(transform.position, sideDir * raycastDistance);
    }

    // Update is called once per frame
    void Update()
    {
        MoveRoomba();
    }
}
