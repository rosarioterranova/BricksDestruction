using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{

    [SerializeField] GameObject ScoreCanvas;
    [SerializeField] Text LivesText;
    [SerializeField] Text PointsText;

    GameManager mGameManager;
    int ActualPoints = 0;
    int ActualLives = 3;

    void Awake()
    {
        mGameManager = GameManager.Instance;
        ActualPoints = mGameManager.GetPoints();
        ActualLives = mGameManager.GetLives();
    }

    void Start()
    {
        mGameManager.OnBrickDestroyed.AddListener(AddPoint);
        mGameManager.OnLifeLoose.AddListener(RemoveLife);
    }

    void AddPoint()
    {
        ActualPoints++;
        PointsText.text = "Points: " + ActualPoints;
    }

    void RemoveLife()
    {
        if(ActualLives.Equals(0))
        {
            return;
        }
        ActualLives--;
        LivesText.text = "Lives: " + ActualLives;
    }

    public void ActivateScore(bool active)
    {
        ScoreCanvas.SetActive(active);
    }
}
