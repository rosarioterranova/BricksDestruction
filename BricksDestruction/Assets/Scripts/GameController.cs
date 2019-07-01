using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private GameflowEvents mGameflowEvents;
    private GameplayEvents mGameplayEvents;
    private GameData mGameData;

    private void Awake()
    {
        mGameflowEvents = GameflowEvents.Instance;
        mGameplayEvents = GameplayEvents.Instance;
        mGameData = GameData.Instance;
    }

    private void Start()
    {
        mGameflowEvents.OnGameInitialize.Invoke();
    }

    public void AddBricks()
    {
        mGameData.BricksCount++;
    }

    public void RemoveBrick()
    {
        mGameData.BricksDestroyed++;
        CheckAllBricksDestroyed();
    }

    private void CheckAllBricksDestroyed()
    {
        if(mGameData.BricksCount.Equals(mGameData.BricksDestroyed))
        {
            mGameflowEvents.OnLevelWin.Invoke();
        }
    }

    public void RemoveLife()
    {
        mGameData.Lives--;
        CheckGameOver();
    }

    private void CheckGameOver()
    {
        if(mGameData.Lives.Equals(0))
        {
            mGameflowEvents.OnGameOver.Invoke();
        }
        else
        {
            mGameflowEvents.OnRestartLevel.Invoke();
        }
    }

    public void AddPoint()
    {
        mGameData.Points++;
        mGameplayEvents.OnPointsChanged.Invoke();
    }
}
