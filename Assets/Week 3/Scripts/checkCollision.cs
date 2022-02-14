using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkCollision : MonoBehaviour
{
    //CHANGES CAMERA POSITION
    //BoxCollider2D boxCollider;
    //public GameObject obj;
    //public string objName;

    //private void Awake()
    //{
    //    boxCollider = GetComponent<BoxCollider2D>();
    //}

    //void OnCollisionEnter2D(Collision2D collision)
    //{
    //    objName = obj.name;
    //    moveCamera.ChangePlayer(objName);
    //}

    BoxCollider2D boxCollider;
    SpriteRenderer spriteRenderer;
    //public Transform mover;
    //public Transform targetLocation;
    public GameObject obj;
    public string objName;
    public float cameraSize;

    private void Awake()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        boxCollider.isTrigger = true;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //spriteRenderer.color = new Color(1.0f, 0.5f, 0.25f, 0.5f); //red, blue, green, alpha
        //// mover.position = new Vector3(5.0f, 0.0f, 0.0f); // x, y, z
        //mover.position = targetLocation.position;
        objName = obj.name;
        moveCamera.ChangePlayer(objName);
        moveCamera.SetSize(cameraSize);
        Debug.Log("Entered Trigger");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit Trigger.");
    }

}
