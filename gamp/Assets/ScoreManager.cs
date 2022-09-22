using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public TextMeshProUGUI textScore = null;

    private void Start()
    {
        textScore.text = "Score: 0";
    }
    public void OnTargetHit()
    {
        score += 1;
        textScore.text = "Score : " + score.ToString();
    }
}
