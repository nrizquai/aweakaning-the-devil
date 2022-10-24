using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected float _speed;
    [SerializeField] protected float pv;

    public virtual void TakeDamage(int damage)
    {
        pv -= damage;
    }

    public virtual void Death()
    {
        if (pv <= 0)
        {
            Destroy(gameObject);
        }
    }
}
