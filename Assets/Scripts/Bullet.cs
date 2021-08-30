using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 0.03f;
    
    void Update()
    {
        transform.Translate(speed, 0, 0);

        if (transform.position.x < -10f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!CompareTag(other.gameObject.tag))
        {
            Destroy(other.gameObject);
            Destroy(gameObject);
        }
    }
}
