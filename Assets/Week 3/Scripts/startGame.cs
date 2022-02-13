using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startGame : MonoBehaviour
{
    public Rigidbody2D rigidB;

    // Start is called before the first frame update
    private void Awake()
    {
        rigidB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            Debug.Log("GAME START");
            rigidB.gravityScale = 1;
        }
    }
}
