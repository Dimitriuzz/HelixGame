using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelProgress : BallEvents
{
    
    protected override void Awake()
    {
        base.Awake();
        Load();
    
    }
    private int currentLevel = 1;
    public int CurrentLevel => currentLevel;

   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) == true)
        {
            Reset();
        }
    }
    protected override void OnBallCollisionSegment(SegmentType type)
    {
        if (type==SegmentType.Finish)
        {
            currentLevel++;
            Save();
        }
    }

    private void Save()
    {
        PlayerPrefs.SetInt("LevelProgress:CurrentLevel", currentLevel);
    }
    private void Load()
    {
        currentLevel = PlayerPrefs.GetInt("LevelProgress:CurrentLevel", 1);

    }

    private void Reset()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
