using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCamera : MonoBehaviour
{
    public static GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Launched Ball");
    }

    public static void ChangePlayer(string name)
    {
        player = GameObject.Find(name);
    }

    // Update is called once per frame
    void Update()
    { 
        transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10.0f);
    }
}
