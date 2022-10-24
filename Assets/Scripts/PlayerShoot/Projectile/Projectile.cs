using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected bool enemy;

    public Cards card;
    protected GameObject[] projectiles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public virtual int GetProjSpeed()
    {
        return card.speed;
    }

    public float GetTimerMax()
    {
        return card.atkSpeed;
    }

    public float GetCooldown()
    {
        return card.cooldown;
    }
    public int GetAmmo()
    {
        return card.ammo;
    }

    public int GetDamage()
    {
        return card.damage;
    }

    public void SetBool(bool change)
    {
        enemy = change;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    
}
