using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected float cooldown;
    protected int ammo;
    protected int speed;
    protected int damage;
    protected float atkSpeed;
    protected float dispersion;

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

    public void Destroy()
    {
        Destroy(gameObject);
    }
}
