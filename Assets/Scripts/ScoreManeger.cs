using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManeger : MonoBehaviour {

    public static int score;

    Text texT;

    private void Start()
    {
        texT = GetComponent<Text>();
        score = 0;

    }
    private void Update()
    {
        if (score < 0)
            score = 0;
        texT.text = "" + score;
    }
    public static void AddPoints (int pointsToAdd)
    {
        score += pointsToAdd;
    }
    public static void Reset()
    {
        score = 0;
    }


}
