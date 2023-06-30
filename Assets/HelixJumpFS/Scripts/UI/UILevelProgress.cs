using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UILevelProgress : BallEvents
{
    [SerializeField] private LevelProgress levelProgress;
    [SerializeField] private Text currentLevelText;
    [SerializeField] private Text nextLevelText;
    [SerializeField] private Image progressBar;
    [SerializeField] private LevelGenerator levelGenerator;

    private float fillAmountStep;
    void Start()
    {
        currentLevelText.text = levelProgress.CurrentLevel.ToString();
        nextLevelText.text = (levelProgress.CurrentLevel+1).ToString();

        fillAmountStep = 1 / levelGenerator.FloorAmount;

    }

    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if(type==SegmentType.Empty||type==SegmentType.Finish)
        { progressBar.fillAmount += fillAmountStep; }
    }
}
