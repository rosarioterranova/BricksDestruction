using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreController : MonoBehaviour
{
    [SerializeField] Text LivesText;
    [SerializeField] Text PointsText;

    private GameData mGameData;

    private void Awake()
    {
        mGameData = GameData.Instance;
    }

    public void UpdateLives()
    {
        LivesText.text = "Lives: "+mGameData.Lives.ToString();
    }

    public void UpdatePoints()
    {
        PointsText.text = "Points: " + mGameData.Points.ToString();
    } 
}
