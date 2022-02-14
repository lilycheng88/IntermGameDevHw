using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public static GameObject player;
    public static Camera myCamera; 

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Launched Ball");
        myCamera = GetComponent<Camera>();
    }

    public static void ChangePlayer(string name)
    {
        player = GameObject.Find(name);
    }

    public static void SetSize(float value)
    {
        myCamera.orthographicSize = value;
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10.0f);
    }
}
