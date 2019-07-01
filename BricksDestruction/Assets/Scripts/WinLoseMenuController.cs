using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLoseMenuController : MonoBehaviour
{
    GameflowEvents mGameflowEvents;

    private void Awake()
    {
        mGameflowEvents = GameflowEvents.Instance;
    }


    public void OnClickNext()
    {
        mGameflowEvents.OnGoToNextLevel.Invoke();
    }

    public void OnClickMenu()
    {
        mGameflowEvents.OnGoToMenu.Invoke();
    }
}
