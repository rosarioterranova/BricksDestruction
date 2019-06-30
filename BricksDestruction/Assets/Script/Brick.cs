using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{
    GameManager mGameManager;

    void Awake()
    {
        mGameManager = GameManager.Instance;
    }

    void Start()
    {
        mGameManager.OnBrickRegistered.Invoke();
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            Hit();
        }
    }

    void Hit()
    {
        mGameManager.OnBrickDestroyed.Invoke();
        Destroy(gameObject);
    }
}
