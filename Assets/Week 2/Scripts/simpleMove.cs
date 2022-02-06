using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleMove : MonoBehaviour
{
    [SerializeField]
    float speed = 0.25f;
    [SerializeField]
    float origSpeed;
    [SerializeField]
    float sprintMultiply = 2.0f;

    // public SpriteRenderer spriteR;
    // public Sprite[] sprites;
    // public string spriteNames = "bird";
    // public int spriteVersion = 1;

    public SpriteRenderer spriteRenderer;
    public Sprite blueSprite;
    public Sprite redSprite;
    public int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        origSpeed = speed;
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        // spriteR = gameObject.GetComponent<SpriteRenderer>();
        // sprites = Resources.LoadAll<Sprite>(spriteNames);
    }

    void MoveObject() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            speed *= sprintMultiply;

        } else {

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            Camera.main.transform.Translate(-speed, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 180, 0);

            // transform.Translate((Vector2.left * Time.deltaTime) * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Camera.main.transform.Translate(speed, 0, 0);
            transform.localRotation = Quaternion.Euler(0, 0, 0);

            // transform.Translate((Vector2.right * Time.deltaTime) * speed);
        }
    }

    void ChangeSpriteColor() 
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Color changing.");
            if (count % 2 == 0) {
                spriteRenderer.sprite = blueSprite;
            } else {
                spriteRenderer.sprite = redSprite;
            }
            count++;
            // spriteVersion += 1;
            // if (spriteVersion > 2) 
            // {
            //     spriteVersion = 1;
            // }
            // spriteR.sprite = sprites[spriteVersion];
        }
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject();
        ChangeSpriteColor();
    }
}
