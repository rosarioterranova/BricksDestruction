using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameflowEvents : Singleton<GameflowEvents>
{
    public UnityEvent OnGameInitialize;
    public UnityEvent OnGameStart;
    public UnityEvent OnGameOver;

    public UnityEvent OnLevelWin;
    public UnityEvent OnRestartLevel;
    public UnityEvent OnGoToNextLevel;
    public UnityEvent OnGoToMenu;
}
