using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraClampBird : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -10, 21), transform.position.y, transform.position.z);
    
    }
}
