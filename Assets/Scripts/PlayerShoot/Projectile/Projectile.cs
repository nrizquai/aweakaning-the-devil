using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    protected bool enemy;

    public Cards usedCard;
    public Cards[] cardsList;
    protected GameObject[] projectiles;
    protected int index = 2;
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
    public float GetAmmo()
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
        index = 2;
    }
    
    public int LoseLevel()
    {
        if (index > 0)
        {
            index--;
            AudioManager.instance.sfxSource[3].PlayOneShot(AudioManager.instance.sfx[6]);
            usedCard = cardsList[index];
            return index;
        }
        else return -1;

        
    }

    
}
