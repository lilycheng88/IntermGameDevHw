using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraClamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -5, 0), Mathf.Clamp(transform.position.y, -1, 2), transform.position.z);

    }
}
