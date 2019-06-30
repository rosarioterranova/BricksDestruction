using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinScreenController : MonoBehaviour
{
    [SerializeField] GameObject NextBtn;

    GameManager mGameManager;

    void Awake()
    {
        mGameManager = GameManager.Instance;
    }

    void Start()
    {

        if(mGameManager.GetActualLevel().Equals(3))
        {
            NextBtn.SetActive(false);
        }
    }

    public void OnClickNext()
    {
        GameManager.Instance.GoToNextLevel();
    }

    public void OnClickMenu()
    {
        GameManager.Instance.GoToMenu();
    }
}
