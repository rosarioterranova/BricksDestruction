using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColorChanger : MonoBehaviour
{
    private SpriteRenderer mSpriteRenderer;

    private void Awake()
    {
        mSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        mSpriteRenderer.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1);
    }
}
