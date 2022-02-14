using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{
    Vector3 mousePosition;
    public GameObject bullet;
    Rigidbody2D bulletRb;

    bool canShoot = false;
    bool inFrame = true;

    void Start()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        bulletRb = bullet.GetComponent<Rigidbody2D>();
    }

    private void checkBulletLocation()
    {
        if (bullet.GetComponent<Renderer>().isVisible)
        {
            inFrame = true;
            Debug.Log("bullet in frame");
        }
        else
        {
            inFrame = false;
            Debug.Log("bullet out of frame");
        }
    }

    void PlayerControls()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            canShoot = true;
        }
    }

    void Shoot()
    {
        if (!canShoot)
            return;

        canShoot = false;

        bulletRb.gravityScale = 1;
    }

    private void FixedUpdate()
    {
        if(canShoot)
        {
            Shoot();
        }
    }

    void Update()
    {
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        float angle = Vector2.SignedAngle(Vector2.right, direction);
        transform.eulerAngles = new Vector3(0, 0, angle);

        checkBulletLocation();
        PlayerControls();
    }

}
