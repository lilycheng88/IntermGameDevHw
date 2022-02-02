using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    [SerializeField]
    float speed = 0.25f;
    [SerializeField]
    float origSpeed;
    [SerializeField]
    float sprintMultiply = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        origSpeed = speed;
    }

    void MoveObject() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            speed *= sprintMultiply;

        } else {

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.Translate(-speed, 0, 0);
            // transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.Translate(speed, 0, 0);
            // transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
    }
}
