using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreCollector : BallEvents
{
    [SerializeField] private int scores;
    [SerializeField] private LevelProgress levelProgress;


    public int Scores => scores;

    private int emptyPassed = 0;
    public int EmptyPassed => emptyPassed;

   [SerializeField] private int highScore;
    public int HighScore => highScore;

    protected override void Awake()
    {
        base.Awake();
        LoadHighScore();
        
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type==SegmentType.Empty)
        {
            scores += levelProgress.CurrentLevel;
            emptyPassed++;
        }

        if (type == SegmentType.Finish)
        {
            if (highScore<scores)
            {
                highScore = scores;
                SaveHighScore();
            }
            
        }

        if (type == SegmentType.Default) emptyPassed = 0;

        if (emptyPassed>1)
        {
            scores += levelProgress.CurrentLevel*emptyPassed;
        }

    }

    private void SaveHighScore()
    {
        PlayerPrefs.SetInt("HighScore", highScore);
    }
    private void LoadHighScore()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);

    }
}
