using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vaticanais : Entity
{ 
    protected Transform _target;
    public Transform aim;
    public GameObject bullet;
    [SerializeField] protected float cooldown = 2;
    protected float maxCooldown = 2;
    protected Vector3 lastPos;
    void Awake()
    {
        _target = FindObjectOfType<PControl>().transform;
        animWalk = this.GetComponent<Animator>();
    }

    void Update()
    {
        follow();
    }
    public virtual void follow()
    {
        lastPos = transform.position;
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
        float x = transform.position.x - lastPos.x;
        float y = transform.position.y - lastPos.y;

        if(Mathf.Abs(x)> Mathf.Abs(y))
        {
            if(x > 0)
            {
                animWalk.SetFloat("PosX", 1);
                animWalk.SetFloat("PosY", 0);
            }
            else
            {
                animWalk.SetFloat("PosX", -1);
                animWalk.SetFloat("PosY", 0);
            }
        }
        else
        {
            if(y > 0)
            {
                animWalk.SetFloat("PosX", 0);
                animWalk.SetFloat("PosY", 1);
            }
            else
            {
                animWalk.SetFloat("PosX", 0);
                animWalk.SetFloat("PosY", -1);
            }
        }
    }
}