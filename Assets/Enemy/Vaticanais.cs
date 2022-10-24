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
    void Awake()
    {
        _target = FindObjectOfType<PControl>().transform;
    }

    void Update()
    {
        follow();
    }
    public virtual void follow()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}