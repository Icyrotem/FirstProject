using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoreLogic : MonoBehaviour
{
    public static int score = 0;
    private static TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        scoreText = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("your score is 0");
    }

    public static void updateText(int add)
    {
        score += add;
        scoreText.SetText($"your score is {score}");
    }
}
