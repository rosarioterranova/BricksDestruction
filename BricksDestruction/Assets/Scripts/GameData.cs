using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData : Singleton<GameData>
{
    private GameflowEvents mGameflowEvents;
    private GameplayEvents mGameplayEvents;

    private int mActualLevel = 0;
    private int mPoints = 0;
    private int mLives = 3;

    private int mBricksCount = 0;
    private int mBricksDestroyed = 0;

    private void Awake()
    {
        mGameflowEvents = GameflowEvents.Instance;
        mGameplayEvents = GameplayEvents.Instance;
    }

    public int ActualLevel
    {
        get
        {
            return mActualLevel;
        }
        set
        {
            mActualLevel = value;
        }
    }

    public int Points
    {
        get
        {
            return mPoints;
        }
        set
        {
            mPoints = value;   
        }
    }

    public int Lives
    {
        get
        {
            return mLives;
        }
        set
        {
            mLives = value;
        }
    }

    public int BricksCount
    {
        get
        {
            return mBricksCount;
        }
        set
        {
            mBricksCount = value;
            Debug.Log("BricksCount: " + mBricksCount);
        }
    }

    public int BricksDestroyed
    {
        get
        {
            return mBricksDestroyed;
        }
        set
        {
            mBricksDestroyed = value;
            Debug.Log("Brick Destroyed: "+ mBricksDestroyed);
        }
    }

    public void ResetData()
    {
        mActualLevel = 0;
        mPoints = 0;
        mLives = 3;
        ResetBricks();
    }

    public void ResetBricks()
    {
        mBricksCount = 0;
        mBricksDestroyed = 0;
    }
}
