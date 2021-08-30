using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject bullet;
    public float theta = 2;
    public float ySpeed = 1.5f;
    public float speed = 0.005f;

    public float bulletRate = 0.2f;

    public float deltaTime = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        deltaTime += Time.deltaTime;
        transform.position = new Vector3(transform.position.x - speed,(float)-Math.Sin(deltaTime * theta) * ySpeed, 0);

        if (transform.position.y > 5)
        {
            transform.position = new Vector3(transform.position.x, -5, 0);
        } else if (transform.position.x < -10)
        {
            transform.position = new Vector3(10, transform.position.y, 0);
        }
    }
    
    private IEnumerator Shoot()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(bulletRate);

        StartCoroutine(Shoot());
    }
}
