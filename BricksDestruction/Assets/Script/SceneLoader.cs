using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
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

        SceneManager.LoadSceneAsync("Menu",LoadSceneMode.Additive);
    }

    public void LoadLevel(int index)
    {
        if (index.Equals(1))
        {
            SceneManager.UnloadSceneAsync("Menu");
            SceneManager.LoadSceneAsync("Level" + index, LoadSceneMode.Additive);
        }
        else if(index.Equals(4))
        {
            SceneManager.LoadSceneAsync("Main");
        }
        else
        {
            SceneManager.LoadSceneAsync("Level" + index, LoadSceneMode.Additive);
        } 
    }

    public void RestartLevel(int index)
    {
        SceneManager.UnloadSceneAsync("Level" + index);
        SceneManager.LoadSceneAsync("Level" + index,LoadSceneMode.Additive);
    }

    public void LoadWinScreen()
    {
        SceneManager.LoadSceneAsync("Win", LoadSceneMode.Additive);
    }

    public void UnloadWinScreen()
    {
        SceneManager.UnloadSceneAsync("Win");
    }

    public void LoadLooseScreen()
    {
        SceneManager.LoadSceneAsync("Loose", LoadSceneMode.Additive);
    }

    public void UnloadLevel(int index)
    {
        SceneManager.UnloadSceneAsync("Level" + index);
    }
}
