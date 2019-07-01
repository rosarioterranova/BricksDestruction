using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private GameData mGameData;
    private GameflowEvents mGameflowEvents;

    private void Awake()
    {
        mGameData = GameData.Instance;
        mGameflowEvents = GameflowEvents.Instance;
    }

    public void LoadMenu()
    {
        //Unload all scenes except main
        for (int i = 0; i < SceneManager.sceneCount; i++)
        {
            Scene scene = SceneManager.GetSceneAt(i);
            if (scene.name != "Main")
            {
                SceneManager.UnloadSceneAsync(scene);
            }
        }
        SceneManager.LoadSceneAsync("Menu", LoadSceneMode.Additive);
    }

    public void LoadNextLevel()
    {
        mGameData.ActualLevel++;
        if (mGameData.ActualLevel.Equals(1))
        {
            SceneManager.UnloadSceneAsync("Menu");
            SceneManager.LoadSceneAsync("Level" + mGameData.ActualLevel, LoadSceneMode.Additive);
        }
        else if (mGameData.ActualLevel.Equals(4))
        {
            mGameflowEvents.OnGoToMenu.Invoke();
        }
        else
        {
            SceneManager.LoadSceneAsync("Level" + mGameData.ActualLevel, LoadSceneMode.Additive);
        }
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadSceneAsync("Win", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Level" + mGameData.ActualLevel);
    }

    public void UnloadWinScreen()
    {
        SceneManager.UnloadSceneAsync("Win");
    }

    public void LoadLoseScreen()
    {
        SceneManager.LoadSceneAsync("Lose", LoadSceneMode.Additive);
        SceneManager.UnloadSceneAsync("Level" + mGameData.ActualLevel);
    }

    public void RestartLevel()
    {
        SceneManager.UnloadSceneAsync("Level" + mGameData.ActualLevel);
        SceneManager.LoadSceneAsync("Level" + mGameData.ActualLevel, LoadSceneMode.Additive);
    }
}
