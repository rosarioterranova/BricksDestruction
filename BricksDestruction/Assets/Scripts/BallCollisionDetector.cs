using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCollisionDetector : MonoBehaviour
{
    private Rigidbody2D mRigidbody2D;

    private void Awake()
    {
        mRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        mRigidbody2D.velocity += new Vector2(.2f, .2f); //fix for linear bounce
    }
}
