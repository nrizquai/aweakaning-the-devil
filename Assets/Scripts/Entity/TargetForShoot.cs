using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetForShoot : Vaticanais
{
    void Start()
    {
        
    }

    void Update()
    {
        TargetPlayer();
    }

    public Vector2 TargetPlayer()
    {
        Vector2 direction = _target.position - transform.position;
        transform.up = Vector3.MoveTowards(transform.up, direction, 50 * Time.deltaTime);
        return direction;
    }
}
