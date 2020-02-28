using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{ 
    Health health;

    void Start()
    {
        health = gameObject.GetComponent<Health>();
    }
 
    void Death()
    {
        if(health.hp == 0)
        {
            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        Death();
    }
}
