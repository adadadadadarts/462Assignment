using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreSetter : MonoBehaviour
{
    [SerializeField] private TMP_Text scoreText;
    public float score = 0;
    public float lastScore = 0;
    public const string HIGH_SCORE = "HighScore";
    public static ScoreSetter instance;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    // Update is called once per frame
    void Update()
    {
        scoreText.text = Mathf.FloorToInt(score).ToString();    
    }

    private void OnDestroy()
    {
        int highscore = PlayerPrefs.GetInt(HIGH_SCORE, 0);
        //lastScore = score;
        if (score > highscore)
        {
            PlayerPrefs.SetInt(HIGH_SCORE, Mathf.FloorToInt(score));
        }
    }

    public void CalculateScore(float multiplier)
    {
        score *= multiplier;
    }
}
