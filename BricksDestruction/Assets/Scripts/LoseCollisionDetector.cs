using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            GameplayEvents.Instance.OnLivesChanged.Invoke();
        }
    }
}
