using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public void OnClickPlay()
    {
        GameManager.Instance.StartGame();
    }

    public void OnClickExit()
    {
        Application.Quit();
    }
}
