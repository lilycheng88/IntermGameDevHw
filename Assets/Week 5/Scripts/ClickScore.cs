using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ClickScore : MonoBehaviour
{
    [SerializeField]
    float score = 5;
    [SerializeField]
    TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "Score = " + score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            score++;
            scoreText.text = "Score = " + score.ToString();
        }
        else if (Input.GetMouseButtonDown(1))
        {
            score--;
            scoreText.text = "Score = " + score.ToString();
        }
    }
}
