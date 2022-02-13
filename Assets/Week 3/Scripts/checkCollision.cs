using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollision : MonoBehaviour
{
    //CHANGES CAMERA POSITION
    BoxCollider2D boxCollider;
    public GameObject obj;
    public string objName;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        objName = obj.name;
        moveCamera.ChangePlayer(objName);
    }

}
