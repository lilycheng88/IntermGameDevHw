using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class simpleText : MonoBehaviour
{
    public TMP_Text text;

    public string gameName;

    [SerializeField]
    string otherText1;
    [SerializeField]
    string otherText2;
    
    // Start is called before the first frame update
    void Start()
    {
        text.text = gameName;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            text.text = gameName;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow)) {
            text.text = otherText1;
            // label.GetComponent<Text> ().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow)) {
            text.text = otherText2;
            // label.GetComponent<Text> ().font = Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font;
        }
        

    }
}
