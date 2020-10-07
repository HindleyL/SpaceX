using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 100f;

    // Update is called once per frame
    void Update()
    {
        //shoot when spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.velocity = (-transform.up * speed);
        }
    }
}
