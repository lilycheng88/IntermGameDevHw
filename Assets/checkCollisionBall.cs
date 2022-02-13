using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollisionBall : MonoBehaviour
{
    //CHANGES CAMERA POSITION
    CircleCollider2D circleCollider;
    public GameObject obj;
    public string objName;

    private void Awake()
    {
        circleCollider = GetComponent<CircleCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        objName = obj.name;
        moveCamera.ChangePlayer(objName);
    }
}
