using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.CompareTag("Bullet"))
        {
            gameObject.GetComponent <Health>().OnDamage(damage);
        }
    }
}
