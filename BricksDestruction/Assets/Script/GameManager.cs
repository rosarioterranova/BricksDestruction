using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameManager : Singleton<GameManager>
{
    SceneLoader mSceneLoader;
    AudioController mAudioController;
    ScoreManager mScoreManager;

    int mActualLevel = 0;
    int mBricksCount = 0;
    int mBricksDestroyed = 0;
    int mPoints = 0;
    int mLives = 3;

    public UnityEvent OnBrickDestroyed;
    public UnityEvent OnBrickRegistered;
    public UnityEvent OnLifeLoose;

    void Awake()
    {
        mSceneLoader = GetComponent<SceneLoader>();
        mAudioController = GetComponent<AudioController>();
        mScoreManager = GetComponent<ScoreManager>();
    }

    void Start()
    {
        InitializeGame();
        OnBrickDestroyed.AddListener(AddPoint);
        OnBrickRegistered.AddListener(AddBrick);
        OnLifeLoose.AddListener(RemoveLife);
    }

    void InitializeGame()
    {
        mActualLevel = 0;
        mBricksCount = 0;
        mBricksDestroyed = 0;
        mPoints = 0;
        mLives = 3;
        mSceneLoader.LoadMenu();
    }

    public void StartGame()
    {
        mScoreManager.ActivateScore(true);
        mActualLevel = 1;
        mSceneLoader.LoadLevel(mActualLevel);
    }

    public void GoToNextLevel()
    {
        mBricksCount = 0;
        mBricksDestroyed=0;
        mActualLevel++;
        mSceneLoader.UnloadWinScreen();
        mSceneLoader.LoadLevel(mActualLevel);
    }

    public void GoToMenu()
    {
        mSceneLoader.LoadMenu();
        mScoreManager.ActivateScore(false);
    }

    public int GetPoints()
    {
        return mPoints;
    }

    public int GetLives()
    {
        return mLives;
    }

    public int GetActualLevel()
    {
        return mActualLevel;
    }

    void AddBrick()
    {
        mBricksCount++;
    }

    void AddPoint()
    {
        mBricksDestroyed++;
        mPoints++;
        if (mBricksDestroyed.Equals(mBricksCount))
        {
            mSceneLoader.LoadWinScreen();
            mSceneLoader.UnloadLevel(mActualLevel);
        }
    }

    void RemoveLife()
    {
        if (mLives.Equals(0))
        {
            mSceneLoader.LoadLooseScreen();
            mSceneLoader.UnloadLevel(mActualLevel);
        }
        else
        {
            mBricksCount = 0;
            mBricksDestroyed = 0;
            mLives--;
            mSceneLoader.RestartLevel(mActualLevel);
        }
    }
}
