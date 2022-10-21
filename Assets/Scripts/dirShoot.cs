using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dirShoot : tourelle
{
    Rigidbody2D bulletDir;
    Vector2 dir;
    bool lockDir = false;
    float speedX = 10;
    float speedY = 10;
    private void Start()
    {
        /*Quaternion look = Quaternion.LookRotation(_target.position - transform.position).normalized;
        if (Vector2.Dot(transform.right, look) > 0.1f)
        {

        }
        /*bulletDir = GetComponent<Rigidbody2D>();
        if(_target.position.x > transform.position.x )
        {
            speedX = 10;
            speedY = 0;
        }
        if(_target.position.x < transform.position.x/2)
        {
            speedX = -10;
            speedY = 0;
        }
        if(_target.position.y < transform.position.y/2)
        {
            speedX = 0;
            speedY = 10;
        }
        if(_target.position.y < transform.position.y/2)
        {
            speedX = 0;
            speedY = -10;
        }*/
    }
    private void Update()
    {
        dir = bulletDir.position + Vector2.right * speedX * Time.deltaTime + Vector2.up * speedY * Time.deltaTime;
        bulletDir.MovePosition(dir);
    }
}
