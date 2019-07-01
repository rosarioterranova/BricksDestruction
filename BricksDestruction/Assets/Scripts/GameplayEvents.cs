using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GameplayEvents : Singleton<GameplayEvents>
{
    public UnityEvent OnPointsChanged;
    public UnityEvent OnLivesChanged;

    public UnityEvent OnBrickRegistered;
    public UnityEvent OnBrickDestroyed;
}
