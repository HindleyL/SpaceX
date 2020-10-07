using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int health = 50;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnDamage(int bulletDamage)
    {
        //making damage happen at rate of 5 per hit - 5 from health
        health=health-bulletDamage;
        //killing object at 0 health
        if (health <= 0)
        {
            Destroy(gameObject);
        }
    }
}