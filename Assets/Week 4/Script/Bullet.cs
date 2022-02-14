using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    Vector3 mousePosition;
    float speed = 5.0f;

    private void Start()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }

    private void Update()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 shootDir = mousePosition - transform.position;
        transform.position += shootDir * speed * Time.deltaTime;
    }



}
