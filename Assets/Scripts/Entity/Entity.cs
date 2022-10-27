using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    [SerializeField] protected float _speed;
    [SerializeField] protected float pv;
    protected Animator animWalk;

    protected float timerSFX;
    protected float timerMaxSFX = 1;
    public virtual void TakeDamage(int damage, int indexSFX, int indexSource)
    {
        pv -= damage;
        if(timerSFX <= 0) 
        {
            AudioManager.instance.sfxSource[indexSource].PlayOneShot(AudioManager.instance.sfx[indexSFX]);
            timerSFX = timerMaxSFX;
        }
    }

    public virtual void Death()
    {
        if (pv <= 0)
        {
            Destroy(gameObject);
            GameManager.instance.mobKill++;
        }
    }

    public float GetTimer()
    {
        return timerSFX;
    }
}
