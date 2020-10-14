using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Asteroid : Health
{
    public GameObject Cloth;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public override void OnDamage(int bulletDamage)
    {
        base.OnDamage(bulletDamage);
        if (health == 0)
        {
            GameObject instBullet = Instantiate(Cloth, transform.position, Quaternion.identity) as GameObject;
        }
    }
}
