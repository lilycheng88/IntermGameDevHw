using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ClickButton : MonoBehaviour
{
    private void Update()
    {
        if (MouseClick.leftClick == true)
        {
            Debug.Log("Left Click");
            MouseClick.leftClick = false;
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                hit.collider.gameObject.GetComponent<Renderer>().material.color = new Color(0, 50, 50);

            } 
        }

        if (MouseClick.rightClick == true)
        {
            Debug.Log("Right Click");
            MouseClick.rightClick = false;

            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider != null)
            {
                Debug.Log("Target Position: " + hit.collider.gameObject.transform.position);
                hit.collider.gameObject.GetComponent<Renderer>().material.color = new Color(50, 50, 0);

            }
        }
    }

}
