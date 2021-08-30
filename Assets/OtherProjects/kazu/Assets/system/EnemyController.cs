using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public GameObject EnemyBulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Shoot());
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-0.005f, 0, 0);

        if (transform.position.x < -12.0f)
        {
            Destroy(gameObject);
        }
        InvokeRepeating("Shoot", 1, 1);
    }

    private IEnumerator Shoot()
    {
        Instantiate(EnemyBulletPrefab, transform.position, Quaternion.identity);
        yield return new WaitForSeconds(1f);
        StartCoroutine(Shoot());
    }

    //void OnTriggerEnter2D(Collider2D col)
    //{
    //    Destroy(col.gameObject);
    //    Destroy(this.gameObject);
    //}
}