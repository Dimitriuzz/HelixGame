using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScoreText : BallEvents
{
    [SerializeField] private ScoreCollector scoreCollector;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text highScoreText;
    [SerializeField] private GameObject bonusText;
    [SerializeField] private string preHighScoreText;

    private void Start()
    {
        highScoreText.text = preHighScoreText + " " + scoreCollector.HighScore;
        bonusText.SetActive(false);
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type!=SegmentType.Trap)
        {
            scoreText.text = scoreCollector.Scores.ToString();
        }

        if (type == SegmentType.Finish)
        {
            highScoreText.text = preHighScoreText + " " + scoreCollector.HighScore;
        }

        if (scoreCollector.EmptyPassed>1)
        {
            bonusText.SetActive(true);
        }
        else
        {
            bonusText.SetActive(false);
        }
    }
}
