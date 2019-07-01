using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickCollisionDetector : MonoBehaviour
{

    private GameplayEvents mGameplayEvents;

    private void Awake()
    {
        mGameplayEvents = GameplayEvents.Instance;
    }

    private void Start()
    {
        mGameplayEvents.OnBrickRegistered.Invoke();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Ball"))
        {
            Hit();
        }
    }

    private void Hit()
    {
        mGameplayEvents.OnBrickDestroyed.Invoke();
        Destroy(gameObject);
    }
}
