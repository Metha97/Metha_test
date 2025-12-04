using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.VisualScripting;

public class UIControl : MonoBehaviour
{
    int score = 0;
    GameObject scoreText;

    public void AddScore()
    {
        this.score += 10;
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        this.scoreText = GameObject.Find("Score");
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.GetComponent<Text>().text = "Score: " + score.ToString("D4");
    }
}
