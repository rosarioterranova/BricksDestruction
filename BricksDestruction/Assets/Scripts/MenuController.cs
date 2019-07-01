using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    GameflowEvents mGameflowEvents;

    private void Awake()
    {
        mGameflowEvents = GameflowEvents.Instance;
    }

    public void OnClickPlay()
    {
        mGameflowEvents.OnGameStart.Invoke();
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
