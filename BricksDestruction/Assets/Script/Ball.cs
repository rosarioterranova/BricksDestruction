using UnityEngine;

public class Ball : MonoBehaviour {

    [SerializeField] Paddle paddle;
    [SerializeField] float xInitialPush = 2f;
    [SerializeField] float yInitialPush = 10f;

    Vector2 mPaddleToBallDistance;
    Rigidbody2D mRigidBody2D;

    bool mIsGameStarted = false;

    void Start ()
    {
        mPaddleToBallDistance = transform.position - paddle.transform.position;
        mRigidBody2D = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
    {
        if (!mIsGameStarted)
        {
            LockBallToPaddle();
            LaunchOnMouseClick();
        }
    }

    void LaunchOnMouseClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mIsGameStarted = true;
            mRigidBody2D.velocity = new Vector2(xInitialPush, yInitialPush);
        }
    }

    void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle.transform.position.x, paddle.transform.position.y);
        transform.position = paddlePos + mPaddleToBallDistance;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (mIsGameStarted)
        {
            mRigidBody2D.velocity += new Vector2(.2f, .2f); //fix for linear bounce
        }
    }
}
