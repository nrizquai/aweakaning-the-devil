using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected bool enemy;

    public Cards usedCard;
    public Cards[] cardsList;
    protected GameObject[] projectiles;
    protected int index;
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
        return usedCard.speed;
    }

    public float GetTimerMax()
    {
        return usedCard.atkSpeed;
    }

    public float GetCooldown()
    {
        return usedCard.cooldown;
    }
    public int GetAmmo()
    {
        return usedCard.ammo;
    }

    public int GetDamage()
    {
        return usedCard.damage;
    }

    public void SetBool(bool change)
    {
        enemy = change;
    }

    public void Destroy()
    {
        Destroy(gameObject);
    }

    public void InitiateCard()
    {
        usedCard = cardsList[2];
    }
    
    public void LoseLevel()
    {
        usedCard = cardsList[index - 1];
    }

    
}
