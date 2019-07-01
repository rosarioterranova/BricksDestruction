using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInitialPush : MonoBehaviour
{
    [SerializeField] float xInitialPush = 2f;
    [SerializeField] float yInitialPush = 10f;

    private Rigidbody2D mRigidbody2D;
    private bool mInitialPush = false;

    private void Awake()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !mInitialPush)
        {
            mInitialPush = true;
            mRigidbody2D.velocity = new Vector2(xInitialPush * RandomSign(), yInitialPush * RandomSign());
        }
    }

    private int RandomSign()
    {
        return Random.Range(0f, 1f) < .5f ? 1 : -1;
    }
}
