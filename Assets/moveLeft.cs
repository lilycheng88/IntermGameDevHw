using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveLeft : MonoBehaviour
{
    float speed = 0.5f;

    // Start is called before the first frame update
    void Start() {
        
    }

    // Update is called once per frame
    void Update() {
        // if (Input.GetMouseButtonDown(0)) {
        // Camera.main.transform.Translate(speed, 0, 0);        
        // }
    }

    void OnMouseDown() {
        Camera.main.transform.Translate(-1*speed, 0, 0);        
    }


}
