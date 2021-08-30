using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour 
{
    public GameObject bullet;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            transform.Translate(0, 0.01f, 0);
        }
        else if (Input.GetKey("s"))
        {
            transform.Translate(0, -0.01f, 0);
        }

        if (Input.GetKeyDown("z"))
        {
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }
}
