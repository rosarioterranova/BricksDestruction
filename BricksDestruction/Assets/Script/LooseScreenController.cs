using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LooseScreenController : MonoBehaviour
{
    public void OnClickMenu()
    {
        GameManager.Instance.GoToMenu();
    }
}
