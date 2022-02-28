using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseClick : MonoBehaviour
{
    public static bool leftClick;
    public static bool rightClick;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            leftClick = true;
        }
        if (Input.GetMouseButtonDown(1))
        {
            rightClick = true;
        }
    }

}
